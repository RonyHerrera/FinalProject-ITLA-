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
    public partial class FrmAgregarCitaFormulario : Form
    {
        int comportamientoGlobal;
        int IndexDB =-1;
        Cita cita;
        ServiciosCitas servicios;
        ServiciosDoctores serviciosDoctores;
        ServiciosPacientes serviciosPacientes;

        public FrmAgregarCitaFormulario(int comportamientoGlobal, Cita cita)
        {
            InitializeComponent();
            this.comportamientoGlobal = comportamientoGlobal;
            this.cita = cita;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosCitas(connection);
            serviciosDoctores = new ServiciosDoctores(connection);
            serviciosPacientes = new ServiciosPacientes(connection);
        }


        #region "EVENTOS"
        private void FrmAgregarCitaFormulario_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Atras();
        }

        private void BtnCrearCita_Click(object sender, EventArgs e)
        {
            ProcesarFormulario();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        #endregion

        #region "METODOS PRIVADOS"

        private void ProcesarFormulario()
        {
            if (!string.IsNullOrEmpty(TbxCausa.Text) && DtpFecha.Checked)
            {
                cita.CausaDeLaCita = TbxCausa.Text;
                cita.FechaYHoraDeLaCita = DtpFecha.Value;
                cita.EstadoDeLaCita = 1;

                bool bol = servicios.Add(cita);

                if (bol == true)
                {
                    MessageBox.Show("Cita creada con exito","NOTIFICACION");
                    FrmMDeCitas frm = new FrmMDeCitas(comportamientoGlobal);
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error comuniquese con el departamento de mantenimiento", "ADVERTENCIA");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos","ADVERTENCIA");
            }
        }

        private void CargarFormulario()
        {
           Doctor doctor = serviciosDoctores.GetById(cita.IdDoctor);
           Paciente paciente = serviciosPacientes.GetById(cita.IdPacientes);

            TbxDoctor.Text = doctor.Nombre;
            TbxPaciente.Text = paciente.Nombre;
        }

        private void Atras()
        {
            FrmAgregarCitaListaDeDoctores frm = new FrmAgregarCitaListaDeDoctores(comportamientoGlobal, cita);
            frm.Show();
            this.Close();
        }

        private void Cancelar()
        {
            FrmMDeCitas frm = new FrmMDeCitas(comportamientoGlobal);
            frm.Show();
            this.Close();
        }
        #endregion
    }
}
