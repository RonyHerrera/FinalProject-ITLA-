using BuinesLayer;
using Database.Modelos;
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
    public partial class FrmAddEditDoctores : Form
    {
        int comportamientoGlobal;
        int comportamientoLocal;
        public int IdUser;
        ServiciosDoctores servicios;

        public FrmAddEditDoctores(int comportamientoGlobal, int comportamientoLocal)
        {
            InitializeComponent();
            this.comportamientoGlobal = comportamientoGlobal;
            this.comportamientoLocal = comportamientoLocal;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosDoctores(connection);
        }

        #region "EVENTOS"
        private void LblUserName_Click(object sender, EventArgs e)
        {

        }

        private void BtmAddFoto_Click(object sender, EventArgs e)
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

        private void FrmAddEditDoctores_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }
        #endregion

        #region "METODOS PRIVADOS"

        public void ProcesarFormulario()
        {
            if (comportamientoLocal == 1)
            {
                if (!string.IsNullOrEmpty(TbxNombre.Text) && !string.IsNullOrEmpty(TbxApellido.Text)
                    && !string.IsNullOrEmpty(TbxCorreo.Text) && !string.IsNullOrEmpty(TbxTelefono.Text)
                    && !string.IsNullOrEmpty(TbxCedula.Text))
                {

                    Doctor doctor = new Doctor {
                        Nombre = TbxNombre.Text,
                        Apellido = TbxApellido.Text,
                        Correo = TbxCorreo.Text,
                        Telefono = TbxTelefono.Text,
                        Cedula = TbxCedula.Text,
                        Foto = ""
                    };

                    bool bol = servicios.Add(doctor);

                    if (bol == true)
                    {
                        MessageBox.Show("Doctor agregado con exito", "NOTIFICACION");
                        CerrarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error comuniquese con el area de mantenimiento", "ADVERTENCIA");
                        }

                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "ADVERTENCIA");
                }

            }
            else if (comportamientoLocal == 2)
            {

                if (!string.IsNullOrEmpty(TbxNombre.Text) && !string.IsNullOrEmpty(TbxApellido.Text)
                     && !string.IsNullOrEmpty(TbxCorreo.Text) && !string.IsNullOrEmpty(TbxTelefono.Text)
                     && !string.IsNullOrEmpty(TbxCedula.Text))
                {

                    Doctor doctor = new Doctor
                    {
                        Id = IdUser,
                        Nombre = TbxNombre.Text,
                        Apellido = TbxApellido.Text,
                        Correo = TbxCorreo.Text,
                        Telefono = TbxTelefono.Text,
                        Cedula = TbxCedula.Text,
                        Foto = ""
                    };


                    bool bol = servicios.Update(doctor);


                    if (bol == true)
                    {
                        MessageBox.Show("Doctor editado con exito", "NOTIFICACION");
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
                    MessageBox.Show("Debe llenar todos los campos", "ADVERTENCIA");
                }

            }
        }

        public void CerrarFormulario()
        {
            FrmMDeDoctores frm = new FrmMDeDoctores(comportamientoGlobal);
            frm.Show();
            this.Close();
        }

        public void CargarFormulario()
        {
            if (comportamientoLocal == 2)
            {
                Doctor doctor = servicios.GetById(IdUser);

                TbxNombre.Text = doctor.Nombre;
                TbxApellido.Text = doctor.Apellido;
                TbxCorreo.Text = doctor.Correo;
                TbxTelefono.Text = doctor.Telefono;
                TbxCedula.Text = doctor.Cedula;
            }
        }

        private void AddPhoto()
        {
            DialogResult result = PictureDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = PictureDialog.FileName;
            }
        }

        #endregion

    }
}
