
namespace FinalProject
{
    partial class FrmAgregarCitaFormulario
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
            this.BtnAtras = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.lblContraRegis = new System.Windows.Forms.Label();
            this.TbxCausa = new System.Windows.Forms.TextBox();
            this.TbxPaciente = new System.Windows.Forms.TextBox();
            this.TbxDoctor = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCrearCita = new System.Windows.Forms.Button();
            this.LblTituloUser = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.BtnAtras, 0, 0);
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
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAtras.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnAtras.Location = new System.Drawing.Point(3, 3);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(124, 80);
            this.BtnAtras.TabIndex = 3;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLastName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblUserName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblContraRegis, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TbxCausa, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TbxPaciente, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TbxDoctor, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.DtpFecha, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(133, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 269);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Location = new System.Drawing.Point(213, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 70);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Fecha:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLastName.Location = new System.Drawing.Point(147, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(116, 68);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Causa de la cita:";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblUserName.Location = new System.Drawing.Point(196, 138);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(67, 67);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Paciente:";
            // 
            // lblContraRegis
            // 
            this.lblContraRegis.AutoSize = true;
            this.lblContraRegis.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblContraRegis.Location = new System.Drawing.Point(208, 205);
            this.lblContraRegis.Name = "lblContraRegis";
            this.lblContraRegis.Size = new System.Drawing.Size(55, 64);
            this.lblContraRegis.TabIndex = 2;
            this.lblContraRegis.Text = "Doctor";
            // 
            // TbxCausa
            // 
            this.TbxCausa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxCausa.Location = new System.Drawing.Point(269, 73);
            this.TbxCausa.Name = "TbxCausa";
            this.TbxCausa.Size = new System.Drawing.Size(260, 27);
            this.TbxCausa.TabIndex = 3;
            // 
            // TbxPaciente
            // 
            this.TbxPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxPaciente.Location = new System.Drawing.Point(269, 141);
            this.TbxPaciente.Name = "TbxPaciente";
            this.TbxPaciente.ReadOnly = true;
            this.TbxPaciente.Size = new System.Drawing.Size(260, 27);
            this.TbxPaciente.TabIndex = 3;
            // 
            // TbxDoctor
            // 
            this.TbxDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxDoctor.Location = new System.Drawing.Point(269, 208);
            this.TbxDoctor.Name = "TbxDoctor";
            this.TbxDoctor.ReadOnly = true;
            this.TbxDoctor.Size = new System.Drawing.Size(260, 27);
            this.TbxDoctor.TabIndex = 3;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(269, 3);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(250, 27);
            this.DtpFecha.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnCancelar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BtnCrearCita, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(133, 364);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(532, 83);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(3, 44);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(526, 36);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCrearCita
            // 
            this.BtnCrearCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCrearCita.Location = new System.Drawing.Point(3, 3);
            this.BtnCrearCita.Name = "BtnCrearCita";
            this.BtnCrearCita.Size = new System.Drawing.Size(526, 35);
            this.BtnCrearCita.TabIndex = 0;
            this.BtnCrearCita.Text = "Crear Cita";
            this.BtnCrearCita.UseVisualStyleBackColor = true;
            this.BtnCrearCita.Click += new System.EventHandler(this.BtnCrearCita_Click);
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
            this.LblTituloUser.Text = "Citas";
            this.LblTituloUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAgregarCitaFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAgregarCitaFormulario";
            this.Text = "FrmAgregarCitaFormulario";
            this.Load += new System.EventHandler(this.FrmAgregarCitaFormulario_Load);
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label lblContraRegis;
        private System.Windows.Forms.TextBox TbxCausa;
        private System.Windows.Forms.TextBox TbxPaciente;
        private System.Windows.Forms.TextBox TbxDoctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnCrearCita;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblTituloUser;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.DateTimePicker DtpFecha;
    }
}