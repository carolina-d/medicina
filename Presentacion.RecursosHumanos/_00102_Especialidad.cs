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
using Aplicacion.RecursosHumanos.DTOs;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;

namespace Presentacion.RecursosHumanos
{
    public partial class _00102_Especialidad : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoRecursosHumanos _uowRecursosHumanos;

        public _00102_Especialidad(IUnidadDeTrabajoRecursosHumanos uowRecursosHumanos)
        {
            InitializeComponent();

            this.Name = "_00102_Especialidad";
            this.TituloVentana = "Especialidad";
            this.Titulo = "Consulta de Especialidades";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar una Especialidad y Consultar sus Datos";
            
            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowRecursosHumanos = uowRecursosHumanos;

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

            var resultado = _uowRecursosHumanos.EspecialidadRepositorio.ObtenerPorFiltro(x => x.Descripcion.Contains(textoBuscar)
                || x.Codigo.Equals(codigo)).ToList();

            this.dgvBusqueda.DataSource = resultado;
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["Codigo"].Visible = true;
            this.dgvBusqueda.Columns["Codigo"].HeaderText = "Código";
            this.dgvBusqueda.Columns["Codigo"].Width = 100;
            this.dgvBusqueda.Columns["Codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Descripcion"].Visible = true;
            this.dgvBusqueda.Columns["Descripcion"].HeaderText = "Especialidad";
            this.dgvBusqueda.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00103_ABM_Especialidad(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00103_ABM_Especialidad(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00103_ABM_Especialidad(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    }
}
