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
    public partial class FrmReportarPruebaDeLab : Form
    {
        int comportamientoGlobal;
        int IdUser;
        ServiciosResultados servicios;

        public FrmReportarPruebaDeLab(int comportamientoGlobal, int IdUser)
        {
            InitializeComponent();
            this.comportamientoGlobal = comportamientoGlobal;
            this.IdUser = IdUser;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosResultados(connection);
        }

        #region "EVENTOS"
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ctnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            ProcesarFormulario();
        }

        private void FrmReportarPruebaDeLab_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region "Metodos Privados

        public void ProcesarFormulario()
        {           
            if (!string.IsNullOrEmpty(TbxResultado.Text))
            {
                Resultados result = servicios.GetById(IdUser);
                result.ResultadosDeLaPrueba = TbxResultado.Text;
                result.EstadoDelResultado = 2;


                bool bol = servicios.Update(result);


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

        public void CerrarFormulario()
        {
            FrmMDeResultadosDePruebasDeLaboratorio frm = new FrmMDeResultadosDePruebasDeLaboratorio(comportamientoGlobal);
            frm.Show();
            this.Close();
        }

        #endregion
    }
}
