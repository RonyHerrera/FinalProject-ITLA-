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
    public partial class FrmMDeUsuarios : Form
    {
        int comportamiento;
        int IndexDB = -1;

        ServiciosUsuarios servicios;

        public FrmMDeUsuarios(int num)
        {
            InitializeComponent();
            this.comportamiento = num;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosUsuarios(connection);
        }

        #region "EVENTOS"
        private void FrmMantenimientoDeUsuarios_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Atras();
        }

        private void btnEditaruser_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexDB = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        #endregion

        #region "Metodos Privados"

        private void Atras()
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

        private void Agregar()
        {
            FrmAddEditUser frm = new FrmAddEditUser(comportamiento, 1);
            frm.Show();
            this.Close();
        }

        private void Delete()
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
                MessageBox.Show("No ha seleccionado nada","NOTIFICACION");
            }
        }

        private void Edit()
        {
            if (IndexDB != -1)
            {
                Usuarios user = servicios.GetById(IndexDB);
                FrmAddEditUser frm = new FrmAddEditUser(comportamiento, 2);
                frm.IdUser = user.Id;
                frm.Show();
                IndexDB = -1;
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado nada", "NOTIFICACION");
            }
        }

        private void CargarDataGridView()
        {
            dataGridView1.DataSource = servicios.GetAll();
            dataGridView1.ClearSelection();
        }
        #endregion

    }
}
