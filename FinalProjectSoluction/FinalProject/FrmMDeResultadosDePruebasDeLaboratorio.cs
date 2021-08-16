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
    public partial class FrmMDeResultadosDePruebasDeLaboratorio : Form
    {
        int comportamiento;
        int IndexDB = -1;

        ServiciosResultados servicios;

        public FrmMDeResultadosDePruebasDeLaboratorio(int num)
        {
            InitializeComponent();
            this.comportamiento = num;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosResultados(connection);
        }

        #region "EVENTOS"
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Atras();
        }

        private void FrmMDeResultadosDePruebasDeLaboratorio_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexDB = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnReportar_Click(object sender, EventArgs e)
        {
            Reportar();
        }
        #endregion

        #region "Metodos Privados"
        public void Atras()
        {
            if (comportamiento == 1)
            {
                FrmMenuHome frm = new FrmMenuHome(comportamiento);
                frm.Show();
                this.Close();
            }
            else
            {
                FrmMenuHome frm = new FrmMenuHome(comportamiento);
                frm.Show();
                this.Close();
            }
        }

        public void Reportar()
        {
            if (IndexDB != -1)
            {
                Resultados resul = servicios.GetById(IndexDB);

                FrmReportarPruebaDeLab frm = new FrmReportarPruebaDeLab(comportamiento, resul.Id);
                frm.Show();
                IndexDB = -1;
                this.Close();

            }
            else
            {
                MessageBox.Show("No ha seleccionado nada", "NOTIFICACION");
            }
        }
        
        public void Buscar()
        {
            if (!string.IsNullOrEmpty(TbxBuscar.Text))
            {
                servicios.GetByCedula(TbxBuscar.Text);
            }
        }

        public void CargarDataGridView()
        {
            dataGridView1.DataSource = servicios.GetAll();
            dataGridView1.ClearSelection();
        }
        #endregion
    }
}
