
namespace FinalProject
{
    partial class FrmAddEditUser
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
            this.txtRegNombre = new System.Windows.Forms.TextBox();
            this.TxtRegApellido = new System.Windows.Forms.TextBox();
            this.TxtRegUserName = new System.Windows.Forms.TextBox();
            this.TxtRegContra = new System.Windows.Forms.TextBox();
            this.TxtRegConfirmContra = new System.Windows.Forms.TextBox();
            this.CbxTipodeUser = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRegGuardar = new System.Windows.Forms.Button();
            this.BtnRegCancelar = new System.Windows.Forms.Button();
            this.LblTituloUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.30652F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.69347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
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
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tableLayoutPanel2.Controls.Add(this.txtRegNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtRegApellido, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtRegUserName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtRegContra, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtRegConfirmContra, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.CbxTipodeUser, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(150, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(506, 269);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(135, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de usuario:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Location = new System.Drawing.Point(183, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 47);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLastName.Location = new System.Drawing.Point(181, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 47);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Apellido:";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblUserName.Location = new System.Drawing.Point(108, 94);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(142, 57);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Nombre de Usuario:";
            // 
            // lblContraRegis
            // 
            this.lblContraRegis.AutoSize = true;
            this.lblContraRegis.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblContraRegis.Location = new System.Drawing.Point(164, 151);
            this.lblContraRegis.Name = "lblContraRegis";
            this.lblContraRegis.Size = new System.Drawing.Size(86, 41);
            this.lblContraRegis.TabIndex = 2;
            this.lblContraRegis.Text = "Contraseña:";
            // 
            // lblconfimPass
            // 
            this.lblconfimPass.AutoSize = true;
            this.lblconfimPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblconfimPass.Location = new System.Drawing.Point(96, 192);
            this.lblconfimPass.Name = "lblconfimPass";
            this.lblconfimPass.Size = new System.Drawing.Size(154, 40);
            this.lblconfimPass.TabIndex = 2;
            this.lblconfimPass.Text = "Confirmar contraseña:";
            // 
            // txtRegNombre
            // 
            this.txtRegNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegNombre.Location = new System.Drawing.Point(256, 3);
            this.txtRegNombre.Name = "txtRegNombre";
            this.txtRegNombre.Size = new System.Drawing.Size(247, 27);
            this.txtRegNombre.TabIndex = 3;
            this.txtRegNombre.TextChanged += new System.EventHandler(this.txtRegNombre_TextChanged);
            // 
            // TxtRegApellido
            // 
            this.TxtRegApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegApellido.Location = new System.Drawing.Point(256, 50);
            this.TxtRegApellido.Name = "TxtRegApellido";
            this.TxtRegApellido.Size = new System.Drawing.Size(247, 27);
            this.TxtRegApellido.TabIndex = 3;
            // 
            // TxtRegUserName
            // 
            this.TxtRegUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegUserName.Location = new System.Drawing.Point(256, 97);
            this.TxtRegUserName.Name = "TxtRegUserName";
            this.TxtRegUserName.Size = new System.Drawing.Size(247, 27);
            this.TxtRegUserName.TabIndex = 3;
            // 
            // TxtRegContra
            // 
            this.TxtRegContra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegContra.Location = new System.Drawing.Point(256, 154);
            this.TxtRegContra.Name = "TxtRegContra";
            this.TxtRegContra.Size = new System.Drawing.Size(247, 27);
            this.TxtRegContra.TabIndex = 3;
            // 
            // TxtRegConfirmContra
            // 
            this.TxtRegConfirmContra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRegConfirmContra.Location = new System.Drawing.Point(256, 195);
            this.TxtRegConfirmContra.Name = "TxtRegConfirmContra";
            this.TxtRegConfirmContra.Size = new System.Drawing.Size(247, 27);
            this.TxtRegConfirmContra.TabIndex = 3;
            // 
            // CbxTipodeUser
            // 
            this.CbxTipodeUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbxTipodeUser.FormattingEnabled = true;
            this.CbxTipodeUser.Location = new System.Drawing.Point(256, 235);
            this.CbxTipodeUser.Name = "CbxTipodeUser";
            this.CbxTipodeUser.Size = new System.Drawing.Size(247, 28);
            this.CbxTipodeUser.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnRegGuardar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnRegCancelar, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(150, 364);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(506, 83);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BtnRegGuardar
            // 
            this.BtnRegGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegGuardar.Location = new System.Drawing.Point(3, 3);
            this.BtnRegGuardar.Name = "BtnRegGuardar";
            this.BtnRegGuardar.Size = new System.Drawing.Size(500, 35);
            this.BtnRegGuardar.TabIndex = 0;
            this.BtnRegGuardar.Text = "Guardar";
            this.BtnRegGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnRegCancelar
            // 
            this.BtnRegCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegCancelar.Location = new System.Drawing.Point(3, 44);
            this.BtnRegCancelar.Name = "BtnRegCancelar";
            this.BtnRegCancelar.Size = new System.Drawing.Size(500, 36);
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
            this.LblTituloUser.Location = new System.Drawing.Point(150, 0);
            this.LblTituloUser.Name = "LblTituloUser";
            this.LblTituloUser.Size = new System.Drawing.Size(506, 86);
            this.LblTituloUser.TabIndex = 2;
            this.LblTituloUser.Text = "Registro de Usuario";
            this.LblTituloUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAddEditUser";
            this.Text = "FrmAddEditUser";
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
        private System.Windows.Forms.TextBox txtRegNombre;
        private System.Windows.Forms.TextBox TxtRegApellido;
        private System.Windows.Forms.TextBox TxtRegUserName;
        private System.Windows.Forms.TextBox TxtRegContra;
        private System.Windows.Forms.TextBox TxtRegConfirmContra;
        private System.Windows.Forms.ComboBox CbxTipodeUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnRegGuardar;
        private System.Windows.Forms.Button BtnRegCancelar;
        private System.Windows.Forms.Label LblTituloUser;
    }
}