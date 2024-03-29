﻿namespace Presentacion.RecursosHumanos
{
    partial class _00109_AsignarEmpleadoEspecialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00109_AsignarEmpleadoEspecialidad));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnDesvincular = new System.Windows.Forms.Button();
            this.btnVincular = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAsignados = new System.Windows.Forms.DataGridView();
            this.chkAsignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAsignadoNada = new System.Windows.Forms.Button();
            this.btnAsignadoTodo = new System.Windows.Forms.Button();
            this.btnBuscarAsignados = new System.Windows.Forms.Button();
            this.txtBuscarAsignados = new System.Windows.Forms.TextBox();
            this.imgAsignado = new System.Windows.Forms.PictureBox();
            this.lblListaEmpleadoAsignados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNoAsignados = new System.Windows.Forms.DataGridView();
            this.chkNoAsignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNoAsignadoNada = new System.Windows.Forms.Button();
            this.btnNoAsignadoTodo = new System.Windows.Forms.Button();
            this.btnBuscarNoAsignados = new System.Windows.Forms.Button();
            this.txtBuscarNoAsignados = new System.Windows.Forms.TextBox();
            this.imgNoAsignado = new System.Windows.Forms.PictureBox();
            this.lblListaEmpleadoNoAsignados = new System.Windows.Forms.Label();
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.btnNuevaEmpresa = new System.Windows.Forms.Button();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAsignado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAsignados)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoAsignado)).BeginInit();
            this.pnlEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Size = new System.Drawing.Size(703, 20);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(703, 35);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 59);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(772, 32);
            this.toolStrip1.TabIndex = 18;
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
            // 
            // btnDesvincular
            // 
            this.btnDesvincular.Location = new System.Drawing.Point(347, 304);
            this.btnDesvincular.Name = "btnDesvincular";
            this.btnDesvincular.Size = new System.Drawing.Size(68, 55);
            this.btnDesvincular.TabIndex = 17;
            this.btnDesvincular.Text = "Quitar";
            this.btnDesvincular.UseVisualStyleBackColor = true;
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(348, 234);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(68, 55);
            this.btnVincular.TabIndex = 16;
            this.btnVincular.Text = "Agregar";
            this.btnVincular.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvAsignados);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblListaEmpleadoAsignados);
            this.panel3.Location = new System.Drawing.Point(418, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 339);
            this.panel3.TabIndex = 15;
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
            // 
            // chkAsignado
            // 
            this.chkAsignado.Frozen = true;
            this.chkAsignado.HeaderText = "Item";
            this.chkAsignado.Name = "chkAsignado";
            this.chkAsignado.Width = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAsignadoNada);
            this.panel4.Controls.Add(this.btnAsignadoTodo);
            this.panel4.Controls.Add(this.btnBuscarAsignados);
            this.panel4.Controls.Add(this.txtBuscarAsignados);
            this.panel4.Controls.Add(this.imgAsignado);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 62);
            this.panel4.TabIndex = 1;
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
            // 
            // btnAsignadoTodo
            // 
            this.btnAsignadoTodo.Location = new System.Drawing.Point(7, 4);
            this.btnAsignadoTodo.Name = "btnAsignadoTodo";
            this.btnAsignadoTodo.Size = new System.Drawing.Size(152, 24);
            this.btnAsignadoTodo.TabIndex = 5;
            this.btnAsignadoTodo.Text = "Marcar Todo";
            this.btnAsignadoTodo.UseVisualStyleBackColor = true;
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
            this.lblListaEmpleadoAsignados.Text = "Lista de Empleados asignados";
            this.lblListaEmpleadoAsignados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvNoAsignados);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblListaEmpleadoNoAsignados);
            this.panel1.Location = new System.Drawing.Point(9, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 339);
            this.panel1.TabIndex = 14;
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
            this.dgvNoAsignados.Name = "dgvNoAsignados";
            this.dgvNoAsignados.RowHeadersVisible = false;
            this.dgvNoAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoAsignados.Size = new System.Drawing.Size(334, 252);
            this.dgvNoAsignados.TabIndex = 2;
            // 
            // chkNoAsignado
            // 
            this.chkNoAsignado.Frozen = true;
            this.chkNoAsignado.HeaderText = "Item";
            this.chkNoAsignado.Name = "chkNoAsignado";
            this.chkNoAsignado.Width = 40;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnNoAsignadoNada);
            this.panel2.Controls.Add(this.btnNoAsignadoTodo);
            this.panel2.Controls.Add(this.btnBuscarNoAsignados);
            this.panel2.Controls.Add(this.txtBuscarNoAsignados);
            this.panel2.Controls.Add(this.imgNoAsignado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 62);
            this.panel2.TabIndex = 1;
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
            // 
            // btnNoAsignadoTodo
            // 
            this.btnNoAsignadoTodo.Location = new System.Drawing.Point(4, 4);
            this.btnNoAsignadoTodo.Name = "btnNoAsignadoTodo";
            this.btnNoAsignadoTodo.Size = new System.Drawing.Size(152, 24);
            this.btnNoAsignadoTodo.TabIndex = 3;
            this.btnNoAsignadoTodo.Text = "Marcar Todo";
            this.btnNoAsignadoTodo.UseVisualStyleBackColor = true;
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
            this.lblListaEmpleadoNoAsignados.Text = "Lista de Empleados no asignados";
            this.lblListaEmpleadoNoAsignados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.Controls.Add(this.btnNuevaEmpresa);
            this.pnlEmpresa.Controls.Add(this.lblEspecialidad);
            this.pnlEmpresa.Controls.Add(this.cmbEmpresa);
            this.pnlEmpresa.Location = new System.Drawing.Point(0, 95);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(764, 43);
            this.pnlEmpresa.TabIndex = 13;
            // 
            // btnNuevaEmpresa
            // 
            this.btnNuevaEmpresa.Location = new System.Drawing.Point(698, 9);
            this.btnNuevaEmpresa.Name = "btnNuevaEmpresa";
            this.btnNuevaEmpresa.Size = new System.Drawing.Size(37, 23);
            this.btnNuevaEmpresa.TabIndex = 2;
            this.btnNuevaEmpresa.Text = "...";
            this.btnNuevaEmpresa.UseVisualStyleBackColor = true;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(12, 14);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(85, 11);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(605, 21);
            this.cmbEmpresa.TabIndex = 0;
            // 
            // _00109_AsignarEmpleadoEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 514);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDesvincular);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEmpresa);
            this.Name = "_00109_AsignarEmpleadoEspecialidad";
            this.Text = "_00109_AsignarEmpleadoEspecialidad";
            this.Controls.SetChildIndex(this.pnlEmpresa, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnVincular, 0);
            this.Controls.SetChildIndex(this.btnDesvincular, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAsignado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAsignados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoAsignado)).EndInit();
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Button btnDesvincular;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvAsignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkAsignado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAsignadoNada;
        private System.Windows.Forms.Button btnAsignadoTodo;
        private System.Windows.Forms.Button btnBuscarAsignados;
        private System.Windows.Forms.TextBox txtBuscarAsignados;
        private System.Windows.Forms.PictureBox imgAsignado;
        private System.Windows.Forms.Label lblListaEmpleadoAsignados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNoAsignados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkNoAsignado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNoAsignadoNada;
        private System.Windows.Forms.Button btnNoAsignadoTodo;
        private System.Windows.Forms.Button btnBuscarNoAsignados;
        private System.Windows.Forms.TextBox txtBuscarNoAsignados;
        private System.Windows.Forms.PictureBox imgNoAsignado;
        private System.Windows.Forms.Label lblListaEmpleadoNoAsignados;
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Button btnNuevaEmpresa;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEmpresa;


    }
}