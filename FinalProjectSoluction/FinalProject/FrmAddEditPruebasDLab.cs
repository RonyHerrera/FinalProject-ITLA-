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
    public partial class FrmAddEditPruebasDLab : Form
    {
        int comportamientoGlobal;
        int comportamientoLocal;
        public int IdUser;
        ServiciosPruebas servicios;

        public FrmAddEditPruebasDLab(int comportamientoGlobal, int comportamientoLocal)
        {
            InitializeComponent();
            this.comportamientoGlobal = comportamientoGlobal;
            this.comportamientoLocal = comportamientoLocal;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosPruebas(connection);
        }

        #region "EVENTOS"
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnCrearPrueba_Click(object sender, EventArgs e)
        {
            ProcesarFormulario();
        }

        private void FrmAddEditPruebasDLab_Load(object sender, EventArgs e)
        {
            CargarFromulario();
        }
        #endregion

        #region "Metodos Privados

        public void ProcesarFormulario()
        {
            if (comportamientoLocal == 1)
            {
                if (!string.IsNullOrEmpty(TbxNombre.Text))
                {
                    Prueba prueba = new Prueba {
                        Nombre = TbxNombre.Text
                    };

                    bool bol = servicios.Add(prueba);

                    if (bol == true)
                    {
                        MessageBox.Show("Prueba agregada con exito", "NOTIFICACION");
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

                if (!string.IsNullOrEmpty(TbxNombre.Text))
                {

                    Prueba prueba = new Prueba
                    {
                        Id = IdUser,
                        Nombre = TbxNombre.Text
                    };

                    bool bol = servicios.Update(prueba);


                        if (bol == true)
                        {
                            MessageBox.Show("Prueba editada con exito", "NOTIFICACION");
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
            FrmMPruebasDeLaboratorio frm = new FrmMPruebasDeLaboratorio(comportamientoGlobal);
            frm.Show();
            this.Close();
        }

        public void CargarFromulario()
        {
            if(comportamientoLocal == 2)
            {
                Prueba prueba = servicios.GetById(IdUser);
                TbxNombre.Text = prueba.Nombre;
            }
        }

        #endregion
    }
}
