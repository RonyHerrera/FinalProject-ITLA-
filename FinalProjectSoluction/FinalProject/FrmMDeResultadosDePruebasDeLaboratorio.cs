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
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnEditaruser_Click(object sender, EventArgs e)
        {
            Edit();
        }

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

        public void Agregar()
        {
            FrmAddEditResultadosPruebDeLab frm = new FrmAddEditResultadosPruebDeLab(comportamiento, 1);
            frm.Show();
            this.Close();
        }

        public void Delete()
        {
            if (IndexDB != -1)
            {
                DialogResult result = MessageBox.Show("Esta seguro que lo desea ELIMINAR ??", "MENSAGE", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    servicios.Delete(IndexDB);
                    CargarDataGridView();
                    IndexDB = -1;
                }

            }
            else
            {
                MessageBox.Show("No ha seleccionado nada", "NOTIFICACION");
            }
        }

        public void Edit()
        {
            if (IndexDB != -1)
            {
                Resultados resul = servicios.GetById(IndexDB);
                FrmAddEditResultadosPruebDeLab frm = new FrmAddEditResultadosPruebDeLab(comportamiento, 2);
                frm.IdUser = resul.Id;
                frm.Show();
                IndexDB = -1;
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado nada", "NOTIFICACION");
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
