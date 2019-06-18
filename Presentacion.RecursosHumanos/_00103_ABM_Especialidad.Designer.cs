namespace Presentacion.RecursosHumanos
{
    partial class _00103_ABM_Especialidad
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreFantasia
            // 
            this.lblNombreFantasia.AutoSize = true;
            this.lblNombreFantasia.Location = new System.Drawing.Point(44, 196);
            this.lblNombreFantasia.Name = "lblNombreFantasia";
            this.lblNombreFantasia.Size = new System.Drawing.Size(67, 13);
            this.lblNombreFantasia.TabIndex = 26;
            this.lblNombreFantasia.Text = "Especialidad";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(71, 160);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(40, 13);
            this.lblRazonSocial.TabIndex = 25;
            this.lblRazonSocial.Text = "Código";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(117, 193);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(307, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(117, 157);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // _00103_ABM_Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.lblNombreFantasia);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.Name = "_00103_ABM_Especialidad";
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
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
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}