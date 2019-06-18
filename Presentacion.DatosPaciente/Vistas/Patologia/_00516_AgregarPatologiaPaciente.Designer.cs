namespace Presentacion.DatosPaciente.Vistas.Patologia
{
    partial class _00516_AgregarPatologiaPaciente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevaPatologia = new System.Windows.Forms.Button();
            this.cmbPatologia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Size = new System.Drawing.Size(457, 20);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(457, 35);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.btnNuevaPatologia);
            this.panel1.Controls.Add(this.cmbPatologia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 38);
            this.panel1.TabIndex = 5;
            // 
            // btnNuevaPatologia
            // 
            this.btnNuevaPatologia.Location = new System.Drawing.Point(460, 7);
            this.btnNuevaPatologia.Name = "btnNuevaPatologia";
            this.btnNuevaPatologia.Size = new System.Drawing.Size(37, 23);
            this.btnNuevaPatologia.TabIndex = 2;
            this.btnNuevaPatologia.Text = "...";
            this.btnNuevaPatologia.UseVisualStyleBackColor = true;
            this.btnNuevaPatologia.Click += new System.EventHandler(this.btnNuevaPatologia_Click);
            // 
            // cmbPatologia
            // 
            this.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatologia.FormattingEnabled = true;
            this.cmbPatologia.Location = new System.Drawing.Point(74, 8);
            this.cmbPatologia.Name = "cmbPatologia";
            this.cmbPatologia.Size = new System.Drawing.Size(380, 21);
            this.cmbPatologia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patología";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mes";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(83, 172);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(49, 20);
            this.nudAnio.TabIndex = 13;
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(223, 172);
            this.nudMes.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(49, 20);
            this.nudMes.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(83, 199);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(423, 77);
            this.txtObservacion.TabIndex = 18;
            this.txtObservacion.Text = "";
            // 
            // _00516_AgregarPatologiaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 320);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "_00516_AgregarPatologiaPaciente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.nudMes, 0);
            this.Controls.SetChildIndex(this.nudAnio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtObservacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevaPatologia;
        private System.Windows.Forms.ComboBox cmbPatologia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtObservacion;
    }
}