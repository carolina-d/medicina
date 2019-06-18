using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Base;
using Presentacion.PlantillaFormulario.Clases;

namespace Presentacion.PlantillaFormulario
{
    public partial class FormularioBase : Form
    {
        protected bool _datosObligatorios;

        public int? EntidadId { get; set; }
        
        public string TipoOperacion { get; set; }

        public string TituloVentana
        {
            set { if (!string.IsNullOrEmpty(value)) Text = value; }
        }

        public string Titulo
        {
            set { if (!string.IsNullOrEmpty(value)) this.lblTitulo.Text = value; }
            get { return this.lblTitulo.Text; }
        }

        public string Leyenda
        {
            set { if (!string.IsNullOrEmpty(value)) this.lblLeyenda.Text = value; }
            get { return this.lblLeyenda.Text; }
        }

        public Image ImagenTituloPanelSuperior
        {
            set { this.imgTitulo.Image = value; }
            get { return this.imgTitulo.Image; }
        }

        public string UsuarioLogin
        {
            set
            {
                this.lblUsuarioLogin.Text = string.Format("Usuario: {0}",
                                                          !string.IsNullOrEmpty(value) ? value : 
                                                          Thread.CurrentPrincipal.Identity.Name);
            }
        }

        #region Colores

        public Color? ColorPanelSuperior
        {
            set { this.panelSuperior.BackColor = value.HasValue ? value.Value : Color.White; }
        }

        public Color? ColorTitulo
        {
            set { this.lblTitulo.ForeColor = value.HasValue ? value.Value : Color.Black; }
        }

        public Color? ColorLeyenda
        {
            set { this.lblLeyenda.ForeColor = value.HasValue ? value.Value : Color.Black; }
        }

        private Color _colorRecibeFoco = Color.Beige;
        public Color? ColorRecibeFoco
        {
            set { _colorRecibeFoco = value.HasValue ? value.Value : Color.Beige; }
        }

        private Color _colorPierdeFoco = Color.White;
        public Color? ColorPierdeFoco
        {
            set { _colorPierdeFoco = value.HasValue ? value.Value : Color.White; }
        }

        #endregion

        public FormularioBase()
        {
            InitializeComponent();
        }

        public virtual void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Metodos Generales

