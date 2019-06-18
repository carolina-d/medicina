using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.RecursosHumanos.DTOs;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;

namespace Presentacion.RecursosHumanos
{
    public partial class _00107_HorarioDeTrabajo : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoRecursosHumanos _uowRecursosHumanos;
        
        public _00107_HorarioDeTrabajo(IUnidadDeTrabajoRecursosHumanos uowRecursosHumanos)
        {
            InitializeComponent();

            this.Name = "_00107_HorarioDeTrabajo";
            this.TituloVentana = "Empresa";
            this.Titulo = "Consulta de Horario De Trabajo";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar una Horario De Trabajo y Consultar sus Datos";
            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowRecursosHumanos = uowRecursosHumanos;

            this.EstaModoDiccionario = false;
        }

        public override void FormularioBaseConsulta_Load(object sender, EventArgs e)
        {
            FormatearGrilla();
            this.txtBuscar.Focus();            
            base.FormularioBaseConsulta_Load(sender, e);
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["ConsultorioId"].Visible = true;
            this.dgvBusqueda.Columns["ConsultorioId"].HeaderText = "Consultorio";
            this.dgvBusqueda.Columns["ConsultorioId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["ConsultorioId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["EmpleadoIdHdT"].Visible = true;
            this.dgvBusqueda.Columns["EmpleadoIdHdT"].HeaderText = "Empleado";
            this.dgvBusqueda.Columns["EmpleadoIdHdT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["EmpleadoIdHdT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["HorarioEntradaTarde"].Visible = true;
            this.dgvBusqueda.Columns["HorarioEntradaTarde"].HeaderText = "Teléfono";
            this.dgvBusqueda.Columns["HorarioEntradaTarde"].Width = 100;
            this.dgvBusqueda.Columns["HorarioEntradaTarde"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["HorarioSalidaTarde"].Visible = true;
            this.dgvBusqueda.Columns["HorarioSalidaTarde"].HeaderText = "Cant. Empleado";
            this.dgvBusqueda.Columns["HorarioSalidaTarde"].Width = 100;
            this.dgvBusqueda.Columns["HorarioSalidaTarde"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["HorarioSalidaMañana"].Visible = true;
            this.dgvBusqueda.Columns["HorarioSalidaMañana"].HeaderText = "Cant. Empleado";
            this.dgvBusqueda.Columns["HorarioSalidaMañana"].Width = 100;
            this.dgvBusqueda.Columns["HorarioSalidaMañana"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["HorarioEntradaMañana"].Visible = true;
            this.dgvBusqueda.Columns["HorarioEntradaMañana"].HeaderText = "Cant. Empleado";
            this.dgvBusqueda.Columns["HorarioEntradaMañana"].Width = 100;
            this.dgvBusqueda.Columns["HorarioEntradaMañana"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        
            
        }

        public override void ActualizarDatosGrilla(string textoBuscar)
        {
            var resultado = _uowRecursosHumanos.HorarioDeTrabajoRepositorio.ObtenerPorFiltro(x => x.ConsultorioId.Equals(textoBuscar)
                || x.EmpleadoId.Equals(textoBuscar)
                || x.HoraInM.Equals(textoBuscar)
                || x.HoraInT.Equals(textoBuscar)
                || x.HoraOutM.Equals(textoBuscar)
                || x.HoraOutT.Equals(textoBuscar), "HorarioDeTrabajo")
                .Select(x => new HorarioDeTrabajoDTO
                {
                    Id = x.Id,
                    ConsultorioId = x.ConsultorioId,
                    EmpleadoId = x.EmpleadoId,
                    HoraInM = x.HoraInM,
                    HoraInT = x.HoraInT,
                    HoraOutM = x.HoraOutM,
                    HoraOutT = x.HoraOutT
                }).ToList();
            this.dgvBusqueda.DataSource = resultado;                
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00108_ABM_HorarioDeTrabajo(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00108_ABM_HorarioDeTrabajo(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00108_ABM_HorarioDeTrabajo(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    
    }
}
