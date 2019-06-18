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
using Dominio.Comun.Interfaces.UnidadDeTrabajo;

namespace Presentacion.Comun
{
    public partial class _00304_ObraSocial : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoComun _uowComun;

        public _00304_ObraSocial(IUnidadDeTrabajoComun uowComun)
        {
            InitializeComponent();

            this.Name = "_00304_ObraSocial";
            this.TituloVentana = "Obra Social";
            this.Titulo = "Consulta de Obra Social";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar una Obra Social y Consultar sus Datos";
            
            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowComun = uowComun;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            // Sirve para poner los botones nuevo, modificar y eliminar en visible false,
            // ya que no se podra realizar ninguna de las operaciones antes mencionadas
            this.EstaModoDiccionario = true;
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

            var resultado = _uowComun.ObraSocialRepositorio.ObtenerPorFiltro(x => x.Descripcion.Contains(textoBuscar)
                || x.Abreviatura.Contains(textoBuscar)
                || x.Codigo.Equals(codigo)).ToList();

            this.dgvBusqueda.DataSource = resultado;
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["Codigo"].Visible = true;
            this.dgvBusqueda.Columns["Codigo"].HeaderText = "Código";
            this.dgvBusqueda.Columns["Codigo"].Width = 100;
            this.dgvBusqueda.Columns["Codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Abreviatura"].Visible = true;
            this.dgvBusqueda.Columns["Abreviatura"].HeaderText = "Abreviatura";
            this.dgvBusqueda.Columns["Abreviatura"].Width = 100;
            this.dgvBusqueda.Columns["Abreviatura"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Descripcion"].Visible = true;
            this.dgvBusqueda.Columns["Descripcion"].HeaderText = "Obra Social";
            this.dgvBusqueda.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00305_ABM_ObraSocial(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00305_ABM_ObraSocial(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00305_ABM_ObraSocial(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    }
}
