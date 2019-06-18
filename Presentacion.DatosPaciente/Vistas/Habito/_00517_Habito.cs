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

namespace Presentacion.DatosPaciente.Vistas.Habito
{
    public partial class _00517_Habito : Presentacion.PlantillaFormulario.FormularioConsulta
    {

        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;

        public _00517_Habito(IUnidadDeTrabajoDatosPaciente uowDatosPaciente)
        {
            InitializeComponent();

            this.Name = "_00517_Habito";
            this.TituloVentana = "HAbito";
            this.Titulo = "Consulta de Habitos";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Habito y Consultar sus Datos";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowDatosPaciente = uowDatosPaciente;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            // Sirve para poner los botones nuevo, modificar y eliminar en visible false,
            // ya que no se podra realizar ninguna de las operaciones antes mencionadas
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

            var resultado = _uowDatosPaciente.HabitoRepositorio.ObtenerPorFiltro(x => x.Descripcion.Contains(textoBuscar)
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

            this.dgvBusqueda.Columns["Descripcion"].Visible = true;
            this.dgvBusqueda.Columns["Descripcion"].HeaderText = "Descripcion";
            this.dgvBusqueda.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Descripcion"].DisplayIndex = 1;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00518_ABM_Habito(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00518_ABM_Habito(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00518_ABM_Habito(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

    }
}
