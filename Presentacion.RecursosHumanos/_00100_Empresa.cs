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
    public partial class _00100_Empresa : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoRecursosHumanos _uowRecursosHumanos;

        public _00100_Empresa(IUnidadDeTrabajoRecursosHumanos uowRecursosHumanos)
        {
            InitializeComponent();

            this.Name = "_00100_Empresa";
            this.TituloVentana = "Empresa";
            this.Titulo = "Consulta de Empresas";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar una Empresa y Consultar sus Datos";
            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowRecursosHumanos = uowRecursosHumanos;

            this.EstaModoDiccionario = false;

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;
        }

        public override void FormularioBaseConsulta_Load(object sender, EventArgs e)
        {
            base.FormularioBaseConsulta_Load(sender, e);
            
            FormatearGrilla();
            
            this.txtBuscar.Focus();
        }

        public override void ActualizarDatosGrilla(string textoBuscar)
        {
            var resultado = _uowRecursosHumanos.EmpresaRepositorio.ObtenerPorFiltro(x=>x.RazonSocial.Contains(textoBuscar)
                || x.NombreFantasia.Contains(textoBuscar)
                || x.CuitCuil.Equals(textoBuscar), "Empleados")
                .Select(x=> new EmpresaDTO
                {
                    Id = x.Id,
                    RazonSocial = x.RazonSocial,
                    NombreFantasia = x.NombreFantasia,
                    Telefono = x.Telefono,
                    CantidadEmpleado = x.Empleados != null ? x.Empleados.Count : 0
                }).ToList();

            this.dgvBusqueda.DataSource = resultado;
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["RazonSocial"].Visible = true;
            this.dgvBusqueda.Columns["RazonSocial"].HeaderText = "Razón Social";
            this.dgvBusqueda.Columns["RazonSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["RazonSocial"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["NombreFantasia"].Visible = true;
            this.dgvBusqueda.Columns["NombreFantasia"].HeaderText = "Nombre Fantasía";
            this.dgvBusqueda.Columns["NombreFantasia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["NombreFantasia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Telefono"].Visible = true;
            this.dgvBusqueda.Columns["Telefono"].HeaderText = "Teléfono";
            this.dgvBusqueda.Columns["Telefono"].Width = 100;
            this.dgvBusqueda.Columns["Telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["CantidadEmpleado"].Visible = true;
            this.dgvBusqueda.Columns["CantidadEmpleado"].HeaderText = "Cant. Empleado";
            this.dgvBusqueda.Columns["CantidadEmpleado"].Width = 100;
            this.dgvBusqueda.Columns["CantidadEmpleado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00101_ABM_Empresa(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00101_ABM_Empresa(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00101_ABM_Empresa(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    }
}
