namespace Presentacion.Seguridad
{
    partial class _00207_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00207_Login));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.linkSalirSistema = new System.Windows.Forms.LinkLabel();
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.imgVerPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVerPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Yellow;
            this.lblPassword.Location = new System.Drawing.Point(236, 205);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 16);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.lblUsuario.Location = new System.Drawing.Point(236, 162);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 16);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(239, 251);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(118, 32);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(239, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(171, 21);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(239, 181);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(198, 21);
            this.txtUsuario.TabIndex = 12;
            // 
            // linkSalirSistema
            // 
            this.linkSalirSistema.AutoSize = true;
            this.linkSalirSistema.BackColor = System.Drawing.Color.Transparent;
            this.linkSalirSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSalirSistema.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkSalirSistema.Location = new System.Drawing.Point(55, 361);
            this.linkSalirSistema.Name = "linkSalirSistema";
            this.linkSalirSistema.Size = new System.Drawing.Size(117, 15);
            this.linkSalirSistema.TabIndex = 17;
            this.linkSalirSistema.TabStop = true;
            this.linkSalirSistema.Text = "Salir del Sistema";
            this.linkSalirSistema.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSalirSistema_LinkClicked);
            // 
            // imgSalir
            // 
            this.imgSalir.BackColor = System.Drawing.Color.Transparent;
            this.imgSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSalir.Location = new System.Drawing.Point(12, 351);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(35, 37);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSalir.TabIndex = 18;
            this.imgSalir.TabStop = false;
            // 
            // imgVerPassword
            // 
            this.imgVerPassword.BackColor = System.Drawing.Color.Transparent;
            this.imgVerPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVerPassword.Image = ((System.Drawing.Image)(resources.GetObject("imgVerPassword.Image")));
            this.imgVerPassword.Location = new System.Drawing.Point(413, 224);
            this.imgVerPassword.Name = "imgVerPassword";
            this.imgVerPassword.Size = new System.Drawing.Size(24, 21);
            this.imgVerPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVerPassword.TabIndex = 19;
            this.imgVerPassword.TabStop = false;
            this.imgVerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgVerPassword_MouseDown);
            this.imgVerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgVerPassword_MouseUp);
            // 
            // _00207_Login
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.linkSalirSistema;
            this.ClientSize = new System.Drawing.Size(468, 394);
            this.ControlBox = false;
            this.Controls.Add(this.imgVerPassword);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.linkSalirSistema);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_00207_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this._00207_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVerPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.LinkLabel linkSalirSistema;
        private System.Windows.Forms.PictureBox imgSalir;
        private System.Windows.Forms.PictureBox imgVerPassword;
    }
}