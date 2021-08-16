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
    public partial class FrmAddEditPacientes : Form
    {
        int comportamientoLocal;
        int comportamientoGlobal;
        public int IdUser;
        ServiciosPacientes servicios;

        public FrmAddEditPacientes(int ComportamientoGlobal, int ComportamientoLocal)
        {
            InitializeComponent();
            this.comportamientoGlobal = ComportamientoGlobal;
            this.comportamientoLocal = ComportamientoLocal;
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosPacientes(connection);
        }

        #region "EVENTOS"
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegGuardar_Click(object sender, EventArgs e)
        {
            ProcesarFormulario();
        }

        private void BtnRegCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtmAddFoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        private void FrmAddEditPacientes_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        #endregion

        #region "METODOS PRIVADOS"

        public void ProcesarFormulario()
        {
            if (comportamientoLocal == 1)
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(TxtApellido.Text)
                    && !string.IsNullOrEmpty(TxtTelefono.Text) && !string.IsNullOrEmpty(TxtDireccion.Text)
                    && !string.IsNullOrEmpty(TxtCedula.Text) && !string.IsNullOrEmpty(TxtAlergias.Text)
                    && dateTimePicker1.Checked)
                {

                    Paciente paciente = new Paciente
                    {
                        Nombre = txtNombre.Text,
                        Apellido = TxtApellido.Text,
                        Telefono = TxtTelefono.Text,
                        Direccion = TxtDireccion.Text,
                        Cedula = TxtCedula.Text,
                        FechaDeNacimiento = dateTimePicker1.Value,
                        Fumador = checkBox1.Checked ? true : false,
                        Alergias = TxtAlergias.Text,
                        Foto = ""
                    };

                    bool bol = servicios.Add(paciente);

                    if (bol == true)
                    {
                        MessageBox.Show("Paciente agregado con exito", "NOTIFICACION");
                        CerrarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error comuniquese con el area de mantenimiento", "ADVERTENCIA");
                    }

                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "ADVERTENCIA");
                }

            }
            else if (comportamientoLocal == 2)
            {

                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(TxtApellido.Text)
                    && !string.IsNullOrEmpty(TxtTelefono.Text) && !string.IsNullOrEmpty(TxtDireccion.Text)
                    && !string.IsNullOrEmpty(TxtCedula.Text) && !string.IsNullOrEmpty(TxtAlergias.Text))
                {

                    Paciente paciente = new Paciente
                    {
                        Id = IdUser,
                        Nombre = txtNombre.Text,
                        Apellido = TxtApellido.Text,
                        Telefono = TxtTelefono.Text,
                        Direccion = TxtDireccion.Text,
                        Cedula = TxtCedula.Text,
                        FechaDeNacimiento = dateTimePicker1.Value,
                        Fumador = checkBox1.Checked ? true : false,
                        Alergias = TxtAlergias.Text,
                        Foto = ""
                    };


                    bool bol = servicios.Update(paciente);


                    if (bol == true)
                    {
                        MessageBox.Show("Paciente editado con exito", "NOTIFICACION");
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
        }

        public void CerrarFormulario()
        {
            FrmMDePacientes frm = new FrmMDePacientes(comportamientoGlobal);
            frm.Show();
            this.Close();
        }

        public void CargarFormulario()
        {
            if (comportamientoLocal == 2)
            {               
                Paciente paciente = servicios.GetById(IdUser);

                MessageBox.Show($"{paciente.Nombre}", "NOTIFICACION");
                if (paciente != null)
                {
                    txtNombre.Text = paciente.Nombre;
                    TxtApellido.Text = paciente.Apellido;
                    TxtTelefono.Text = paciente.Telefono;
                    TxtDireccion.Text = paciente.Direccion;
                    TxtCedula.Text = paciente.Cedula;
                    TxtAlergias.Text = paciente.Alergias;
                    dateTimePicker1.MinDate = paciente.FechaDeNacimiento ;
                
                    if(paciente.Fumador == true)
                    {
                        checkBox1.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR comuniquese con el departamento de mantenimiento", "NOTIFICACION");
                }

            }
        }

        private void AddPhoto()
        {
            DialogResult result = PictureDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = PictureDialog.FileName;
            }
        }

        #endregion


    }
}
