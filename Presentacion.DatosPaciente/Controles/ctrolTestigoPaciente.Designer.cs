namespace Presentacion.DatosPaciente.Controles
{
    partial class ctrolTestigoPaciente
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTestigoPaciente = new System.Windows.Forms.SplitContainer();
            this.imgFotoPaciente = new System.Windows.Forms.PictureBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTestigoPaciente)).BeginInit();
            this.pnlTestigoPaciente.Panel1.SuspendLayout();
            this.pnlTestigoPaciente.Panel2.SuspendLayout();
            this.pnlTestigoPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTestigoPaciente
            // 
            this.pnlTestigoPaciente.BackColor = System.Drawing.Color.White;
            this.pnlTestigoPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTestigoPaciente.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.pnlTestigoPaciente.Location = new System.Drawing.Point(0, 0);
            this.pnlTestigoPaciente.Name = "pnlTestigoPaciente";
            // 
            // pnlTestigoPaciente.Panel1
            // 
            this.pnlTestigoPaciente.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.pnlTestigoPaciente.Panel1.Controls.Add(this.imgFotoPaciente);
            this.pnlTestigoPaciente.Panel1.Enabled = false;
            this.pnlTestigoPaciente.Panel1MinSize = 57;
            // 
            // pnlTestigoPaciente.Panel2
            // 
            this.pnlTestigoPaciente.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.pnlTestigoPaciente.Panel2.Controls.Add(this.lblLeyenda);
            this.pnlTestigoPaciente.Panel2.Controls.Add(this.lblPaciente);
            this.pnlTestigoPaciente.Panel2.Enabled = false;
            this.pnlTestigoPaciente.Size = new System.Drawing.Size(473, 56);
            this.pnlTestigoPaciente.SplitterDistance = 68;
            this.pnlTestigoPaciente.SplitterWidth = 1;
            this.pnlTestigoPaciente.TabIndex = 1;
            // 
            // imgFotoPaciente
            // 
            this.imgFotoPaciente.BackColor = System.Drawing.Color.Transparent;
            this.imgFotoPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFotoPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFotoPaciente.Location = new System.Drawing.Point(0, 0);
            this.imgFotoPaciente.Name = "imgFotoPaciente";
            this.imgFotoPaciente.Size = new System.Drawing.Size(68, 56);
            this.imgFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFotoPaciente.TabIndex = 0;
            this.imgFotoPaciente.TabStop = false;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeyenda.Location = new System.Drawing.Point(0, 35);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(404, 20);
            this.lblLeyenda.TabIndex = 1;
            this.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaciente
            // 
            this.lblPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(0, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(404, 35);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctrolTestigoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTestigoPaciente);
            this.Name = "ctrolTestigoPaciente";
            this.Size = new System.Drawing.Size(473, 56);
            this.pnlTestigoPaciente.Panel1.ResumeLayout(false);
            this.pnlTestigoPaciente.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTestigoPaciente)).EndInit();
            this.pnlTestigoPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer pnlTestigoPaciente;
        public System.Windows.Forms.PictureBox imgFotoPaciente;
        public System.Windows.Forms.Label lblLeyenda;
        public System.Windows.Forms.Label lblPaciente;
    }
}
