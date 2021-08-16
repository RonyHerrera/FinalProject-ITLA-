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
    public partial class FrmAgregarCitaListaDeDoctores : Form
    {
        int comportamientoGlobal;
        int IndexDB = -1;
        Cita cita;

        ServiciosCitas servicios;
        ServiciosDoctores serviciosDoctores;

        public FrmAgregarCitaListaDeDoctores(int comportamientoGlobal, Cita cita)
        {
            InitializeComponent();
            this.comportamientoGlobal = comportamientoGlobal;
            this.cita = cita;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosCitas(connection);
            serviciosDoctores = new ServiciosDoctores(connection);
        }

        #region "EVENTOS"

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FrmAgregarCitaListaDeDoctores_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexDB = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        #endregion

        #region "METODOS PRIVADOS"
        private void Atras()
        {
            FrmAgregarCitasListadoPacientes frm = new FrmAgregarCitasListadoPacientes(comportamientoGlobal);
            frm.Show();
            this.Close();
        }

        private void Continuar()
        {
            if (IndexDB != -1)
            {
                cita.IdDoctor = IndexDB;
                FrmAgregarCitaFormulario frm = new FrmAgregarCitaFormulario(comportamientoGlobal,cita);
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado nada", "ADVERTENCIA");
            }
        }

        private void Buscar()
        {
            if (!string.IsNullOrEmpty(TbxBuscar.Text))
            {
                serviciosDoctores.GetByCedula(TbxBuscar.Text);
            }
        }

        private void CargarDataGridView()
        {
            dataGridView1.DataSource = serviciosDoctores.GetAll();
            dataGridView1.ClearSelection();
        }
        #endregion

    }
}
