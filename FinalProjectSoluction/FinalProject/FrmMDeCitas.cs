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
    public partial class FrmMDeCitas : Form
    {
        int comportamiento;
        int IndexDB = -1;
        ServiciosCitas servicios;

        public FrmMDeCitas(int num)
        {
            InitializeComponent();
            this.comportamiento = num;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosCitas(connection);
        }

        #region "EVENTOS"
        private void button1_Click(object sender, EventArgs e)
        {
            Atras();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void BtnMultiUso_Click(object sender, EventArgs e)
        {

        }

        private void FrmMDeCitas_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexDB = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            ActivarBoton();
        }
        #endregion

        #region "METODOS PRIVADOS"

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
            FrmAgregarCitasListadoPacientes frm = new FrmAgregarCitasListadoPacientes(comportamiento);
            frm.Show();
            this.Close();
        }

        private void ActivarBoton()
        {
            Cita cita = servicios.GetById(IndexDB);

            if (cita.EstadoDeLaCita == 1)
            {
                BtnMultiUso.Visible = true;
                BtnMultiUso.Text = "Consultar";
            }
            else if (cita.EstadoDeLaCita == 2)
            {
                BtnMultiUso.Visible = true;
                BtnMultiUso.Text = "Consultar resultados ";
            }
            else if(cita.EstadoDeLaCita == 3)
            {
                BtnMultiUso.Visible = true;
                BtnMultiUso.Text = "Ver resultados";
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
