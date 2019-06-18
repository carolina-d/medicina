namespace Presentacion.ConsultaPaciente
{
    partial class _00503_ABM_MotivoConsulta
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
            this.Codigo = new DevComponents.DotNetBar.LabelX();
            this.Descripcion = new DevComponents.DotNetBar.LabelX();
            this.txtCodigoMotivoConsulta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescripcionMotivoConsulta = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            // 
            // 
            // 
            this.Codigo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Codigo.Location = new System.Drawing.Point(279, 196);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(75, 23);
            this.Codigo.TabIndex = 5;
            this.Codigo.Text = "Codigo";
            // 
            // Descripcion
            // 
            // 
            // 
            // 
            this.Descripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Descripcion.Location = new System.Drawing.Point(279, 240);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(75, 23);
            this.Descripcion.TabIndex = 6;
            this.Descripcion.Text = "Descripcion";
            // 
            // txtCodigoMotivoConsulta
            // 
            // 
            // 
            // 
            this.txtCodigoMotivoConsulta.Border.Class = "TextBoxBorder";
            this.txtCodigoMotivoConsulta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodigoMotivoConsulta.Location = new System.Drawing.Point(361, 196);
            this.txtCodigoMotivoConsulta.Name = "txtCodigoMotivoConsulta";
            this.txtCodigoMotivoConsulta.PreventEnterBeep = true;
            this.txtCodigoMotivoConsulta.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoMotivoConsulta.TabIndex = 7;
            // 
            // txtDescripcionMotivoConsulta
            // 
            // 
            // 
            // 
            this.txtDescripcionMotivoConsulta.Border.Class = "TextBoxBorder";
            this.txtDescripcionMotivoConsulta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcionMotivoConsulta.Location = new System.Drawing.Point(361, 240);
            this.txtDescripcionMotivoConsulta.Name = "txtDescripcionMotivoConsulta";
            this.txtDescripcionMotivoConsulta.PreventEnterBeep = true;
            this.txtDescripcionMotivoConsulta.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcionMotivoConsulta.TabIndex = 8;
            // 
            // _00503_ABM_MotivoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 459);
            this.Controls.Add(this.txtDescripcionMotivoConsulta);
            this.Controls.Add(this.txtCodigoMotivoConsulta);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Codigo);
            this.Name = "_00503_ABM_MotivoConsulta";
            this.Text = "_00503_ABM_MotivoConsulta";
            this.Controls.SetChildIndex(this.Codigo, 0);
            this.Controls.SetChildIndex(this.Descripcion, 0);
            this.Controls.SetChildIndex(this.txtCodigoMotivoConsulta, 0);
            this.Controls.SetChildIndex(this.txtDescripcionMotivoConsulta, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       private DevComponents.DotNetBar.LabelX Codigo;
       private DevComponents.DotNetBar.LabelX Descripcion;
       private DevComponents.DotNetBar.Controls.TextBoxX txtCodigoMotivoConsulta;
       private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcionMotivoConsulta;
    }
}