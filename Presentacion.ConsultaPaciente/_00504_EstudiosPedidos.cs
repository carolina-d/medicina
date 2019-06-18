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
using Dominio.ConsultaPaciente.Interfaces.IUnidadDeTrabajo;

namespace Presentacion.ConsultaPaciente
{
    public partial class _00504_EstudiosPedidos : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoConsultaPaciente _uowConsultaPaciente;
        public _00504_EstudiosPedidos(IUnidadDeTrabajoConsultaPaciente uowConsultaPaciente)
        {
            InitializeComponent();
            this.Name = "_00504_EstudiosPedidos";
            this.TituloVentana = "EstudiosPedidos";
            this.Titulo = "Consulta de Estudios Pedidos";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Estudio y Consultar sus Datos";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowConsultaPaciente = uowConsultaPaciente;
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

            var resultado = _uowConsultaPaciente.EstudiosPedidosRepositorio.ObtenerPorFiltro(x => x.NombreEstudio.Contains(textoBuscar)
                || x.Obsevaciones.Equals(codigo)).ToList();

            this.dgvBusqueda.DataSource = resultado;
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["NombreEstudio"].Visible = true;
            this.dgvBusqueda.Columns["NombreEstudio"].HeaderText = "Nombre Estudio";
            this.dgvBusqueda.Columns["NombreEstudio"].Width = 100;
            this.dgvBusqueda.Columns["NombreEstudio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Observaciones"].Visible = true;
            this.dgvBusqueda.Columns["Observaciones"].HeaderText = "Observaciones";
            this.dgvBusqueda.Columns["Observaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["Observaciones"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00505_ABM_EstudiosPedidos(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00505_ABM_EstudiosPedidos(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00505_ABM_EstudiosPedidos(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    }
}