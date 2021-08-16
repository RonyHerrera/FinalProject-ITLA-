using BuinesLayer;
using Database.Modelos;
using FinalProject.CustonControlItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FrmAddEditUser : Form
    {
        public int IdUser;
        int comportamientoGlobal;
        int comportamientoLocal;
        ServiciosUsuarios servicios;

        public FrmAddEditUser(int comportamientoGlobal, int comportamientoLocal)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            this.comportamientoGlobal = comportamientoGlobal;
            this.comportamientoLocal = comportamientoLocal;
            servicios = new ServiciosUsuarios(connection);
        }

        #region "EVENTOS"

        private void FrmAddEditUser_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void txtRegNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegGuardar_Click(object sender, EventArgs e)
        {
            ProcesarFormulario();
        }

        private void BtnRegCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        #endregion

        #region "Metodos Privados"

        public void ProcesarFormulario()
        {
            if(comportamientoLocal == 1)
            {
                if (!string.IsNullOrEmpty(TbxNombre.Text) && !string.IsNullOrEmpty(TbxApellido.Text) 
                    && !string.IsNullOrEmpty(TbxNombreUser.Text) && !string.IsNullOrEmpty(TbxContrasena.Text) 
                    && !string.IsNullOrEmpty(TbxConContrasena.Text) && CbxTipodeUser.Text != "")
                {
                    if (TbxContrasena.Text == TbxConContrasena.Text)
                    {

                        ComboBoxItem selectedItemUser = CbxTipodeUser.SelectedItem as ComboBoxItem;
                        Usuarios user = new Usuarios();

                        user.Nombre = TbxNombre.Text;
                        user.Apellido = TbxApellido.Text;
                        user.Correo = TbxCorreo.Text;
                        user.NombreDeUsuario = TbxNombreUser.Text;
                        user.Contraseña = TbxContrasena.Text;
                        user.TipoDeUsuario = selectedItemUser.Value;

                        bool bol = servicios.Add(user);

                        if (bol == true)
                        {
                            MessageBox.Show("Usuario agregado con exito", "NOTIFICACION");
                            CerrarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error comuniquese con el area de mantenimiento", "ADVERTENCIA");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden","ADVERTENCIA");
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos","ADVERTENCIA");
                }

            }
            else if(comportamientoLocal == 2)
            {

                if (!string.IsNullOrEmpty(TbxNombre.Text) && !string.IsNullOrEmpty(TbxApellido.Text)
                   && !string.IsNullOrEmpty(TbxNombreUser.Text) && !string.IsNullOrEmpty(TbxContrasena.Text)
                   && !string.IsNullOrEmpty(TbxConContrasena.Text) && CbxTipodeUser.Text != "")
                {
                    if (TbxContrasena.Text == TbxConContrasena.Text)
                    {

                        ComboBoxItem selectedItemUser = CbxTipodeUser.SelectedItem as ComboBoxItem;

                        Usuarios user = new Usuarios
                        {
                            Id = IdUser,
                            Nombre = TbxNombre.Text,
                            Apellido = TbxApellido.Text,
                            Correo = TbxCorreo.Text,
                            NombreDeUsuario = TbxNombreUser.Text,
                            Contraseña = TbxContrasena.Text,
                            TipoDeUsuario = selectedItemUser.Value
                        };


                        bool bol = servicios.Update(user);


                        if (bol == true)
                        {
                            MessageBox.Show("Usuario editado con exito", "NOTIFICACION");
                            CerrarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error comuniquese con el area de mantenimiento", "ADVERTENCIA");
                            CerrarFormulario();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "ADVERTENCIA");
                    }

                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "ADVERTENCIA");
                }

            }
        }

        public void CerrarFormulario()
        {
            FrmMDeUsuarios frm = new FrmMDeUsuarios(comportamientoGlobal);
            frm.Show();
            this.Close();
        }

        public void CargarComboBox()
        {

            ComboBoxItem defauld = new ComboBoxItem
            {
                Text = "Seleccione una opcion",
                Value = 0,
            };

            ComboBoxItem opcion1 = new ComboBoxItem
            {
                Text = "Administrador",
                Value = 1
            };

            ComboBoxItem opcion2 = new ComboBoxItem
            {
                Text = "Doctor",
                Value = 2
            };

            if (comportamientoLocal == 1)
            {
                CbxTipodeUser.Items.Add(defauld);
                CbxTipodeUser.Items.Add(opcion1);
                CbxTipodeUser.Items.Add(opcion2);
                CbxTipodeUser.SelectedItem = defauld;
            }
            else
            {
                Usuarios user =  servicios.GetById(IdUser);
                TbxNombre.Text = user.Nombre;
                TbxApellido.Text = user.Apellido;
                TbxNombreUser.Text = user.NombreDeUsuario;
                TbxCorreo.Text = user.Correo;
                TbxContrasena.Text = user.Contraseña;
                TbxConContrasena.Text = user.Contraseña;


                CbxTipodeUser.Items.Add(defauld);
                CbxTipodeUser.Items.Add(opcion1);
                CbxTipodeUser.Items.Add(opcion2);

                if (user.TipoDeUsuario == 1)
                {
                    CbxTipodeUser.SelectedItem = opcion1;
                }
                else if (user.TipoDeUsuario == 2)
                {
                    CbxTipodeUser.SelectedItem = opcion2;
                }
               
            }
            
        }
        #endregion

    }
}
