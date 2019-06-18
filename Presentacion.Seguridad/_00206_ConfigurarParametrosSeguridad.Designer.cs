namespace Presentacion.Seguridad
{
    partial class _00206_ConfigurarParametrosSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00206_ConfigurarParametrosSeguridad));
            this.chkMostrarRePassword = new System.Windows.Forms.CheckBox();
            this.chkMostrarPassword = new System.Windows.Forms.CheckBox();
            this.txtReNueva = new System.Windows.Forms.TextBox();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkRequerirPwd = new System.Windows.Forms.CheckBox();
            this.nudSimbolos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNumeros = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMinuscula = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudMayuscula = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMaximos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMinimos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimbolos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuscula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMayuscula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkMostrarRePassword
            // 
            this.chkMostrarRePassword.AutoSize = true;
            this.chkMostrarRePassword.Location = new System.Drawing.Point(370, 190);
            this.chkMostrarRePassword.Name = "chkMostrarRePassword";
            this.chkMostrarRePassword.Size = new System.Drawing.Size(61, 17);
            this.chkMostrarRePassword.TabIndex = 56;
            this.chkMostrarRePassword.Text = "Mostrar";
            this.chkMostrarRePassword.UseVisualStyleBackColor = true;
            this.chkMostrarRePassword.CheckedChanged += new System.EventHandler(this.chkMostrarRePassword_CheckedChanged);
            // 
            // chkMostrarPassword
            // 
            this.chkMostrarPassword.AutoSize = true;
            this.chkMostrarPassword.Location = new System.Drawing.Point(370, 146);
            this.chkMostrarPassword.Name = "chkMostrarPassword";
            this.chkMostrarPassword.Size = new System.Drawing.Size(61, 17);
            this.chkMostrarPassword.TabIndex = 55;
            this.chkMostrarPassword.Text = "Mostrar";
            this.chkMostrarPassword.UseVisualStyleBackColor = true;
            this.chkMostrarPassword.CheckedChanged += new System.EventHandler(this.chkMostrarPassword_CheckedChanged);
            // 
            // txtReNueva
            // 
            this.txtReNueva.Location = new System.Drawing.Point(228, 188);
            this.txtReNueva.MaxLength = 20;
            this.txtReNueva.Name = "txtReNueva";
            this.txtReNueva.PasswordChar = '*';
            this.txtReNueva.Size = new System.Drawing.Size(136, 20);
            this.txtReNueva.TabIndex = 54;
            this.txtReNueva.Text = "12345678";
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(228, 145);
            this.txtNueva.MaxLength = 20;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.Size = new System.Drawing.Size(136, 20);
            this.txtNueva.TabIndex = 53;
            this.txtNueva.Text = "12345678";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Repetir Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Contraseña por Defecto";
            // 
            // chkRequerirPwd
            // 
            this.chkRequerirPwd.AutoSize = true;
            this.chkRequerirPwd.Location = new System.Drawing.Point(238, 230);
            this.chkRequerirPwd.Name = "chkRequerirPwd";
            this.chkRequerirPwd.Size = new System.Drawing.Size(189, 30);
            this.chkRequerirPwd.TabIndex = 50;
            this.chkRequerirPwd.Text = "Requerir Cambios de Contraseñas \r\nal Iniciar por Primera Vez";
            this.chkRequerirPwd.UseVisualStyleBackColor = true;
            // 
            // nudSimbolos
            // 
            this.nudSimbolos.Location = new System.Drawing.Point(149, 252);
            this.nudSimbolos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSimbolos.Name = "nudSimbolos";
            this.nudSimbolos.Size = new System.Drawing.Size(40, 20);
            this.nudSimbolos.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Símbolos";
            // 
            // nudNumeros
            // 
            this.nudNumeros.Location = new System.Drawing.Point(149, 226);
            this.nudNumeros.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudNumeros.Name = "nudNumeros";
            this.nudNumeros.Size = new System.Drawing.Size(40, 20);
            this.nudNumeros.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Números";
            // 
            // nudMinuscula
            // 
            this.nudMinuscula.Location = new System.Drawing.Point(149, 200);
            this.nudMinuscula.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMinuscula.Name = "nudMinuscula";
            this.nudMinuscula.Size = new System.Drawing.Size(40, 20);
            this.nudMinuscula.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Minúsculas";
            // 
            // nudMayuscula
            // 
            this.nudMayuscula.Location = new System.Drawing.Point(149, 172);
            this.nudMayuscula.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMayuscula.Name = "nudMayuscula";
            this.nudMayuscula.Size = new System.Drawing.Size(40, 20);
            this.nudMayuscula.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mayúsculas";
            // 
            // nudMaximos
            // 
            this.nudMaximos.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMaximos.Location = new System.Drawing.Point(149, 146);
            this.nudMaximos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMaximos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaximos.Name = "nudMaximos";
            this.nudMaximos.Size = new System.Drawing.Size(40, 20);
            this.nudMaximos.TabIndex = 41;
            this.nudMaximos.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Caracteres Máximos";
            // 
            // nudMinimos
            // 
            this.nudMinimos.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMinimos.Location = new System.Drawing.Point(149, 120);
            this.nudMinimos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMinimos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinimos.Name = "nudMinimos";
            this.nudMinimos.Size = new System.Drawing.Size(40, 20);
            this.nudMinimos.TabIndex = 39;
            this.nudMinimos.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Caracteres Mínimos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGrabar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 59);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 47);
            this.toolStrip1.TabIndex = 57;
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
            // _00206_ConfigurarParametrosSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chkMostrarRePassword);
            this.Controls.Add(this.chkMostrarPassword);
            this.Controls.Add(this.txtReNueva);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkRequerirPwd);
            this.Controls.Add(this.nudSimbolos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudNumeros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudMinuscula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudMayuscula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudMaximos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMinimos);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.Name = "_00206_ConfigurarParametrosSeguridad";
            this.Load += new System.EventHandler(this._00206_ConfigurarParametrosSeguridad_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.nudMinimos, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.nudMaximos, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.nudMayuscula, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.nudMinuscula, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.nudNumeros, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.nudSimbolos, 0);
            this.Controls.SetChildIndex(this.chkRequerirPwd, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtNueva, 0);
            this.Controls.SetChildIndex(this.txtReNueva, 0);
            this.Controls.SetChildIndex(this.chkMostrarPassword, 0);
            this.Controls.SetChildIndex(this.chkMostrarRePassword, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimbolos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuscula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMayuscula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMostrarRePassword;
        private System.Windows.Forms.CheckBox chkMostrarPassword;
        private System.Windows.Forms.TextBox txtReNueva;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkRequerirPwd;
        private System.Windows.Forms.NumericUpDown nudSimbolos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudNumeros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMinuscula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudMayuscula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMaximos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinimos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}