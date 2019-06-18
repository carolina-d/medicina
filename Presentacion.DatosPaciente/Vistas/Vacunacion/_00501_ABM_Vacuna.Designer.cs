namespace Presentacion.DatosPaciente.Vistas.Vacunacion
{
    partial class _00501_ABM_Vacuna
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
            this.lblNombreFantasia = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtVacuna = new System.Windows.Forms.TextBox();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreFantasia
            // 
            this.lblNombreFantasia.AutoSize = true;
            this.lblNombreFantasia.Location = new System.Drawing.Point(56, 192);
            this.lblNombreFantasia.Name = "lblNombreFantasia";
            this.lblNombreFantasia.Size = new System.Drawing.Size(44, 13);
            this.lblNombreFantasia.TabIndex = 34;
            this.lblNombreFantasia.Text = "Vacuna";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(39, 156);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(61, 13);
            this.lblRazonSocial.TabIndex = 33;
            this.lblRazonSocial.Text = "Abreviatura";
            // 
            // txtVacuna
            // 
            this.txtVacuna.Location = new System.Drawing.Point(106, 189);
            this.txtVacuna.Name = "txtVacuna";
            this.txtVacuna.Size = new System.Drawing.Size(307, 20);
            this.txtVacuna.TabIndex = 32;
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.Location = new System.Drawing.Point(106, 153);
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(122, 20);
            this.txtAbreviatura.TabIndex = 31;
            // 
            // _00501_ABM_Vacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.lblNombreFantasia);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.txtVacuna);
            this.Controls.Add(this.txtAbreviatura);
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.Name = "_00501_ABM_Vacuna";
            this.Controls.SetChildIndex(this.txtAbreviatura, 0);
            this.Controls.SetChildIndex(this.txtVacuna, 0);
            this.Controls.SetChildIndex(this.lblRazonSocial, 0);
            this.Controls.SetChildIndex(this.lblNombreFantasia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreFantasia;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtVacuna;
        private System.Windows.Forms.TextBox txtAbreviatura;
    }
}