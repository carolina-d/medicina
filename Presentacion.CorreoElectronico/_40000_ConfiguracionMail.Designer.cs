namespace Presentacion.CorreoElectronico
{
    partial class _40000_ConfiguracionMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_40000_ConfiguracionMail));
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.chkUsaSSL = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailSalida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServidorSMTP = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCancelacionTurno = new System.Windows.Forms.CheckBox();
            this.chkCumplePaciente = new System.Windows.Forms.CheckBox();
            this.chkCrearUnUsuario = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Size = new System.Drawing.Size(715, 20);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(715, 35);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(132, 121);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(358, 20);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(43, 124);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Nombre Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Location = new System.Drawing.Point(132, 173);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.PasswordChar = '*';
            this.txtConfirmarPassword.Size = new System.Drawing.Size(165, 20);
            this.txtConfirmarPassword.TabIndex = 9;
            // 
            // chkUsaSSL
            // 
            this.chkUsaSSL.AutoSize = true;
            this.chkUsaSSL.Location = new System.Drawing.Point(132, 199);
            this.chkUsaSSL.Name = "chkUsaSSL";
            this.chkUsaSSL.Size = new System.Drawing.Size(110, 17);
            this.chkUsaSSL.TabIndex = 11;
            this.chkUsaSSL.Text = "Por Ej. para Gmail";
            this.chkUsaSSL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usa SSL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmailSalida);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPuerto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtServidorSMTP);
            this.groupBox1.Location = new System.Drawing.Point(21, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 116);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Configuración Email de Salida ]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "E-Mail de Salida";
            // 
            // txtEmailSalida
            // 
            this.txtEmailSalida.Location = new System.Drawing.Point(111, 85);
            this.txtEmailSalida.Name = "txtEmailSalida";
            this.txtEmailSalida.Size = new System.Drawing.Size(358, 20);
            this.txtEmailSalida.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usualmente 587.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Puerto";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(111, 59);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(92, 20);
            this.txtPuerto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SMTP Servidor";
            // 
            // txtServidorSMTP
            // 
            this.txtServidorSMTP.Location = new System.Drawing.Point(111, 33);
            this.txtServidorSMTP.Name = "txtServidorSMTP";
            this.txtServidorSMTP.Size = new System.Drawing.Size(358, 20);
            this.txtServidorSMTP.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGrabar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 59);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 47);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(46, 44);
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 44);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCancelacionTurno);
            this.groupBox2.Controls.Add(this.chkCumplePaciente);
            this.groupBox2.Controls.Add(this.chkCrearUnUsuario);
            this.groupBox2.Location = new System.Drawing.Point(516, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 222);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Enviar Mail  ]";
            // 
            // chkCancelacionTurno
            // 
            this.chkCancelacionTurno.AutoSize = true;
            this.chkCancelacionTurno.Location = new System.Drawing.Point(15, 76);
            this.chkCancelacionTurno.Name = "chkCancelacionTurno";
            this.chkCancelacionTurno.Size = new System.Drawing.Size(136, 17);
            this.chkCancelacionTurno.TabIndex = 2;
            this.chkCancelacionTurno.Text = "Cancelación de Turnos";
            this.chkCancelacionTurno.UseVisualStyleBackColor = true;
            // 
            // chkCumplePaciente
            // 
            this.chkCumplePaciente.AutoSize = true;
            this.chkCumplePaciente.Location = new System.Drawing.Point(15, 53);
            this.chkCumplePaciente.Name = "chkCumplePaciente";
            this.chkCumplePaciente.Size = new System.Drawing.Size(129, 17);
            this.chkCumplePaciente.TabIndex = 1;
            this.chkCumplePaciente.Text = "Cumpleaños Paciente";
            this.chkCumplePaciente.UseVisualStyleBackColor = true;
            // 
            // chkCrearUnUsuario
            // 
            this.chkCrearUnUsuario.AutoSize = true;
            this.chkCrearUnUsuario.Location = new System.Drawing.Point(15, 30);
            this.chkCrearUnUsuario.Name = "chkCrearUnUsuario";
            this.chkCrearUnUsuario.Size = new System.Drawing.Size(117, 17);
            this.chkCrearUnUsuario.TabIndex = 0;
            this.chkCrearUnUsuario.Text = "Al Crear un Usuario";
            this.chkCrearUnUsuario.UseVisualStyleBackColor = true;
            // 
            // _40000_ConfiguracionMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkUsaSSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmarPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNombreUsuario);
            this.MaximumSize = new System.Drawing.Size(800, 425);
            this.MinimumSize = new System.Drawing.Size(800, 425);
            this.Name = "_40000_ConfiguracionMail";
            this.Load += new System.EventHandler(this._40000_ConfiguracionMail_Load);
            this.Controls.SetChildIndex(this.txtNombreUsuario, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtConfirmarPassword, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.chkUsaSSL, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.CheckBox chkUsaSSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailSalida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServidorSMTP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkCancelacionTurno;
        private System.Windows.Forms.CheckBox chkCumplePaciente;
        private System.Windows.Forms.CheckBox chkCrearUnUsuario;

    }
}