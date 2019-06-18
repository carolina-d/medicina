namespace Presentacion.ConsultaPaciente
{
    partial class _00501_ABM_Sintomas
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
            this.txtCodigoSintomas = new System.Windows.Forms.TextBox();
            this.txtDescripcionSintomas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoSintomas
            // 
            this.txtCodigoSintomas.Location = new System.Drawing.Point(380, 184);
            this.txtCodigoSintomas.Name = "txtCodigoSintomas";
            this.txtCodigoSintomas.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoSintomas.TabIndex = 5;
            // 
            // txtDescripcionSintomas
            // 
            this.txtDescripcionSintomas.Location = new System.Drawing.Point(380, 272);
            this.txtDescripcionSintomas.Name = "txtDescripcionSintomas";
            this.txtDescripcionSintomas.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcionSintomas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion";
            // 
            // _00501_ABM_Sintomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcionSintomas);
            this.Controls.Add(this.txtCodigoSintomas);
            this.Name = "_00501_ABM_Sintomas";
            this.Text = "_00501_ABM_Sintomas";
            this.Controls.SetChildIndex(this.txtCodigoSintomas, 0);
            this.Controls.SetChildIndex(this.txtDescripcionSintomas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoSintomas;
        private System.Windows.Forms.TextBox txtDescripcionSintomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}