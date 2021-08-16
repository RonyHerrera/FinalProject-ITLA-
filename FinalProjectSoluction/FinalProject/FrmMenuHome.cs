using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FrmMenuHome : Form
    {
        int comportamiento;

        public FrmMenuHome(int num)
        {
            InitializeComponent();
            this.comportamiento = num;
        }

        #region "EVENTOS"

        private void FrmMenuHome_Load_1(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        private void BtnCerrarSeccion_Click(object sender, EventArgs e)
        {
            CerrarSeccion();
        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            Opcion1();
        }

        private void BtnOpcion2_Click(object sender, EventArgs e)
        {
            Opcion2();
        }

        private void BtnOpcion3_Click(object sender, EventArgs e)
        {
            Opcion3();
        }

        #endregion

        #region "Metodos Privados"
        public void CerrarSeccion()
        {
            this.Close();
            Login.instancia.Show();
        }

        public void CargarFormulario()
        {
            if(comportamiento == 1)
            {
                btnOpcion1.Text = "Mantenimiento de Usuarios";
                BtnOpcion2.Text = "Mantenimiento de Doctores";
                BtnOpcion3.Text = "Mantenimiento de Pruebas de Laboratorio";
            }
            else
            {
                btnOpcion1.Text = "Mantenimiento de Pacientes";
                BtnOpcion2.Text = "Mantenimiento de Citas";
                BtnOpcion3.Text = "Mantenimiento de resultados de Pruebas de Laboratorio";
            }
        }

        public void Opcion1()
        {
            if(comportamiento == 1)
            {
                FrmMDeUsuarios frm = new FrmMDeUsuarios(comportamiento);
                frm.Show();
                this.Close();
            }
            else
            {
                FrmMDePacientes frm = new FrmMDePacientes(comportamiento);
                frm.Show();
                this.Close();
            }
        }

        public void Opcion2()
        {
            if (comportamiento == 1)
            {
                FrmMDeDoctores frm = new FrmMDeDoctores(comportamiento);
                frm.Show();
                this.Close();
            }
            else
            {
                FrmMDeCitas frm = new FrmMDeCitas();
                frm.Show();
                this.Close();
            }
        }

        public void Opcion3()
        {
            if (comportamiento == 1)
            {
                FrmMPruebasDeLaboratorio frm = new FrmMPruebasDeLaboratorio(comportamiento);
                frm.Show();
                this.Close();
            }
            else
            {
                FrmMDeResultadosDePruebasDeLaboratorio frm = new FrmMDeResultadosDePruebasDeLaboratorio(comportamiento);
                frm.Show();
                this.Close();
            }
        }
        #endregion

    }
}
