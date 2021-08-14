
namespace FinalProject
{
    partial class FrmAddEditDoctores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.lblContraRegis = new System.Windows.Forms.Label();
            this.lblconfimPass = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.BtmAddFoto = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRegGuardar = new System.Windows.Forms.Button();
            this.BtnRegCancelar = new System.Windows.Forms.Button();
            this.LblTituloUser = new System.Windows.Forms.Label();
            this.PictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.46108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.53893F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblTituloUser, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.0113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.9887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLastName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblUserName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblContraRegis, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblconfimPass, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtApellido, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtCorreo, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtTelefono, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtCedula, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtmAddFoto, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(133, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 269);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(163, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar Foto:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Location = new System.Drawing.Point(196, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 47);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLastName.Location = new System.Drawing.Point(194, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 47);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Apellido:";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblUserName.Location = new System.Drawing.Point(206, 94);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(57, 52);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Correo:";
            this.LblUserName.Click += new System.EventHandler(this.LblUserName_Click);
            // 
            // lblContraRegis
            // 
            this.lblContraRegis.AutoSize = true;
            this.lblContraRegis.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblContraRegis.Location = new System.Drawing.Point(193, 146);
            this.lblContraRegis.Name = "lblContraRegis";
            this.lblContraRegis.Size = new System.Drawing.Size(70, 46);
            this.lblContraRegis.TabIndex = 2;
            this.lblContraRegis.Text = "Telefono:";
            // 
            // lblconfimPass
            // 
            this.lblconfimPass.AutoSize = true;
            this.lblconfimPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblconfimPass.Location = new System.Drawing.Point(205, 192);
            this.lblconfimPass.Name = "lblconfimPass";
            this.lblconfimPass.Size = new System.Drawing.Size(58, 40);
            this.lblconfimPass.TabIndex = 2;
            this.lblconfimPass.Text = "Cédula:";
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(269, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtApellido.Location = new System.Drawing.Point(269, 50);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(260, 27);
            this.TxtApellido.TabIndex = 3;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCorreo.Location = new System.Drawing.Point(269, 97);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(260, 27);
            this.TxtCorreo.TabIndex = 3;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtTelefono.Location = new System.Drawing.Point(269, 149);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(260, 27);
            this.TxtTelefono.TabIndex = 3;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCedula.Location = new System.Drawing.Point(269, 195);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(260, 27);
            this.TxtCedula.TabIndex = 3;
            // 
            // BtmAddFoto
            // 
            this.BtmAddFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtmAddFoto.Location = new System.Drawing.Point(269, 235);
            this.BtmAddFoto.Name = "BtmAddFoto";
            this.BtmAddFoto.Size = new System.Drawing.Size(260, 31);
            this.BtmAddFoto.TabIndex = 6;
            this.BtmAddFoto.Text = "Subir Foto";
            this.BtmAddFoto.UseVisualStyleBackColor = true;
            this.BtmAddFoto.Click += new System.EventHandler(this.BtmAddFoto_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnRegGuardar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnRegCancelar, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(133, 364);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(532, 83);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BtnRegGuardar
            // 
            this.BtnRegGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegGuardar.Location = new System.Drawing.Point(3, 3);
            this.BtnRegGuardar.Name = "BtnRegGuardar";
            this.BtnRegGuardar.Size = new System.Drawing.Size(526, 35);
            this.BtnRegGuardar.TabIndex = 0;
            this.BtnRegGuardar.Text = "Guardar";
            this.BtnRegGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnRegCancelar
            // 
            this.BtnRegCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegCancelar.Location = new System.Drawing.Point(3, 44);
            this.BtnRegCancelar.Name = "BtnRegCancelar";
            this.BtnRegCancelar.Size = new System.Drawing.Size(526, 36);
            this.BtnRegCancelar.TabIndex = 0;
            this.BtnRegCancelar.Text = "Cancelar";
            this.BtnRegCancelar.UseVisualStyleBackColor = true;
            // 
            // LblTituloUser
            // 
            this.LblTituloUser.AutoSize = true;
            this.LblTituloUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblTituloUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTituloUser.Font = new System.Drawing.Font("Segoe UI", 24.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblTituloUser.Location = new System.Drawing.Point(133, 0);
            this.LblTituloUser.Name = "LblTituloUser";
            this.LblTituloUser.Size = new System.Drawing.Size(532, 86);
            this.LblTituloUser.TabIndex = 2;
            this.LblTituloUser.Text = "Doctores";
            this.LblTituloUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAddEditDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAddEditDoctores";
            this.Text = "FrmAddEditDoctores";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label lblContraRegis;
        private System.Windows.Forms.Label lblconfimPass;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnRegGuardar;
        private System.Windows.Forms.Button BtnRegCancelar;
        private System.Windows.Forms.Label LblTituloUser;
        private System.Windows.Forms.Button BtmAddFoto;
        private System.Windows.Forms.OpenFileDialog PictureDialog;
    }
}