        public virtual void LimpiarDatosFormulario(Panel pnl)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Today;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is Panel)
                {
                    foreach (var itemPnl in ((Panel)item).Controls)
                    {
                        if (itemPnl is TextBox)
                        {
                            ((TextBox)itemPnl).Clear();
                        }
                        else if (itemPnl is ComboBox)
                        {
                            ((ComboBox)itemPnl).SelectedIndex = 0;
                        }
                        else if (itemPnl is DateTimePicker)
                        {
                            ((DateTimePicker)itemPnl).Value = DateTime.Today;
                        }
                        else if (itemPnl is CheckBox)
                        {
                            ((CheckBox)itemPnl).Checked = false;
                        }
                    }
                }
            }
        }

        public virtual void LimpiarDatosFormulario()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count > 0)
                        ((ComboBox) item).SelectedIndex = 0;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Today;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is Panel)
                {
                    foreach (var itemPnl in ((Panel)item).Controls)
                    {
                        if (itemPnl is TextBox)
                        {
                            ((TextBox)itemPnl).Clear();
                        }
                        else if (itemPnl is ComboBox)
                        {
                            if (((ComboBox)itemPnl).Items.Count > 0)
                                ((ComboBox) itemPnl).SelectedIndex = 0;
                        }
                        else if (itemPnl is DateTimePicker)
                        {
                            ((DateTimePicker)itemPnl).Value = DateTime.Today;
                        }
                        else if (itemPnl is CheckBox)
                        {
                            ((CheckBox)itemPnl).Checked = false;
                        }
                    }
                }
            }
        }

        public virtual void ActivarControles(Panel pnl, bool estaActivo)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox) item).Enabled = estaActivo;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).Enabled = estaActivo;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Enabled = estaActivo;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Enabled = estaActivo;
                }
                else if (item is Button)
                {
                    ((Button)item).Enabled = estaActivo;
                }    
                else if (item is Panel)
                {
                    foreach (var itemPnl in ((Panel)item).Controls)
                    {
                        if (itemPnl is TextBox)
                        {
                            ((TextBox)itemPnl).Enabled = estaActivo;
                        }
                        else if (itemPnl is ComboBox)
                        {
                            ((ComboBox)itemPnl).Enabled = estaActivo;
                        }
                        else if (itemPnl is DateTimePicker)
                        {
                            ((DateTimePicker)itemPnl).Enabled = estaActivo;
                        }
                        else if (itemPnl is CheckBox)
                        {
                            ((CheckBox)itemPnl).Enabled = estaActivo;
                        }
                        else if (itemPnl is Button)
                        {
                            ((Button)itemPnl).Enabled = estaActivo;
                        }
                    }
                }
            }
        }

        public virtual void ActivarControles(bool estaActivo)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Enabled = estaActivo;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).Enabled = estaActivo;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Enabled = estaActivo;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Enabled = estaActivo;
                }
                else if (item is Button)
                {
                    ((Button)item).Enabled = estaActivo;
                }
                else if (item is Panel)
                {
                    foreach (var itemPnl in ((Panel)item).Controls)
                    {
                        if (itemPnl is TextBox)
                        {
                            ((TextBox)itemPnl).Enabled = estaActivo;
                        }
                        else if (itemPnl is ComboBox)
                        {
                            ((ComboBox)itemPnl).Enabled = estaActivo;
                        }
                        else if (itemPnl is DateTimePicker)
                        {
                            ((DateTimePicker)itemPnl).Enabled = estaActivo;
                        }
                        else if (itemPnl is Button)
                        {
                            ((Button)itemPnl).Enabled = estaActivo;
                        }
                        else if (itemPnl is CheckBox)
                        {
                            ((CheckBox)itemPnl).Enabled = estaActivo;
                        }
                    }
                }
            }
        }

        public virtual void PoblarComboBox(ComboBox cmb, IEnumerable<object> dataSource, string campoMostrar, string campoDevolver)
        {
            cmb.DataSource = dataSource;
            cmb.DisplayMember = campoMostrar;
            cmb.ValueMember = campoDevolver;

            if (dataSource.Count() > 0)
                cmb.SelectedIndex = 0;
        }

        public virtual void MarcarItems(DataGridView dgvGrillaItem, string nombreColumna, bool estado)
        {
            for (var i = 0; i < dgvGrillaItem.RowCount; i++)
            {
                dgvGrillaItem[nombreColumna, i].Value = estado;
            }
        }

        #endregion

        public virtual void control_Enter(object sender, EventArgs e)
        {
            if(sender is TextBox)
            {
                ((TextBox) sender).BackColor = _colorRecibeFoco;
            }
            else if(sender is DateTimePicker)
            {
                ((DateTimePicker)sender).BackColor = _colorRecibeFoco;
            }
        }

        public virtual void control_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = _colorPierdeFoco;
            }
            else if (sender is DateTimePicker)
            {
                ((DateTimePicker)sender).BackColor = _colorPierdeFoco;
            }
        }

        public void textBoxSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionDatos.NoSimbolos(sender, e);
            ValidacionDatos.NoNumeros(sender, e);
        }

        public void textBoxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionDatos.NoSimbolos(sender, e);
            ValidacionDatos.NoLetras(sender, e);
        }

        public void textBoxLetrasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionDatos.NoSimbolos(sender, e);
        }

        public void textBoxMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionDatos.ValidarEmail(sender, e);
        }

        public void textBox_Validated(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (string.IsNullOrEmpty(txt.Text))
            {
                errorProvider.SetError(txt, Constantes.datoObligatorio);
                _datosObligatorios = false;
            }
        }

        public void textBox_Email_Validated(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (ValidacionDatos.ValidarEmail(txt.Text, errorProvider, txt))
            {
                _datosObligatorios = false;
            }
        }
    }
}
