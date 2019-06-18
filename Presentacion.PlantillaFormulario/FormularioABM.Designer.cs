namespace Presentacion.PlantillaFormulario
{
    partial class FormularioABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioABM));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnGrabar = new System.Windows.Forms.ToolStripButton();
            this.BtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.BtnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGrabar,
            this.BtnLimpiar,
            this.BtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 59);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 47);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGrabar.Image")));
            this.BtnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(46, 44);
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(51, 44);
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(33, 44);
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FormularioABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormularioABM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioBaseABM_FormClosing);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton BtnGrabar;
        public System.Windows.Forms.ToolStripButton BtnLimpiar;
        public System.Windows.Forms.ToolStripButton BtnSalir;
    }
}