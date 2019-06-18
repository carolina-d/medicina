namespace Presentacion.Turno
{
    partial class AsignarTurno
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
            this.grbEspecialidadyEmpleado = new System.Windows.Forms.GroupBox();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mbTurno = new System.Windows.Forms.MonthCalendar();
            this.grpTurnos = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvTurno = new System.Windows.Forms.DataGridView();
            this.grpUltimoPaciente = new System.Windows.Forms.GroupBox();
            this.txtUltimoPaciente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTurnoNoche = new System.Windows.Forms.Button();
            this.btnTurnoTarde = new System.Windows.Forms.Button();
            this.btnTurnoMañana = new System.Windows.Forms.Button();
            this.grbReferencias = new System.Windows.Forms.GroupBox();
            this.chkDiaDisponible = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkFeriado = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkLicencia = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkHoy = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnProxTurno = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnCambiarDiaHora = new DevComponents.DotNetBar.ButtonX();
            this.grbDatosDelPaciente = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtAclaraciones = new System.Windows.Forms.RichTextBox();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.grbEspecialidadyEmpleado.SuspendLayout();
            this.grpTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            this.grpUltimoPaciente.SuspendLayout();
            this.grbReferencias.SuspendLayout();
            this.grbDatosDelPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEspecialidadyEmpleado
            // 
            this.grbEspecialidadyEmpleado.Controls.Add(this.cmbProfesional);
            this.grbEspecialidadyEmpleado.Controls.Add(this.label2);
            this.grbEspecialidadyEmpleado.Controls.Add(this.cmbEspecialidad);
            this.grbEspecialidadyEmpleado.Controls.Add(this.label1);
            this.grbEspecialidadyEmpleado.Location = new System.Drawing.Point(9, 10);
            this.grbEspecialidadyEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.grbEspecialidadyEmpleado.Name = "grbEspecialidadyEmpleado";
            this.grbEspecialidadyEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.grbEspecialidadyEmpleado.Size = new System.Drawing.Size(695, 93);
            this.grbEspecialidadyEmpleado.TabIndex = 0;
            this.grbEspecialidadyEmpleado.TabStop = false;
            this.grbEspecialidadyEmpleado.Text = "Seleccionar Especialidad y Profesional";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(436, 25);
            this.cmbProfesional.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(182, 21);
            this.cmbProfesional.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesional";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(100, 25);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(237, 21);
            this.cmbEspecialidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidad";
            // 
            // mbTurno
            // 
            this.mbTurno.Location = new System.Drawing.Point(729, 15);
            this.mbTurno.Margin = new System.Windows.Forms.Padding(7);
            this.mbTurno.Name = "mbTurno";
            this.mbTurno.TabIndex = 2;
            // 
            // grpTurnos
            // 
            this.grpTurnos.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpTurnos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpTurnos.Controls.Add(this.dgvTurno);
            this.grpTurnos.Controls.Add(this.grpUltimoPaciente);
            this.grpTurnos.Controls.Add(this.btnTurnoNoche);
            this.grpTurnos.Controls.Add(this.btnTurnoTarde);
            this.grpTurnos.Controls.Add(this.btnTurnoMañana);
            this.grpTurnos.Location = new System.Drawing.Point(9, 115);
            this.grpTurnos.Margin = new System.Windows.Forms.Padding(2);
            this.grpTurnos.Name = "grpTurnos";
            this.grpTurnos.Size = new System.Drawing.Size(695, 391);
            // 
            // 
            // 
            this.grpTurnos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpTurnos.Style.BackColorGradientAngle = 90;
            this.grpTurnos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpTurnos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpTurnos.Style.BorderBottomWidth = 1;
            this.grpTurnos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpTurnos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpTurnos.Style.BorderLeftWidth = 1;
            this.grpTurnos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpTurnos.Style.BorderRightWidth = 1;
            this.grpTurnos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpTurnos.Style.BorderTopWidth = 1;
            this.grpTurnos.Style.CornerDiameter = 4;
            this.grpTurnos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpTurnos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpTurnos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpTurnos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpTurnos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpTurnos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpTurnos.TabIndex = 4;
            this.grpTurnos.Text = "Turnos";
            // 
            // dgvTurno
            // 
            this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurno.Location = new System.Drawing.Point(14, 67);
            this.dgvTurno.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTurno.Name = "dgvTurno";
            this.dgvTurno.RowTemplate.Height = 24;
            this.dgvTurno.Size = new System.Drawing.Size(659, 288);
            this.dgvTurno.TabIndex = 4;
            this.dgvTurno.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvTurno_CellPainting);
            // 
            // grpUltimoPaciente
            // 
            this.grpUltimoPaciente.Controls.Add(this.txtUltimoPaciente);
            this.grpUltimoPaciente.Location = new System.Drawing.Point(451, 2);
            this.grpUltimoPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.grpUltimoPaciente.Name = "grpUltimoPaciente";
            this.grpUltimoPaciente.Padding = new System.Windows.Forms.Padding(2);
            this.grpUltimoPaciente.Size = new System.Drawing.Size(223, 58);
            this.grpUltimoPaciente.TabIndex = 3;
            this.grpUltimoPaciente.TabStop = false;
            this.grpUltimoPaciente.Text = "Ultimo Paciente";
            // 
            // txtUltimoPaciente
            // 
            // 
            // 
            // 
            this.txtUltimoPaciente.Border.Class = "TextBoxBorder";
            this.txtUltimoPaciente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUltimoPaciente.Location = new System.Drawing.Point(13, 29);
            this.txtUltimoPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtUltimoPaciente.Name = "txtUltimoPaciente";
            this.txtUltimoPaciente.PreventEnterBeep = true;
            this.txtUltimoPaciente.Size = new System.Drawing.Size(164, 20);
            this.txtUltimoPaciente.TabIndex = 0;
            // 
            // btnTurnoNoche
            // 
            this.btnTurnoNoche.Location = new System.Drawing.Point(295, 3);
            this.btnTurnoNoche.Margin = new System.Windows.Forms.Padding(2);
            this.btnTurnoNoche.Name = "btnTurnoNoche";
            this.btnTurnoNoche.Size = new System.Drawing.Size(97, 48);
            this.btnTurnoNoche.TabIndex = 2;
            this.btnTurnoNoche.Text = "Turno Noche";
            this.btnTurnoNoche.UseVisualStyleBackColor = true;
            // 
            // btnTurnoTarde
            // 
            this.btnTurnoTarde.Location = new System.Drawing.Point(160, 3);
            this.btnTurnoTarde.Margin = new System.Windows.Forms.Padding(2);
            this.btnTurnoTarde.Name = "btnTurnoTarde";
            this.btnTurnoTarde.Size = new System.Drawing.Size(97, 48);
            this.btnTurnoTarde.TabIndex = 1;
            this.btnTurnoTarde.Text = "Turno Tarde";
            this.btnTurnoTarde.UseVisualStyleBackColor = true;
            // 
            // btnTurnoMañana
            // 
            this.btnTurnoMañana.Location = new System.Drawing.Point(14, 3);
            this.btnTurnoMañana.Margin = new System.Windows.Forms.Padding(2);
            this.btnTurnoMañana.Name = "btnTurnoMañana";
            this.btnTurnoMañana.Size = new System.Drawing.Size(97, 48);
            this.btnTurnoMañana.TabIndex = 0;
            this.btnTurnoMañana.Text = "Turno Mañana";
            this.btnTurnoMañana.UseVisualStyleBackColor = true;
            // 
            // grbReferencias
            // 
            this.grbReferencias.Controls.Add(this.chkDiaDisponible);
            this.grbReferencias.Controls.Add(this.chkFeriado);
            this.grbReferencias.Controls.Add(this.chkLicencia);
            this.grbReferencias.Controls.Add(this.chkHoy);
            this.grbReferencias.Location = new System.Drawing.Point(729, 193);
            this.grbReferencias.Margin = new System.Windows.Forms.Padding(2);
            this.grbReferencias.Name = "grbReferencias";
            this.grbReferencias.Padding = new System.Windows.Forms.Padding(2);
            this.grbReferencias.Size = new System.Drawing.Size(165, 70);
            this.grbReferencias.TabIndex = 5;
            this.grbReferencias.TabStop = false;
            this.grbReferencias.Text = "Referencias";
            // 
            // chkDiaDisponible
            // 
            this.chkDiaDisponible.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.chkDiaDisponible.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkDiaDisponible.Location = new System.Drawing.Point(86, 18);
            this.chkDiaDisponible.Margin = new System.Windows.Forms.Padding(2);
            this.chkDiaDisponible.Name = "chkDiaDisponible";
            this.chkDiaDisponible.Size = new System.Drawing.Size(75, 19);
            this.chkDiaDisponible.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkDiaDisponible.TabIndex = 3;
            this.chkDiaDisponible.Text = "Dia Disponible";
            // 
            // chkFeriado
            // 
            this.chkFeriado.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.chkFeriado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFeriado.Location = new System.Drawing.Point(6, 41);
            this.chkFeriado.Margin = new System.Windows.Forms.Padding(2);
            this.chkFeriado.Name = "chkFeriado";
            this.chkFeriado.Size = new System.Drawing.Size(75, 19);
            this.chkFeriado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFeriado.TabIndex = 2;
            this.chkFeriado.Text = "Feriado";
            // 
            // chkLicencia
            // 
            this.chkLicencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.chkLicencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkLicencia.Location = new System.Drawing.Point(86, 41);
            this.chkLicencia.Margin = new System.Windows.Forms.Padding(2);
            this.chkLicencia.Name = "chkLicencia";
            this.chkLicencia.Size = new System.Drawing.Size(75, 19);
            this.chkLicencia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkLicencia.TabIndex = 1;
            this.chkLicencia.Text = "Licencia";
            // 
            // chkHoy
            // 
            this.chkHoy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // 
            // 
            this.chkHoy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkHoy.Location = new System.Drawing.Point(6, 18);
            this.chkHoy.Margin = new System.Windows.Forms.Padding(2);
            this.chkHoy.Name = "chkHoy";
            this.chkHoy.Size = new System.Drawing.Size(75, 19);
            this.chkHoy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkHoy.TabIndex = 0;
            this.chkHoy.Text = "Hoy";
            // 
            // btnProxTurno
            // 
            this.btnProxTurno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProxTurno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnProxTurno.Location = new System.Drawing.Point(709, 470);
            this.btnProxTurno.Margin = new System.Windows.Forms.Padding(2);
            this.btnProxTurno.Name = "btnProxTurno";
            this.btnProxTurno.Size = new System.Drawing.Size(56, 48);
            this.btnProxTurno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProxTurno.TabIndex = 6;
            this.btnProxTurno.Text = "Prox. Turno Libre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Location = new System.Drawing.Point(777, 470);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 48);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            // 
            // btnCambiarDiaHora
            // 
            this.btnCambiarDiaHora.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCambiarDiaHora.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCambiarDiaHora.Location = new System.Drawing.Point(842, 471);
            this.btnCambiarDiaHora.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarDiaHora.Name = "btnCambiarDiaHora";
            this.btnCambiarDiaHora.Size = new System.Drawing.Size(56, 47);
            this.btnCambiarDiaHora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCambiarDiaHora.TabIndex = 8;
            this.btnCambiarDiaHora.Text = "Cambiar Dia/Hora";
            // 
            // grbDatosDelPaciente
            // 
            this.grbDatosDelPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.grbDatosDelPaciente.CanvasColor = System.Drawing.SystemColors.Control;
            this.grbDatosDelPaciente.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grbDatosDelPaciente.Controls.Add(this.txtAclaraciones);
            this.grbDatosDelPaciente.Controls.Add(this.txtObraSocial);
            this.grbDatosDelPaciente.Controls.Add(this.txtTelefono);
            this.grbDatosDelPaciente.Controls.Add(this.txtNombrePaciente);
            this.grbDatosDelPaciente.Location = new System.Drawing.Point(729, 267);
            this.grbDatosDelPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.grbDatosDelPaciente.Name = "grbDatosDelPaciente";
            this.grbDatosDelPaciente.Size = new System.Drawing.Size(160, 198);
            // 
            // 
            // 
            this.grbDatosDelPaciente.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grbDatosDelPaciente.Style.BackColorGradientAngle = 90;
            this.grbDatosDelPaciente.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grbDatosDelPaciente.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbDatosDelPaciente.Style.BorderBottomWidth = 1;
            this.grbDatosDelPaciente.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grbDatosDelPaciente.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbDatosDelPaciente.Style.BorderLeftWidth = 1;
            this.grbDatosDelPaciente.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbDatosDelPaciente.Style.BorderRightWidth = 1;
            this.grbDatosDelPaciente.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grbDatosDelPaciente.Style.BorderTopWidth = 1;
            this.grbDatosDelPaciente.Style.CornerDiameter = 4;
            this.grbDatosDelPaciente.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grbDatosDelPaciente.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grbDatosDelPaciente.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grbDatosDelPaciente.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grbDatosDelPaciente.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grbDatosDelPaciente.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grbDatosDelPaciente.TabIndex = 9;
            this.grbDatosDelPaciente.Text = "Datos del Paciente";
            // 
            // txtAclaraciones
            // 
            this.txtAclaraciones.Location = new System.Drawing.Point(4, 106);
            this.txtAclaraciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtAclaraciones.Name = "txtAclaraciones";
            this.txtAclaraciones.Size = new System.Drawing.Size(151, 71);
            this.txtAclaraciones.TabIndex = 3;
            this.txtAclaraciones.Text = "Aclaraciones";
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.Location = new System.Drawing.Point(4, 74);
            this.txtObraSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(99, 20);
            this.txtObraSocial.TabIndex = 2;
            this.txtObraSocial.Text = "Obra Social";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(4, 42);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(99, 20);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.Text = "Telefono";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(4, 11);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(151, 20);
            this.txtNombrePaciente.TabIndex = 0;
            this.txtNombrePaciente.Text = "Nombre";
            // 
            // AsignarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 538);
            this.Controls.Add(this.grbDatosDelPaciente);
            this.Controls.Add(this.btnCambiarDiaHora);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnProxTurno);
            this.Controls.Add(this.grbReferencias);
            this.Controls.Add(this.grpTurnos);
            this.Controls.Add(this.mbTurno);
            this.Controls.Add(this.grbEspecialidadyEmpleado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AsignarTurno";
            this.Text = "Turno Mañana";
            this.grbEspecialidadyEmpleado.ResumeLayout(false);
            this.grbEspecialidadyEmpleado.PerformLayout();
            this.grpTurnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
            this.grpUltimoPaciente.ResumeLayout(false);
            this.grbReferencias.ResumeLayout(false);
            this.grbDatosDelPaciente.ResumeLayout(false);
            this.grbDatosDelPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEspecialidadyEmpleado;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mbTurno;
        private DevComponents.DotNetBar.Controls.GroupPanel grpTurnos;
        private System.Windows.Forms.DataGridView dgvTurno;
        private System.Windows.Forms.GroupBox grpUltimoPaciente;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUltimoPaciente;
        private System.Windows.Forms.Button btnTurnoNoche;
        private System.Windows.Forms.Button btnTurnoTarde;
        private System.Windows.Forms.Button btnTurnoMañana;
        private System.Windows.Forms.GroupBox grbReferencias;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkDiaDisponible;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkFeriado;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkLicencia;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkHoy;
        private DevComponents.DotNetBar.ButtonX btnProxTurno;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.ButtonX btnCambiarDiaHora;
        private DevComponents.DotNetBar.Controls.GroupPanel grbDatosDelPaciente;
        private System.Windows.Forms.RichTextBox txtAclaraciones;
        private System.Windows.Forms.TextBox txtObraSocial;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        protected System.Windows.Forms.ComboBox cmbEspecialidad;
    }
}