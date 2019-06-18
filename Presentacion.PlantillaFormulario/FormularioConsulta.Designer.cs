namespace Presentacion.PlantillaFormulario
{
    partial class FormularioConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioConsulta));
            this.MenuConsulta = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.separador = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.imgBuscar = new System.Windows.Forms.PictureBox();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.MenuConsulta.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Size = new System.Drawing.Size(665, 20);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(665, 35);
            // 
            // MenuConsulta
            // 
            this.MenuConsulta.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.MenuConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar,
            this.separador,
            this.btnActualizar,
            this.btnImprimir,
            this.btnSalir,
            this.toolStripSeparator1});
            this.MenuConsulta.Location = new System.Drawing.Point(0, 59);
            this.MenuConsulta.Name = "MenuConsulta";
            this.MenuConsulta.Size = new System.Drawing.Size(734, 47);
            this.MenuConsulta.TabIndex = 2;
            this.MenuConsulta.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 44);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 44);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 44);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // separador
            // 
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(6, 47);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(63, 44);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(57, 44);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.lblBuscar);
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Controls.Add(this.imgBuscar);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 106);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(734, 47);
            this.pnlBusqueda.TabIndex = 3;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(55, 18);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 13);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(470, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(116, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(348, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Enter += new System.EventHandler(this.control_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.control_Leave);
            // 
            // imgBuscar
            // 
            this.imgBuscar.BackColor = System.Drawing.Color.Transparent;
            this.imgBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBuscar.Location = new System.Drawing.Point(9, 6);
            this.imgBuscar.Name = "imgBuscar";
            this.imgBuscar.Size = new System.Drawing.Size(41, 36);
            this.imgBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBuscar.TabIndex = 0;
            this.imgBuscar.TabStop = false;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBusqueda.Location = new System.Drawing.Point(0, 153);
            this.dgvBusqueda.MultiSelect = false;
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusqueda.Size = new System.Drawing.Size(734, 336);
            this.dgvBusqueda.TabIndex = 4;
            this.dgvBusqueda.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_RowEnter);
            // 
            // FormularioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.MenuConsulta);
            this.MaximumSize = new System.Drawing.Size(750, 550);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "FormularioConsulta";
            this.Load += new System.EventHandler(this.FormularioBaseConsulta_Load);
            this.Controls.SetChildIndex(this.MenuConsulta, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.dgvBusqueda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.MenuConsulta.ResumeLayout(false);
            this.MenuConsulta.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator separador;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.PictureBox imgBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.DataGridView dgvBusqueda;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.ToolStripButton btnNuevo;
        public System.Windows.Forms.ToolStripButton btnModificar;
        public System.Windows.Forms.ToolStripButton btnEliminar;
        public System.Windows.Forms.ToolStripButton btnActualizar;
        public System.Windows.Forms.ToolStripButton btnImprimir;
        public System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStrip MenuConsulta;

    }
}