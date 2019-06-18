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
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEmpresa;

namespace Presentacion.RecursosHumanos
{
    public partial class _00106_AsignarEmpleadoEmpresa : PlantillaFormulario.FormularioBase
    {
        private readonly IUnidadDeTrabajoRecursosHumanos _uowRecursosHumanos;
        
        public _00106_AsignarEmpleadoEmpresa()
        {
            InitializeComponent();
        }

        public _00106_AsignarEmpleadoEmpresa(IUnidadDeTrabajoRecursosHumanos uowRecursosHumanos)
        {
            InitializeComponent();

            this.Name = "_00106_AsignarEmpleadoEmpresa";
            this.TituloVentana = "Empresa - Empleado";
            this.Titulo = "Asignar Empleado a Empresa";
            this.Leyenda = "Aquí Ud. podrá asignar a un Empleado a una o más Empresas";
            
            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            // Cargar evento de Validacion de Caracteres 
            this.txtBuscarNoAsignados.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtBuscarAsignados.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtBuscarNoAsignados.Enter += new EventHandler(base.control_Enter);
            this.txtBuscarAsignados.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtBuscarNoAsignados.Leave += new EventHandler(base.control_Leave);
            this.txtBuscarAsignados.Leave += new EventHandler(base.control_Leave);

            this._uowRecursosHumanos = uowRecursosHumanos;
            
            this.imgAsignado.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Buscar;
            this.imgNoAsignado.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Buscar;
            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;

            LimpiarDatosFormulario();
        }

        private void _00106_AsignarEmpleadoEmpresa_Load(object sender, EventArgs e)
        {
            PoblarComboBox(this.cmbEmpresa, _uowRecursosHumanos.EmpresaRepositorio.ObtenerTodo(string.Empty).ToList(),
                "RazonSocial", "Id");

            ActualizarDatosAsignados(string.Empty);
            ActualizarDatosNoAsignados(string.Empty);

            if (this.cmbEmpresa.Items.Count > 0) return;

            this.btnVincular.Enabled = false;
            this.btnDesvincular.Enabled = false;
        }

        private void ActualizarDatosNoAsignados(string cadena)
        {   
            var empresaId = this.cmbEmpresa.Items.Count <= 0 ? -1 : Convert.ToInt32(this.cmbEmpresa.SelectedValue.ToString());

            var resultado = _uowRecursosHumanos.EmpleadoEmpresaServicio.MostrarEmpleadosNoAsignados(empresaId, cadena)
                .Select(x => new {
                                     Id = x.Id,
                                     ApyNom = x.ApyNom,
                                     Dni = x.Dni
                                 }).ToList(); ;

            this.dgvNoAsignados.DataSource = resultado;

            this.dgvNoAsignados.Columns["Id"].Visible = false;

            this.dgvNoAsignados.Columns["ApyNom"].Visible = true;
            this.dgvNoAsignados.Columns["ApyNom"].HeaderText = "Empleado";
            this.dgvNoAsignados.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNoAsignados.Columns["ApyNom"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvNoAsignados.Columns["Dni"].Visible = true;
            this.dgvNoAsignados.Columns["Dni"].HeaderText = "DNI";
            this.dgvNoAsignados.Columns["Dni"].Width = 100;
            this.dgvNoAsignados.Columns["Dni"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvNoAsignados.Columns["Dni"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ActualizarDatosAsignados(string cadena)
        {
            var empresaId = this.cmbEmpresa.Items.Count <= 0 ? -1 : Convert.ToInt32(this.cmbEmpresa.SelectedValue);

            var resultado = _uowRecursosHumanos.EmpleadoEmpresaServicio.MostrarEmpleadosAsignados(empresaId, cadena)
                .Select(x => new
                {
                    Id = x.Id,
                    ApyNom = x.ApyNom,
                    Dni = x.Dni
                }).ToList();

            this.dgvAsignados.DataSource = resultado;

            this.dgvAsignados.Columns["Id"].Visible = false;

            this.dgvAsignados.Columns["ApyNom"].Visible = true;
            this.dgvAsignados.Columns["ApyNom"].HeaderText = "Empleado";
            this.dgvAsignados.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAsignados.Columns["ApyNom"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvAsignados.Columns["Dni"].Visible = true;
            this.dgvAsignados.Columns["Dni"].HeaderText = "DNI";
            this.dgvAsignados.Columns["Dni"].Width = 100;
            this.dgvAsignados.Columns["Dni"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvAsignados.Columns["Dni"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnNuevaObraSocial_Click(object sender, EventArgs e)
        {
            var form_NuevaObraSocial = new _00101_ABM_Empresa(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);
            
            if (form_NuevaObraSocial.ShowDialog() != DialogResult.Yes) return;
            
            PoblarComboBox(this.cmbEmpresa, _uowRecursosHumanos.EmpresaRepositorio.ObtenerTodo(string.Empty),
                           "RazonSocial", "Id");
        }

        private void btnBuscarNoAsignados_Click(object sender, EventArgs e)
        {
            ActualizarDatosNoAsignados(this.txtBuscarNoAsignados.Text);
        }

        private void btnBuscarAsignados_Click(object sender, EventArgs e)
        {
            ActualizarDatosAsignados(this.txtBuscarAsignados.Text);
        }

        private void cmbEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cmbEmpresa.Items.Count <= 0) return;

            ActualizarDatosAsignados(string.Empty);
            ActualizarDatosNoAsignados(string.Empty);
        }

        private void btnNoAsignadoTodo_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvNoAsignados, "chkNoAsignado", true);
        }

        private void btnNoAsignadoNada_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvNoAsignados, "chkNoAsignado", false);
        }

        private void btnAsignadoTodo_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvAsignados, "chkAsignado", true);
        }

        private void btnAsignadoNada_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvAsignados, "chkAsignado", false);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).RowCount <= 0) return;

            if (e.RowIndex >= 0)
            {
                ((DataGridView)sender).EndEdit();
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (this.dgvNoAsignados.RowCount <= 0) return;

            var listaEmpleadoNoAsignados = new List<int>();

            for (var i = 0; i < this.dgvNoAsignados.RowCount; i++)
            {
                if(!Convert.ToBoolean(this.dgvNoAsignados["chkNoAsignado", i].Value)) continue;

                listaEmpleadoNoAsignados.Add(Convert.ToInt32(this.dgvNoAsignados["chkNoAsignado", i].Value));
            }

            var empresaId = Convert.ToInt32(this.cmbEmpresa.SelectedValue);

            _uowRecursosHumanos.EmpleadoEmpresaServicio.VincularEmpleadoEmpresa(listaEmpleadoNoAsignados, empresaId);

            _uowRecursosHumanos.Commit();

            ActualizarDatosNoAsignados(string.Empty);
            ActualizarDatosAsignados(string.Empty);
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            if (this.dgvAsignados.RowCount <= 0) return;

            var listaEmpleadoAsignados = new List<int>();

            for (var i = 0; i < this.dgvAsignados.RowCount; i++)
            {
                if (!Convert.ToBoolean(this.dgvAsignados["chkAsignado", i].Value)) continue;

                listaEmpleadoAsignados.Add(Convert.ToInt32(this.dgvAsignados["chkAsignado", i].Value));
            }

            var empresaId = Convert.ToInt32(this.cmbEmpresa.SelectedValue);

            _uowRecursosHumanos.EmpleadoEmpresaServicio.DesvincularEmpleadoEmpresa(listaEmpleadoAsignados, empresaId);

            _uowRecursosHumanos.Commit();

            ActualizarDatosNoAsignados(string.Empty);
            ActualizarDatosAsignados(string.Empty);
        }
    }
}
