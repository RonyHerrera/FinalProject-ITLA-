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
    public partial class FrmAgregarCitasListadoPacientes : Form
    {
        int comportamientoGlobal;
        int IndexDB = -1;

        ServiciosCitas servicios;
        ServiciosPacientes serviciosPacientes;

        public FrmAgregarCitasListadoPacientes(int comportamientoGlobal)
        {
            InitializeComponent();
            this.comportamientoGlobal = comportamientoGlobal;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosCitas(connection);
            serviciosPacientes = new ServiciosPacientes(connection);
        }

        #region "EVENTOS"
        private void FrmAgregarCitasListado_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            Continuar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Atras();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexDB = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        #endregion

        #region "METODOS PRIVADOS"
        private void Atras()
        {          
            FrmMDeCitas frm = new FrmMDeCitas(comportamientoGlobal);
            frm.Show();
            this.Close();
        }

        private void Continuar()
        {
            if(IndexDB != -1)
            {               
                Cita cita = new Cita {
                    IdPacientes = IndexDB
                };

                FrmAgregarCitaListaDeDoctores frm = new FrmAgregarCitaListaDeDoctores(comportamientoGlobal, cita);
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado nada","ADVERTENCIA");
            }
        }

        private void Buscar()
        {
            if (!string.IsNullOrEmpty(TbxBuscar.Text))
            {
                serviciosPacientes.GetByCedula(TbxBuscar.Text);
            }
        }

        private void CargarDataGridView()
        {
            dataGridView1.DataSource = serviciosPacientes.GetAll();
            dataGridView1.ClearSelection();
        }
        #endregion
    }
}
