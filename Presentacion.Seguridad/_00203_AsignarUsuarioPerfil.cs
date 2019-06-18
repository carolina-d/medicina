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
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Servicio.Seguridad.PerfilUsuario;

namespace Presentacion.Seguridad
{
    public partial class _00203_AsignarUsuarioPerfil : Presentacion.PlantillaFormulario.FormularioBase
    {
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;
        private readonly IPerfilUsuarioServicio _perfilUsuarioServicio;
        
        public _00203_AsignarUsuarioPerfil()
        {
            InitializeComponent();
        }

        public _00203_AsignarUsuarioPerfil(IUnidadDeTrabajoSeguridad uowSeguridad,
            IPerfilUsuarioServicio perfilUsuarioServicio)
        {
            InitializeComponent();

            this.Name = "_00203_AsignarUsuarioPerfil";
            this.TituloVentana = "Perfil - Usuario";
            this.Titulo = "Asignar Usuario a Perfil";
            this.Leyenda = "Aquí Ud. podrá asignar a un Usuario a uno o más Perfiles";
            
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

            this._uowSeguridad = uowSeguridad;
            this._perfilUsuarioServicio = perfilUsuarioServicio;
            
            this.imgAsignado.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Buscar;
            this.imgNoAsignado.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Buscar;
            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;

            LimpiarDatosFormulario();
        }

        private void _00203_AsignarUsuarioPerfil_Load(object sender, EventArgs e)
        {
            PoblarComboBox(this.cmbPerfil, _uowSeguridad.PerfilRepositorio.ObtenerTodo(string.Empty).ToList(),
                "Descripcion", "Id");

            ActualizarDatosAsignados(string.Empty);
            ActualizarDatosNoAsignados(string.Empty);

            if (this.cmbPerfil.Items.Count > 0) return;

            this.btnVincular.Enabled = false;
            this.btnDesvincular.Enabled = false;
        }

        private void ActualizarDatosNoAsignados(string cadena)
        {
            var perfilId = this.cmbPerfil.Items.Count <= 0 ? -1 : Convert.ToInt32(this.cmbPerfil.SelectedValue.ToString());

            var resultado = _perfilUsuarioServicio.MostrarUsuariosNoAsignados(perfilId, cadena)
                .Select(x => new {
                                     Id = x.Id,
                                     NombreUsuario = x.NombreUsuario
                                 }).ToList();

            this.dgvNoAsignados.DataSource = resultado;

            this.dgvNoAsignados.Columns["Id"].Visible = false;

            this.dgvNoAsignados.Columns["NombreUsuario"].Visible = true;
            this.dgvNoAsignados.Columns["NombreUsuario"].HeaderText = "Usuario";
            this.dgvNoAsignados.Columns["NombreUsuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNoAsignados.Columns["NombreUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ActualizarDatosAsignados(string cadena)
        {
            var perfilId = this.cmbPerfil.Items.Count <= 0 ? -1 : Convert.ToInt32(this.cmbPerfil.SelectedValue);

            var resultado = _perfilUsuarioServicio.MostrarUsuariosAsignados(perfilId, cadena)
                .Select(x => new
                {
                    Id = x.Id,
                    NombreUsuario = x.NombreUsuario
                }).ToList();

            this.dgvAsignados.DataSource = resultado;

            this.dgvAsignados.Columns["Id"].Visible = false;

            this.dgvAsignados.Columns["NombreUsuario"].Visible = true;
            this.dgvAsignados.Columns["NombreUsuario"].HeaderText = "Usuario";
            this.dgvAsignados.Columns["NombreUsuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAsignados.Columns["NombreUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnNuevoPerfil_Click(object sender, EventArgs e)
        {
            var form_NuevoPerfil = new _00202_ABM_Perfil(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);
            
            if (form_NuevoPerfil.ShowDialog() != DialogResult.Yes) return;
            
            PoblarComboBox(this.cmbPerfil, _uowSeguridad.PerfilRepositorio.ObtenerTodo(string.Empty),
                           "Descripcion", "Id");
        }

        private void btnBuscarNoAsignados_Click(object sender, EventArgs e)
        {
            ActualizarDatosNoAsignados(this.txtBuscarNoAsignados.Text);
        }

        private void btnBuscarAsignados_Click(object sender, EventArgs e)
        {
            ActualizarDatosAsignados(this.txtBuscarAsignados.Text);
        }

        private void cmbPerfil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cmbPerfil.Items.Count <= 0) return;

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

            var listaUsuarioNoAsignados = new List<int>();

            for (var i = 0; i < this.dgvNoAsignados.RowCount; i++)
            {
                if(!Convert.ToBoolean(this.dgvNoAsignados["chkNoAsignado", i].Value)) continue;

                listaUsuarioNoAsignados.Add(Convert.ToInt32(this.dgvNoAsignados["Id", i].Value));
            }

            var perfilId = Convert.ToInt32(this.cmbPerfil.SelectedValue);
            
            _perfilUsuarioServicio.VincularUsuarioPerfil(listaUsuarioNoAsignados, perfilId);

            ActualizarDatosNoAsignados(string.Empty);
            ActualizarDatosAsignados(string.Empty);
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            if (this.dgvAsignados.RowCount <= 0) return;

            var listaUsuarioAsignados = new List<int>();

            for (var i = 0; i < this.dgvAsignados.RowCount; i++)
            {
                if (!Convert.ToBoolean(this.dgvAsignados["chkAsignado", i].Value)) continue;

                listaUsuarioAsignados.Add(Convert.ToInt32(this.dgvAsignados["Id", i].Value));
            }

            var empresaId = Convert.ToInt32(this.cmbPerfil.SelectedValue);

            _perfilUsuarioServicio.DesvincularUsuarioPerfil(listaUsuarioAsignados, empresaId);

            ActualizarDatosNoAsignados(string.Empty);
            ActualizarDatosAsignados(string.Empty);
        }
    }
}
