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
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;

namespace Presentacion.DatosPaciente.Vistas.Antecedente
{
    public partial class _00519_Antecedente : PlantillaFormulario.FormularioConsulta
    {

        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;

        public _00519_Antecedente(IUnidadDeTrabajoDatosPaciente uowDatosPaciente)
        {
            InitializeComponent();

            this.Name = "_00519_Antecedente";
            this.TituloVentana = "Antecedente";
            this.Titulo = "Consulta de Antecedentes";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Antecedente y Consultar sus Datos";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowDatosPaciente = uowDatosPaciente;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this.EstaModoDiccionario = false;

        }

        public override void FormularioBaseConsulta_Load(object sender, EventArgs e)
        {
            base.FormularioBaseConsulta_Load(sender, e);

            FormatearGrilla();

            this.txtBuscar.Focus();
        }

        public override void ActualizarDatosGrilla(string textoBuscar)
        {
            int codigo = -1;

            int.TryParse(textoBuscar, out codigo);

            var resultado = _uowDatosPaciente.AntecedenteRepositorio.ObtenerPorFiltro(x => x.AntecedentesPersonales.Contains(textoBuscar)
                || x.Codigo.Equals(codigo)).ToList();

            this.dgvBusqueda.DataSource = resultado;
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["Codigo"].Visible = true;
            this.dgvBusqueda.Columns["Codigo"].HeaderText = "Código";
            this.dgvBusqueda.Columns["Codigo"].Width = 100;
            this.dgvBusqueda.Columns["Codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Codigo"].DisplayIndex = 0;

            this.dgvBusqueda.Columns["Fecha"].Visible = true;
            this.dgvBusqueda.Columns["Fecha"].HeaderText = "Fecha";
            this.dgvBusqueda.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["Fecha"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Fecha"].DisplayIndex = 1;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00520_ABM_Antecedente(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00520_ABM_Antecedente(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00520_ABM_Antecedente(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

    }
}
