using BuinesLayer;
using Database.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Login : Form
    {

        ServiciosUsuarios servicios;
        public static Login instancia = new Login();

        private Login()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicios = new ServiciosUsuarios(connection);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIniciarSeccion_Click(object sender, EventArgs e)
        {
            IniciarSeccion();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void IniciarSeccion()
        {           
            if(!string.IsNullOrEmpty(TbxUserName.Text) && !string.IsNullOrEmpty(TbtContrasena.Text))
            {
               Usuarios usuario = servicios.GetName(TbxUserName.Text);

                if (usuario.Id > 0)
                {
                    if (usuario.Contraseña == TbtContrasena.Text)
                    {
                        AbrirMenuHome(usuario.TipoDeUsuario);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "ADVERTENCIA");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "ADVERTENCIA");
                }
            }
            else
            {
                MessageBox.Show("Debe llebar todos los campos", "ADVERTENCIA");
            }
        }

        private void AbrirMenuHome(int TipoDeUsuario)
        {
            this.Hide();
            FrmMenuHome frm= new FrmMenuHome(TipoDeUsuario);
            frm.Show();
        }

        private void LimpiarCampos()
        {
            TbxUserName.Text = "";
            TbtContrasena.Text = "";
        }

    }
}
