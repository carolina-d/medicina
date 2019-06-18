namespace Presentacion.DatosPaciente.Vistas.Paciente
{
    partial class _00502_PlanVacunacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00502_PlanVacunacion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGenerarPlan = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.imgBuscar = new System.Windows.Forms.PictureBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerarPlan,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 59);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 47);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGenerarPlan
            // 
            this.btnGenerarPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarPlan.Image")));
            this.btnGenerarPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerarPlan.Name = "btnGenerarPlan";
            this.btnGenerarPlan.Size = new System.Drawing.Size(159, 44);
            this.btnGenerarPlan.Text = "Generar Plan de Vacunacion";
            this.btnGenerarPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerarPlan.Click += new System.EventHandler(this.btnGenerarPlan_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Controls.Add(this.imgBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 41);
            this.panel1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(487, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(94, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(387, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(48, 13);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar";
            // 
            // imgBuscar
            // 
            this.imgBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBuscar.Location = new System.Drawing.Point(6, 5);
            this.imgBuscar.Name = "imgBuscar";
            this.imgBuscar.Size = new System.Drawing.Size(31, 30);
            this.imgBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBuscar.TabIndex = 0;
            this.imgBuscar.TabStop = false;
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnAgregar});
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.Location = new System.Drawing.Point(0, 147);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowHeadersVisible = false;
            this.dgvPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlan.Size = new System.Drawing.Size(734, 342);
            this.dgvPlan.TabIndex = 5;
            this.dgvPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Frozen = true;
            this.btnAgregar.HeaderText = "";
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ReadOnly = true;
            this.btnAgregar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseColumnTextForButtonValue = true;
            // 
            // _00502_PlanVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(750, 550);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "_00502_PlanVacunacion";
            this.Load += new System.EventHandler(this._00502_PlanVacunacion_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgvPlan, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGenerarPlan;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox imgBuscar;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridViewButtonColumn btnAgregar;
    }
}