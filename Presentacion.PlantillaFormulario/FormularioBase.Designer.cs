namespace Presentacion.PlantillaFormulario
{
    partial class FormularioBase
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioBase));
            this.panelSuperior = new System.Windows.Forms.SplitContainer();
            this.imgTitulo = new System.Windows.Forms.PictureBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.InformeEstado = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.panelSuperior)).BeginInit();
            this.panelSuperior.Panel1.SuspendLayout();
            this.panelSuperior.Panel2.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            this.InformeEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.White;
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            // 
            // panelSuperior.Panel1
            // 
            this.panelSuperior.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.Panel1.Controls.Add(this.imgTitulo);
            this.panelSuperior.Panel1.Enabled = false;
            this.panelSuperior.Panel1MinSize = 57;
            // 
            // panelSuperior.Panel2
            // 
            this.panelSuperior.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.Panel2.Controls.Add(this.lblLeyenda);
            this.panelSuperior.Panel2.Controls.Add(this.lblTitulo);
            this.panelSuperior.Panel2.Enabled = false;
            this.panelSuperior.Size = new System.Drawing.Size(484, 59);
            this.panelSuperior.SplitterDistance = 68;
            this.panelSuperior.SplitterWidth = 1;
            this.panelSuperior.TabIndex = 0;
            // 
            // imgTitulo
            // 
            this.imgTitulo.BackColor = System.Drawing.Color.Transparent;
            this.imgTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgTitulo.Location = new System.Drawing.Point(0, 0);
            this.imgTitulo.Name = "imgTitulo";
            this.imgTitulo.Size = new System.Drawing.Size(68, 59);
            this.imgTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTitulo.TabIndex = 0;
            this.imgTitulo.TabStop = false;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeyenda.Location = new System.Drawing.Point(0, 35);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(415, 20);
            this.lblLeyenda.TabIndex = 1;
            this.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(415, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InformeEstado
            // 
            this.InformeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioLogin});
            this.InformeEstado.Location = new System.Drawing.Point(0, 289);
            this.InformeEstado.Name = "InformeEstado";
            this.InformeEstado.Size = new System.Drawing.Size(484, 22);
            this.InformeEstado.TabIndex = 1;
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuarioLogin.Image")));
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(66, 17);
            this.lblUsuarioLogin.Text = "Usuario:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormularioBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.InformeEstado);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "FormularioBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelSuperior.Panel1.ResumeLayout(false);
            this.panelSuperior.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSuperior)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            this.InformeEstado.ResumeLayout(false);
            this.InformeEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer panelSuperior;
        public System.Windows.Forms.PictureBox imgTitulo;
        public System.Windows.Forms.Label lblLeyenda;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.StatusStrip InformeEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioLogin;
        public System.Windows.Forms.ErrorProvider errorProvider;

    }
}

