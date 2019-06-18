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
    public partial class _00104_Empleado : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoRecursosHumanos _uowRecursosHumanos;

        public _00104_Empleado(IUnidadDeTrabajoRecursosHumanos uowRecursosHumanos)
        {
            InitializeComponent();

            this.Name = "_00104_Empleado";
            this.TituloVentana = "Empleado";
            this.Titulo = "Consulta de Empleados";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Empleado y Consultar sus Datos";
            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowRecursosHumanos = uowRecursosHumanos;

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
            var resultado = _uowRecursosHumanos.EmpleadoRepositorio.ObtenerPorFiltro(x => x.Apellido.Contains(textoBuscar)
                || x.Nombre.Contains(textoBuscar)
                || x.Especialidad.Descripcion.Contains(textoBuscar)
                || x.MatriculaNacional.Equals(textoBuscar)
                || x.MatriculaProvincial.Equals(textoBuscar)
                || x.Dni.Equals(textoBuscar), "Especialidad")
                .Select(x=> new EmpleadoDTO
                {
                    Id = x.Id,
                    ApyNom = x.ApyNom,
                    Dni = x.Dni,
                    Celular = x.Celular,
                    Especialidad = x.Especialidad != null ? x.Especialidad.Descripcion : "--"
                }).ToList();

            this.dgvBusqueda.DataSource = resultado;
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["ApyNom"].Visible = true;
            this.dgvBusqueda.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            this.dgvBusqueda.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["ApyNom"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Dni"].Visible = true;
            this.dgvBusqueda.Columns["Dni"].HeaderText = "DNI";
            this.dgvBusqueda.Columns["Dni"].Width = 100;
            this.dgvBusqueda.Columns["Dni"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Dni"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Celular"].Visible = true;
            this.dgvBusqueda.Columns["Celular"].HeaderText = "Celular";
            this.dgvBusqueda.Columns["Celular"].Width = 100;
            this.dgvBusqueda.Columns["Celular"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Celular"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Especialidad"].Visible = true;
            this.dgvBusqueda.Columns["Especialidad"].HeaderText = "Especialidad";
            this.dgvBusqueda.Columns["Especialidad"].Width = 150;
            this.dgvBusqueda.Columns["Especialidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00105_ABM_Empleado(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00105_ABM_Empleado(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00105_ABM_Empleado(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    }
}
