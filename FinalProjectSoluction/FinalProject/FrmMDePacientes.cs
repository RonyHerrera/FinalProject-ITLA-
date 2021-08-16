using BuinesLayer;
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
    public partial class FrmMDePacientes : Form
    {
        int comportamiento;
        int IndexDB = -1;

        ServiciosPacientes servicios;

        public FrmMDePacientes(int num)
        {
            InitializeComponent();
            this.comportamiento = num;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosPacientes(connection);
        }

        #region "EVENTOS"
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Atras();
        }

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

        private void FrmMDePacientes_Load(object sender, EventArgs e)
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
            FrmAddEditPacientes frm = new FrmAddEditPacientes(comportamiento, 1);
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
                FrmAddEditPacientes frm = new FrmAddEditPacientes(comportamiento, 2);
                frm.IdUser = IndexDB;
                frm.Show();                
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
