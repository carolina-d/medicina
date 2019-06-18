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
using Aplicacion.DatosPaciente.DTOs;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;

namespace Presentacion.DatosPaciente.Vistas.Vacunacion
{
    public partial class _00504_CalendarioVacunacion : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;

        public _00504_CalendarioVacunacion(IUnidadDeTrabajoDatosPaciente uowDatosPaciente)
        {
            InitializeComponent();

            this.Name = "_00504_CalendarioVacunacion";
            this.TituloVentana = "Calendario de Vacunación";
            this.Titulo = "Consulta del Calendario de Vacunación";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar una Vacuna al Calendario y Consultar sus Datos";
            
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
            var resultado = _uowDatosPaciente.CalendarioVacunacionRepositorio.ObtenerPorFiltro(x => x.Vacuna.Nombre.Contains(textoBuscar), "Vacuna, Dosis")
                .Select(x=> new CalendarioVacunacionDTO
                                {
                                    Id = x.Id,
                                    Anio = x.Anio,
                                    Dia = x.Dia,
                                    Dosis = x.Dosis.Descripcion,
                                    Mes = x.Mes,
                                    EsObligatoria = x.Obligatoria ? "SI" : "NO",
                                    Vacuna = x.Vacuna.Nombre,
                                    VacunaId = x.VacunaId
                                }).ToList();

            this.dgvBusqueda.DataSource = resultado;

            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["Anio"].Visible = true;
            this.dgvBusqueda.Columns["Anio"].HeaderText = "Año";
            this.dgvBusqueda.Columns["Anio"].Width = 50;
            this.dgvBusqueda.Columns["Anio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Anio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Anio"].DisplayIndex = 0;

            this.dgvBusqueda.Columns["Mes"].Visible = true;
            this.dgvBusqueda.Columns["Mes"].HeaderText = "Mes";
            this.dgvBusqueda.Columns["Mes"].Width = 50;
            this.dgvBusqueda.Columns["Mes"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Mes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Mes"].DisplayIndex = 1;

            this.dgvBusqueda.Columns["Dia"].Visible = true;
            this.dgvBusqueda.Columns["Dia"].HeaderText = "Día";
            this.dgvBusqueda.Columns["Dia"].Width = 50;
            this.dgvBusqueda.Columns["Dia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Dia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Dia"].DisplayIndex = 2;

            this.dgvBusqueda.Columns["Vacuna"].Visible = true;
            this.dgvBusqueda.Columns["Vacuna"].HeaderText = "Vacuna";
            this.dgvBusqueda.Columns["Vacuna"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["Vacuna"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Vacuna"].DisplayIndex = 3;

            this.dgvBusqueda.Columns["Dosis"].Visible = true;
            this.dgvBusqueda.Columns["Dosis"].HeaderText = "Dósis";
            this.dgvBusqueda.Columns["Dosis"].Width = 100;
            this.dgvBusqueda.Columns["Dosis"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Dosis"].DisplayIndex = 4;

            this.dgvBusqueda.Columns["EsObligatoria"].Visible = true;
            this.dgvBusqueda.Columns["EsObligatoria"].HeaderText = "Obligatoria";
            this.dgvBusqueda.Columns["EsObligatoria"].Width = 70;
            this.dgvBusqueda.Columns["EsObligatoria"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["EsObligatoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["EsObligatoria"].DisplayIndex = 5;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00505_ABM_CalendarioVacunacion(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00505_ABM_CalendarioVacunacion(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00505_ABM_CalendarioVacunacion(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    }
}
