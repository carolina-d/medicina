namespace Presentacion.ConsultaPaciente
{
    partial class _00503_ABM_MedicamentoRecetado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.txtMedicRecetado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbConsulta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medicamento Recetado";
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.Location = new System.Drawing.Point(192, 174);
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.Size = new System.Drawing.Size(138, 20);
            this.txtIndicaciones.TabIndex = 6;
            // 
            // txtMedicRecetado
            // 
            this.txtMedicRecetado.Location = new System.Drawing.Point(192, 146);
            this.txtMedicRecetado.Name = "txtMedicRecetado";
            this.txtMedicRecetado.Size = new System.Drawing.Size(138, 20);
            this.txtMedicRecetado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Indicaciones";
            // 
            // cmbConsulta
            // 
            this.cmbConsulta.FormattingEnabled = true;
            this.cmbConsulta.Location = new System.Drawing.Point(192, 200);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Size = new System.Drawing.Size(138, 21);
            this.cmbConsulta.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Consulta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _00503_ABM_MedicamentoRecetado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedicRecetado);
            this.Controls.Add(this.txtIndicaciones);
            this.Controls.Add(this.label1);
            this.Name = "_00503_ABM_MedicamentoRecetado";
            this.Text = "_00503_ABM_MedicamentoRecetado";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtIndicaciones, 0);
            this.Controls.SetChildIndex(this.txtMedicRecetado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbConsulta, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.TextBox txtMedicRecetado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}