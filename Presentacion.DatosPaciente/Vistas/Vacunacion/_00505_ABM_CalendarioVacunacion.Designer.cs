namespace Presentacion.DatosPaciente.Vistas.Vacunacion
{
    partial class _00505_ABM_CalendarioVacunacion
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
            this.pnlVacuna = new System.Windows.Forms.Panel();
            this.btnNuevaVacuna = new System.Windows.Forms.Button();
            this.cmbVacuna = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEsObligatoria = new System.Windows.Forms.CheckBox();
            this.cmbDosis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.btnNuevaDosis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlVacuna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVacuna
            // 
            this.pnlVacuna.BackColor = System.Drawing.Color.Beige;
            this.pnlVacuna.Controls.Add(this.btnNuevaVacuna);
            this.pnlVacuna.Controls.Add(this.cmbVacuna);
            this.pnlVacuna.Controls.Add(this.label1);
            this.pnlVacuna.Location = new System.Drawing.Point(12, 118);
            this.pnlVacuna.Name = "pnlVacuna";
            this.pnlVacuna.Size = new System.Drawing.Size(460, 42);
            this.pnlVacuna.TabIndex = 5;
            // 
            // btnNuevaVacuna
            // 
            this.btnNuevaVacuna.Location = new System.Drawing.Point(410, 10);
            this.btnNuevaVacuna.Name = "btnNuevaVacuna";
            this.btnNuevaVacuna.Size = new System.Drawing.Size(41, 23);
            this.btnNuevaVacuna.TabIndex = 2;
            this.btnNuevaVacuna.Text = "...";
            this.btnNuevaVacuna.UseVisualStyleBackColor = true;
            this.btnNuevaVacuna.Click += new System.EventHandler(this.btnNuevaVacuna_Click);
            // 
            // cmbVacuna
            // 
            this.cmbVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacuna.FormattingEnabled = true;
            this.cmbVacuna.Location = new System.Drawing.Point(62, 11);
            this.cmbVacuna.Name = "cmbVacuna";
            this.cmbVacuna.Size = new System.Drawing.Size(342, 21);
            this.cmbVacuna.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vacuna";
            // 
            // chkEsObligatoria
            // 
            this.chkEsObligatoria.AutoSize = true;
            this.chkEsObligatoria.Location = new System.Drawing.Point(94, 254);
            this.chkEsObligatoria.Name = "chkEsObligatoria";
            this.chkEsObligatoria.Size = new System.Drawing.Size(91, 17);
            this.chkEsObligatoria.TabIndex = 17;
            this.chkEsObligatoria.Text = "Es Obligatoria";
            this.chkEsObligatoria.UseVisualStyleBackColor = true;
            // 
            // cmbDosis
            // 
            this.cmbDosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDosis.FormattingEnabled = true;
            this.cmbDosis.Location = new System.Drawing.Point(94, 218);
            this.cmbDosis.Name = "cmbDosis";
            this.cmbDosis.Size = new System.Drawing.Size(187, 21);
            this.cmbDosis.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dosis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Día";
            // 
            // nudDia
            // 
            this.nudDia.Location = new System.Drawing.Point(371, 181);
            this.nudDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(49, 20);
            this.nudDia.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mes";
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(232, 181);
            this.nudMes.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(49, 20);
            this.nudMes.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Año";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(94, 181);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(49, 20);
            this.nudAnio.TabIndex = 9;
            // 
            // btnNuevaDosis
            // 
            this.btnNuevaDosis.Location = new System.Drawing.Point(287, 217);
            this.btnNuevaDosis.Name = "btnNuevaDosis";
            this.btnNuevaDosis.Size = new System.Drawing.Size(41, 23);
            this.btnNuevaDosis.TabIndex = 18;
            this.btnNuevaDosis.Text = "...";
            this.btnNuevaDosis.UseVisualStyleBackColor = true;
            this.btnNuevaDosis.Click += new System.EventHandler(this.btnNuevaDosis_Click);
            // 
            // _00505_ABM_CalendarioVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnNuevaDosis);
            this.Controls.Add(this.chkEsObligatoria);
            this.Controls.Add(this.pnlVacuna);
            this.Controls.Add(this.cmbDosis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.Name = "_00505_ABM_CalendarioVacunacion";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.nudMes, 0);
            this.Controls.SetChildIndex(this.nudAnio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.nudDia, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbDosis, 0);
            this.Controls.SetChildIndex(this.pnlVacuna, 0);
            this.Controls.SetChildIndex(this.chkEsObligatoria, 0);
            this.Controls.SetChildIndex(this.btnNuevaDosis, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlVacuna.ResumeLayout(false);
            this.pnlVacuna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVacuna;
        private System.Windows.Forms.Button btnNuevaVacuna;
        private System.Windows.Forms.ComboBox cmbVacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEsObligatoria;
        private System.Windows.Forms.ComboBox cmbDosis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button btnNuevaDosis;
    }
}