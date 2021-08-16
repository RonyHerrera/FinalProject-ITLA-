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
    public partial class FrmMDeDoctores : Form
    {
        int comportamiento;
        int IndexDB = -1;

        ServiciosDoctores servicios;

        public FrmMDeDoctores(int num)
        {
            InitializeComponent();
            this.comportamiento = num;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosDoctores(connection);
        }

        #region "EVENTOS"
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Atras();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnEditaruser_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void FrmMDeDoctores_Load(object sender, EventArgs e)
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
            FrmAddEditDoctores frm = new FrmAddEditDoctores(comportamiento, 1);
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
                Doctor doctor = servicios.GetById(IndexDB);
                FrmAddEditDoctores frm = new FrmAddEditDoctores(comportamiento, 2);
                frm.IdUser = doctor.Id;
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
