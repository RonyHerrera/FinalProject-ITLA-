using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FrmAddEditDoctores : Form
    {
        public FrmAddEditDoctores()
        {
            InitializeComponent();
        }

        private void LblUserName_Click(object sender, EventArgs e)
        {

        }

        private void BtmAddFoto_Click(object sender, EventArgs e)
        {

        }

        private void AddPhoto()
        {
            DialogResult result = PictureDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = PictureDialog.FileName;
            }
        }
    }
}
