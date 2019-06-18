namespace Presentacion.Seguridad
{
    partial class _00205_AsignarFormularioPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00205_AsignarFormularioPerfil));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnVincular = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAsignados = new System.Windows.Forms.DataGridView();
            this.chkAsignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAsignadoNada = new System.Windows.Forms.Button();
            this.btnAsignadoTodo = new System.Windows.Forms.Button();
            this.btnBuscarAsignados = new System.Windows.Forms.Button();
            this.txtBuscarAsignados = new System.Windows.Forms.TextBox();
            this.imgAsignado = new System.Windows.Forms.PictureBox();
            this.lblListaEmpleadoAsignados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNoAsignados = new System.Windows.Forms.DataGridView();
            this.chkNoAsignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlBusquedaEmpleadosNoAsignados = new System.Windows.Forms.Panel();
            this.btnNoAsignadoNada = new System.Windows.Forms.Button();
            this.btnNoAsignadoTodo = new System.Windows.Forms.Button();
            this.btnBuscarNoAsignados = new System.Windows.Forms.Button();
            this.txtBuscarNoAsignados = new System.Windows.Forms.TextBox();
            this.imgNoAsignado = new System.Windows.Forms.PictureBox();
            this.lblListaEmpleadoNoAsignados = new System.Windows.Forms.Label();
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.btnNuevoPerfil = new System.Windows.Forms.Button();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.btnDesvincular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAsignado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAsignados)).BeginInit();
            this.pnlBusquedaEmpleadosNoAsignados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoAsignado)).BeginInit();
            this.pnlEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Size = new System.Drawing.Size(695, 20);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(695, 35);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 59);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 32);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 29);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(348, 233);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(68, 55);
            this.btnVincular.TabIndex = 15;
            this.btnVincular.Text = "Agregar";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvAsignados);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblListaEmpleadoAsignados);
            this.panel2.Location = new System.Drawing.Point(422, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 339);
            this.panel2.TabIndex = 14;
            // 
            // dgvAsignados
            // 
            this.dgvAsignados.AllowUserToAddRows = false;
            this.dgvAsignados.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkAsignado});
            this.dgvAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsignados.Location = new System.Drawing.Point(0, 25);
            this.dgvAsignados.MultiSelect = false;
            this.dgvAsignados.Name = "dgvAsignados";
            this.dgvAsignados.RowHeadersVisible = false;
            this.dgvAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignados.Size = new System.Drawing.Size(334, 252);
            this.dgvAsignados.TabIndex = 2;
            this.dgvAsignados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // chkAsignado
            // 
            this.chkAsignado.Frozen = true;
            this.chkAsignado.HeaderText = "Item";
            this.chkAsignado.Name = "chkAsignado";
            this.chkAsignado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkAsignado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkAsignado.Width = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAsignadoNada);
            this.panel3.Controls.Add(this.btnAsignadoTodo);
            this.panel3.Controls.Add(this.btnBuscarAsignados);
            this.panel3.Controls.Add(this.txtBuscarAsignados);
            this.panel3.Controls.Add(this.imgAsignado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 62);
            this.panel3.TabIndex = 1;
            // 
            // btnAsignadoNada
            // 
            this.btnAsignadoNada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignadoNada.Location = new System.Drawing.Point(178, 4);
            this.btnAsignadoNada.Name = "btnAsignadoNada";
            this.btnAsignadoNada.Size = new System.Drawing.Size(151, 24);
            this.btnAsignadoNada.TabIndex = 6;
            this.btnAsignadoNada.Text = "Desmarcar Todo";
            this.btnAsignadoNada.UseVisualStyleBackColor = true;
            this.btnAsignadoNada.Click += new System.EventHandler(this.btnAsignadoNada_Click);
            // 
            // btnAsignadoTodo
            // 
            this.btnAsignadoTodo.Location = new System.Drawing.Point(7, 4);
            this.btnAsignadoTodo.Name = "btnAsignadoTodo";
            this.btnAsignadoTodo.Size = new System.Drawing.Size(152, 24);
            this.btnAsignadoTodo.TabIndex = 5;
            this.btnAsignadoTodo.Text = "Marcar Todo";
            this.btnAsignadoTodo.UseVisualStyleBackColor = true;
            this.btnAsignadoTodo.Click += new System.EventHandler(this.btnAsignadoTodo_Click);
            // 
            // btnBuscarAsignados
            // 
            this.btnBuscarAsignados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarAsignados.Location = new System.Drawing.Point(267, 33);
            this.btnBuscarAsignados.Name = "btnBuscarAsignados";
            this.btnBuscarAsignados.Size = new System.Drawing.Size(62, 23);
            this.btnBuscarAsignados.TabIndex = 2;
            this.btnBuscarAsignados.Text = "Buscar";
            this.btnBuscarAsignados.UseVisualStyleBackColor = true;
            this.btnBuscarAsignados.Click += new System.EventHandler(this.btnBuscarAsignados_Click);
            // 
            // txtBuscarAsignados
            // 
            this.txtBuscarAsignados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarAsignados.Location = new System.Drawing.Point(39, 35);
            this.txtBuscarAsignados.Name = "txtBuscarAsignados";
            this.txtBuscarAsignados.Size = new System.Drawing.Size(222, 20);
            this.txtBuscarAsignados.TabIndex = 1;
            // 
            // imgAsignado
            // 
            this.imgAsignado.BackColor = System.Drawing.Color.White;
            this.imgAsignado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgAsignado.Location = new System.Drawing.Point(7, 33);
            this.imgAsignado.Name = "imgAsignado";
            this.imgAsignado.Size = new System.Drawing.Size(26, 24);
            this.imgAsignado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAsignado.TabIndex = 0;
            this.imgAsignado.TabStop = false;
            // 
            // lblListaEmpleadoAsignados
            // 
            this.lblListaEmpleadoAsignados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblListaEmpleadoAsignados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaEmpleadoAsignados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListaEmpleadoAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEmpleadoAsignados.Location = new System.Drawing.Point(0, 0);
            this.lblListaEmpleadoAsignados.Name = "lblListaEmpleadoAsignados";
            this.lblListaEmpleadoAsignados.Size = new System.Drawing.Size(334, 25);
            this.lblListaEmpleadoAsignados.TabIndex = 0;
            this.lblListaEmpleadoAsignados.Text = "Lista de Formulacios no asignados";
            this.lblListaEmpleadoAsignados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvNoAsignados);
            this.panel1.Controls.Add(this.pnlBusquedaEmpleadosNoAsignados);
            this.panel1.Controls.Add(this.lblListaEmpleadoNoAsignados);
            this.panel1.Location = new System.Drawing.Point(8, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 339);
            this.panel1.TabIndex = 13;
            // 
            // dgvNoAsignados
            // 
            this.dgvNoAsignados.AllowUserToAddRows = false;
            this.dgvNoAsignados.BackgroundColor = System.Drawing.Color.White;
            this.dgvNoAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkNoAsignado});
            this.dgvNoAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoAsignados.Location = new System.Drawing.Point(0, 25);
            this.dgvNoAsignados.MultiSelect = false;
            this.dgvNoAsignados.Name = "dgvNoAsignados";
            this.dgvNoAsignados.RowHeadersVisible = false;
            this.dgvNoAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoAsignados.Size = new System.Drawing.Size(334, 252);
            this.dgvNoAsignados.TabIndex = 2;
            this.dgvNoAsignados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // chkNoAsignado
            // 
            this.chkNoAsignado.Frozen = true;
            this.chkNoAsignado.HeaderText = "Item";
            this.chkNoAsignado.Name = "chkNoAsignado";
            this.chkNoAsignado.Width = 40;
            // 
            // pnlBusquedaEmpleadosNoAsignados
            // 
            this.pnlBusquedaEmpleadosNoAsignados.BackColor = System.Drawing.Color.White;
            this.pnlBusquedaEmpleadosNoAsignados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusquedaEmpleadosNoAsignados.Controls.Add(this.btnNoAsignadoNada);
            this.pnlBusquedaEmpleadosNoAsignados.Controls.Add(this.btnNoAsignadoTodo);
            this.pnlBusquedaEmpleadosNoAsignados.Controls.Add(this.btnBuscarNoAsignados);
            this.pnlBusquedaEmpleadosNoAsignados.Controls.Add(this.txtBuscarNoAsignados);
            this.pnlBusquedaEmpleadosNoAsignados.Controls.Add(this.imgNoAsignado);
            this.pnlBusquedaEmpleadosNoAsignados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBusquedaEmpleadosNoAsignados.Location = new System.Drawing.Point(0, 277);
            this.pnlBusquedaEmpleadosNoAsignados.Name = "pnlBusquedaEmpleadosNoAsignados";
            this.pnlBusquedaEmpleadosNoAsignados.Size = new System.Drawing.Size(334, 62);
            this.pnlBusquedaEmpleadosNoAsignados.TabIndex = 1;
            // 
            // btnNoAsignadoNada
            // 
            this.btnNoAsignadoNada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoAsignadoNada.Location = new System.Drawing.Point(175, 4);
            this.btnNoAsignadoNada.Name = "btnNoAsignadoNada";
            this.btnNoAsignadoNada.Size = new System.Drawing.Size(151, 24);
            this.btnNoAsignadoNada.TabIndex = 4;
            this.btnNoAsignadoNada.Text = "Desmarcar Todo";
            this.btnNoAsignadoNada.UseVisualStyleBackColor = true;
            this.btnNoAsignadoNada.Click += new System.EventHandler(this.btnNoAsignadoNada_Click);
            // 
            // btnNoAsignadoTodo
            // 
            this.btnNoAsignadoTodo.Location = new System.Drawing.Point(4, 4);
            this.btnNoAsignadoTodo.Name = "btnNoAsignadoTodo";
            this.btnNoAsignadoTodo.Size = new System.Drawing.Size(152, 24);
            this.btnNoAsignadoTodo.TabIndex = 3;
            this.btnNoAsignadoTodo.Text = "Marcar Todo";
            this.btnNoAsignadoTodo.UseVisualStyleBackColor = true;
            this.btnNoAsignadoTodo.Click += new System.EventHandler(this.btnNoAsignadoTodo_Click);
            // 
            // btnBuscarNoAsignados
            // 
            this.btnBuscarNoAsignados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarNoAsignados.Location = new System.Drawing.Point(264, 32);
            this.btnBuscarNoAsignados.Name = "btnBuscarNoAsignados";
            this.btnBuscarNoAsignados.Size = new System.Drawing.Size(62, 24);
            this.btnBuscarNoAsignados.TabIndex = 2;
            this.btnBuscarNoAsignados.Text = "Buscar";
            this.btnBuscarNoAsignados.UseVisualStyleBackColor = true;
            this.btnBuscarNoAsignados.Click += new System.EventHandler(this.btnBuscarNoAsignados_Click);
            // 
            // txtBuscarNoAsignados
            // 
            this.txtBuscarNoAsignados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarNoAsignados.Location = new System.Drawing.Point(36, 34);
            this.txtBuscarNoAsignados.Name = "txtBuscarNoAsignados";
            this.txtBuscarNoAsignados.Size = new System.Drawing.Size(222, 20);
            this.txtBuscarNoAsignados.TabIndex = 1;
            // 
            // imgNoAsignado
            // 
            this.imgNoAsignado.BackColor = System.Drawing.Color.White;
            this.imgNoAsignado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgNoAsignado.Location = new System.Drawing.Point(4, 32);
            this.imgNoAsignado.Name = "imgNoAsignado";
            this.imgNoAsignado.Size = new System.Drawing.Size(26, 24);
            this.imgNoAsignado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNoAsignado.TabIndex = 0;
            this.imgNoAsignado.TabStop = false;
            // 
            // lblListaEmpleadoNoAsignados
            // 
            this.lblListaEmpleadoNoAsignados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblListaEmpleadoNoAsignados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaEmpleadoNoAsignados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListaEmpleadoNoAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEmpleadoNoAsignados.Location = new System.Drawing.Point(0, 0);
            this.lblListaEmpleadoNoAsignados.Name = "lblListaEmpleadoNoAsignados";
            this.lblListaEmpleadoNoAsignados.Size = new System.Drawing.Size(334, 25);
            this.lblListaEmpleadoNoAsignados.TabIndex = 0;
            this.lblListaEmpleadoNoAsignados.Text = "Lista de Formularios no asignados";
            this.lblListaEmpleadoNoAsignados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.Controls.Add(this.btnNuevoPerfil);
            this.pnlEmpresa.Controls.Add(this.lblEmpresa);
            this.pnlEmpresa.Controls.Add(this.cmbPerfil);
            this.pnlEmpresa.Location = new System.Drawing.Point(8, 95);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(748, 43);
            this.pnlEmpresa.TabIndex = 12;
            // 
            // btnNuevoPerfil
            // 
            this.btnNuevoPerfil.Location = new System.Drawing.Point(698, 9);
            this.btnNuevoPerfil.Name = "btnNuevoPerfil";
            this.btnNuevoPerfil.Size = new System.Drawing.Size(37, 23);
            this.btnNuevoPerfil.TabIndex = 2;
            this.btnNuevoPerfil.Text = "...";
            this.btnNuevoPerfil.UseVisualStyleBackColor = true;
            this.btnNuevoPerfil.Click += new System.EventHandler(this.btnNuevoPerfil_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(28, 14);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(30, 13);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Perfil";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(64, 11);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(626, 21);
            this.cmbPerfil.TabIndex = 0;
            this.cmbPerfil.SelectionChangeCommitted += new System.EventHandler(this.cmbPerfil_SelectionChangeCommitted);
            // 
            // btnDesvincular
            // 
            this.btnDesvincular.Location = new System.Drawing.Point(348, 304);
            this.btnDesvincular.Name = "btnDesvincular";
            this.btnDesvincular.Size = new System.Drawing.Size(68, 55);
            this.btnDesvincular.TabIndex = 16;
            this.btnDesvincular.Text = "Quitar";
            this.btnDesvincular.UseVisualStyleBackColor = true;
            this.btnDesvincular.Click += new System.EventHandler(this.btnDesvincular_Click);
            // 
            // _00205_AsignarFormularioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 511);
            this.Controls.Add(this.btnDesvincular);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEmpresa);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(780, 550);
            this.MinimumSize = new System.Drawing.Size(780, 550);
            this.Name = "_00205_AsignarFormularioPerfil";
            this.Load += new System.EventHandler(this._00205_AsignarFormularioPerfil_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.pnlEmpresa, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnVincular, 0);
            this.Controls.SetChildIndex(this.btnDesvincular, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAsignado)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAsignados)).EndInit();
            this.pnlBusquedaEmpleadosNoAsignados.ResumeLayout(false);
            this.pnlBusquedaEmpleadosNoAsignados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoAsignado)).EndInit();
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAsignados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkAsignado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAsignadoNada;
        private System.Windows.Forms.Button btnAsignadoTodo;
        private System.Windows.Forms.Button btnBuscarAsignados;
        private System.Windows.Forms.TextBox txtBuscarAsignados;
        private System.Windows.Forms.PictureBox imgAsignado;
        private System.Windows.Forms.Label lblListaEmpleadoAsignados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNoAsignados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkNoAsignado;
        private System.Windows.Forms.Panel pnlBusquedaEmpleadosNoAsignados;
        private System.Windows.Forms.Button btnNoAsignadoNada;
        private System.Windows.Forms.Button btnNoAsignadoTodo;
        private System.Windows.Forms.Button btnBuscarNoAsignados;
        private System.Windows.Forms.TextBox txtBuscarNoAsignados;
        private System.Windows.Forms.PictureBox imgNoAsignado;
        private System.Windows.Forms.Label lblListaEmpleadoNoAsignados;
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Button btnNuevoPerfil;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Button btnDesvincular;
    }
}