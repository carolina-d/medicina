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

namespace Presentacion.DatosPaciente.Vistas.Vacunacion
{
    public partial class _00500_Vacunas : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;

        public _00500_Vacunas(IUnidadDeTrabajoDatosPaciente uowDatosPaciente)
        {
            InitializeComponent();

            this.Name = "_00500_Vacunas";
            this.TituloVentana = "Vacuna";
            this.Titulo = "Consulta de Vacunas";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar una Vacuna y Consultar sus Datos";
            
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
            var resultado = _uowDatosPaciente.VacunaRepositorio.ObtenerPorFiltro(x => x.Abreviatura.Contains(textoBuscar)
                || x.Nombre.Contains(textoBuscar)).ToList();

            this.dgvBusqueda.DataSource = resultado;
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["Abreviatura"].Visible = true;
            this.dgvBusqueda.Columns["Abreviatura"].HeaderText = "Abreviatura";
            this.dgvBusqueda.Columns["Abreviatura"].Width = 100;
            this.dgvBusqueda.Columns["Abreviatura"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Abreviatura"].DisplayIndex = 0;

            this.dgvBusqueda.Columns["Nombre"].Visible = true;
            this.dgvBusqueda.Columns["Nombre"].HeaderText = "Vacuna";
            this.dgvBusqueda.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["Nombre"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Nombre"].DisplayIndex = 1;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00501_ABM_Vacuna(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00501_ABM_Vacuna(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00501_ABM_Vacuna(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    }
}
