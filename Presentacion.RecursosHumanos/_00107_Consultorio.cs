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
    public partial class _00107_Consultorio : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoRecursosHumanos _uowRecursosHumanos;

        public _00107_Consultorio(IUnidadDeTrabajoRecursosHumanos uowRecursosHumanos)
        {
            InitializeComponent();

            this.Name = "_00107_Consultorio";
            this.TituloVentana = "Consultorio";
            this.Titulo = "Consulta de Consultorio";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Consultorio y Consultar sus Datos";

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
            this.dgvBusqueda.Columns["Numero"].Visible = true;
            this.dgvBusqueda.Columns["Numero"].HeaderText = "Código";
            this.dgvBusqueda.Columns["Numero"].Width = 100;
            this.dgvBusqueda.Columns["Numero"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Descripcion"].Visible = true;
            this.dgvBusqueda.Columns["Descripcion"].HeaderText = "Consultorio";
            this.dgvBusqueda.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00108_ABM_Consultorio(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00108_ABM_Consultorio(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00108_ABM_Consultorio(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

    }
}
