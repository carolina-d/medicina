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

namespace Presentacion.RecursosHumanos
{
    public partial class _00109_AsignarEmpleadoEspecialidad : Presentacion.PlantillaFormulario.FormularioBase
    {
        private readonly IUnidadDeTrabajoRecursosHumanos _uowRecursosHumanos;

        public _00109_AsignarEmpleadoEspecialidad()
        {
            InitializeComponent();
        }

        public _00109_AsignarEmpleadoEspecialidad(IUnidadDeTrabajoRecursosHumanos uowRecursosHumanos)
        {
            InitializeComponent();

            this.Name = "_00109_AsignarEmpleadoEspecialidad";
            this.TituloVentana = "Especialidad - Empleado";
            this.Titulo = "Asignar Empleado a Especialidad";
            this.Leyenda = "Aquí Ud. podrá asignar a un Empleado a una Especialidad";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._uowRecursosHumanos = uowRecursosHumanos;

            this.imgAsignado.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Buscar;
            this.imgNoAsignado.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Buscar;
            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;

            LimpiarDatosFormulario();
        }

        private void _00109_AsignarEmpleadoEspecialidad_Load(object sender, EventArgs e)
        {
            PoblarComboBox(this.cmbEmpresa, _uowRecursosHumanos.EspecialidadRepositorio.ObtenerTodo(string.Empty).ToList(), "Descripcion", "Id");
            ActualizarDatosAsignados(string.Empty);
            ActualizarDatosNoAsignados(string.Empty);

        }

        private void ActualizarDatosAsignados(string cadena)
        {
            var especialidadId = this.cmbEmpresa.Items.Count <= 0 ? -1 : Convert.ToInt32(this.cmbEmpresa.SelectedValue.ToString());

            var resultado = _uowRecursosHumanos.EmpleadoEspecialidadServicio.MostrarEmpleadosAsignados(especialidadId, cadena)
                .Select(x => new
                {
                    Id = x.Id,
                    ApyNom = x.ApyNom,
                    Dni = x.Dni,

                }).ToList();

            this.dgvAsignados.DataSource = resultado;

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

        private void ActualizarDatosNoAsignados(string cadena)
        {
            var especialidadId = this.cmbEmpresa.Items.Count <= 0 ? -1 : Convert.ToInt32(this.cmbEmpresa.SelectedValue.ToString());

            var resultado = _uowRecursosHumanos.EmpleadoEspecialidadServicio.MostrarEmpleadosNoAsignados(especialidadId, cadena)
                .Select(x => new
                {
                    Id = x.Id,
                    ApyNom = x.ApyNom,
                    Dni = x.Dni,
                }).ToList(); ;

            this.dgvNoAsignados.DataSource = resultado;

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

        private void btnBuscarAsignados_Click(object sender, EventArgs e)
        {
            ActualizarDatosAsignados(this.txtBuscarAsignados.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarDatosNoAsignados(this.txtBuscarNoAsignados.Text);
        }

        private void cmbEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cmbEmpresa.Items.Count <= 0) return;

            ActualizarDatosNoAsignados(string.Empty);
            ActualizarDatosAsignados(string.Empty);

        }

        private void btnNoAsignadoTodo_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvNoAsignados, "chkNoAsignado", true);
        }

        private void btnAsignadoTodo_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvAsignados, "chkAsignado", true);
        }

        private void btnAsignadoNada_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvAsignados, "chkAsignado", false);
        }

        private void btnNoAsignadoNada_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvNoAsignados, "chkNoAsignado", false);
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

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            if (this.dgvAsignados.RowCount <= 0) return;

            var listaEmpleadoAsignados = new List<int>();

            for (var i = 0; i < this.dgvAsignados.RowCount; i++)
            {
                if (!Convert.ToBoolean(this.dgvAsignados["chkAsignado", i].Value)) continue;

                listaEmpleadoAsignados.Add(Convert.ToInt32(this.dgvAsignados["chkAsignado", i].Value));
            }

            var especialidadId = Convert.ToInt32(this.cmbEmpresa.SelectedValue);

            _uowRecursosHumanos.EmpleadoEspecialidadServicio.DesvincularEmpleadoEspecialidad(listaEmpleadoAsignados, especialidadId);
            _uowRecursosHumanos.Commit();

            ActualizarDatosNoAsignados(string.Empty);
            ActualizarDatosAsignados(string.Empty);
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            if (this.dgvAsignados.RowCount <= 0) return;

            var listaEmpeadoNoAsignados = new List<int>();

            for (var i = 0; i < this.dgvNoAsignados.RowCount; i++)
            {
                if (!Convert.ToBoolean(this.dgvNoAsignados["chkNoAsignado", i].Value)) continue;
                listaEmpeadoNoAsignados.Add(Convert.ToInt32(this.dgvNoAsignados["chkNoAsignado", i].Value));
            }

            var especialidadId = Convert.ToInt32(this.cmbEmpresa.SelectedValue);

            _uowRecursosHumanos.EmpleadoEspecialidadServicio.VincularEmpleadoEspecialidad(listaEmpeadoNoAsignados, especialidadId);
            _uowRecursosHumanos.Commit();

            ActualizarDatosAsignados(string.Empty);
            ActualizarDatosNoAsignados(string.Empty);
        } 
    }
}
