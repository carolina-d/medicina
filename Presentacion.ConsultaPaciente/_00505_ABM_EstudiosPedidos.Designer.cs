namespace Presentacion.ConsultaPaciente
{
    partial class _00505_ABM_EstudiosPedidos
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
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.Ubicacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.NombreEstudio = new System.Windows.Forms.Label();
            this.txtNombreEstudio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(184, 207);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(132, 20);
            this.txtObservaciones.TabIndex = 6;
            // 
            // Ubicacion
            // 
            this.Ubicacion.AutoSize = true;
            this.Ubicacion.Location = new System.Drawing.Point(103, 242);
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Size = new System.Drawing.Size(55, 13);
            this.Ubicacion.TabIndex = 7;
            this.Ubicacion.Text = "Ubicacion";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(184, 242);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(132, 20);
            this.txtUbicacion.TabIndex = 8;
            // 
            // NombreEstudio
            // 
            this.NombreEstudio.AutoSize = true;
            this.NombreEstudio.Location = new System.Drawing.Point(99, 177);
            this.NombreEstudio.Name = "NombreEstudio";
            this.NombreEstudio.Size = new System.Drawing.Size(79, 13);
            this.NombreEstudio.TabIndex = 9;
            this.NombreEstudio.Text = "NombreEstudio";
            // 
            // txtNombreEstudio
            // 
            this.txtNombreEstudio.Location = new System.Drawing.Point(185, 177);
            this.txtNombreEstudio.Name = "txtNombreEstudio";
            this.txtNombreEstudio.Size = new System.Drawing.Size(131, 20);
            this.txtNombreEstudio.TabIndex = 10;
            // 
            // _00505_ABM_EstudiosPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.txtNombreEstudio);
            this.Controls.Add(this.NombreEstudio);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.Ubicacion);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label1);
            this.Name = "_00505_ABM_EstudiosPedidos";
            this.Text = "_00505_ABM_EstudiosPedidos";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtObservaciones, 0);
            this.Controls.SetChildIndex(this.Ubicacion, 0);
            this.Controls.SetChildIndex(this.txtUbicacion, 0);
            this.Controls.SetChildIndex(this.NombreEstudio, 0);
            this.Controls.SetChildIndex(this.txtNombreEstudio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label Ubicacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label NombreEstudio;
        private System.Windows.Forms.TextBox txtNombreEstudio;
    }
}