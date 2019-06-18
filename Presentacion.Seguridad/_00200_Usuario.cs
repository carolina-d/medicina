using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using Servicio.Seguridad.Usuario;

namespace Presentacion.Seguridad
{
    public partial class _00200_Usuario : Presentacion.PlantillaFormulario.FormularioBase
    {
        private readonly IUnidadDeTrabajoSeguridad _seguridadUoW;
        private readonly IUnidadDeTrabajoRecursosHumanos _recursosHumanosUoW;
        private readonly IUsuarioServicio _usuarioServicio;

        public _00200_Usuario(IUnidadDeTrabajoRecursosHumanos recursosHumanosUoW,
            IUnidadDeTrabajoSeguridad seguridadUoW,
            IUsuarioServicio usuarioServicio)
        {
            InitializeComponent();

            this.Name = "_00200_Usuario";
            this.TituloVentana = "Usuarios";
            this.Titulo = "Usuarios de Sistema";
            this.Leyenda = "Aquí Ud. podrá Crear, Eliminar o Bloquear un Usuario y restablecer su contraseña";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            _seguridadUoW = seguridadUoW;
            _recursosHumanosUoW = recursosHumanosUoW;
            _usuarioServicio = usuarioServicio;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            // Asignacion de Imagenes a los Botones
            AsignarImagenBotones();

            // Cargar evento de Validacion de Caracteres 
            this.txtBuscar.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtBuscar.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtBuscar.Leave += new EventHandler(base.control_Leave);
        }

        private void _00200_Usuario_Load(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void AsignarImagenBotones()
        {
            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;
            this.btnActualizar.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Actualizar;
            this.btnCrear.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Usuario;
            this.imgBuscar.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Buscar;
            this.btnBloquear.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.BloquearUsuario;
            this.btnEliminar.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Eliminar;
            this.btnResetearPassword.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.RestablecerPassword;
            this.btnNuevoEmpleado.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Empleado;
        }

        private void ActualizarDatos(string cadena)
        {
            var resultado =
                _seguridadUoW.UsuarioRepositorio.ObtenerEmpleadoUsuarioTodo(x => x.NombreUsuario.Contains(cadena)
                                                                                 || x.ApyNom.Contains(cadena));

            this.dgvUsuario.DataSource = resultado.ToList();

            FormatearDatosGrilla();

            if (this.dgvUsuario.RowCount <= 0) return;

            this.btnCrear.Enabled = (this.dgvUsuario.RowCount > 0);
            this.btnEliminar.Enabled = (this.dgvUsuario.RowCount > 0);
            this.btnBloquear.Enabled = (this.dgvUsuario.RowCount > 0);
            this.btnResetearPassword.Enabled = (this.dgvUsuario.RowCount > 0);
        }

        private void LimpiarCamposGrilla(DataGridView grilla)
        {
            for (var i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }
        }

        private void FormatearDatosGrilla()
        {
            LimpiarCamposGrilla(this.dgvUsuario);

            this.dgvUsuario.Columns["Item"].Visible = true;
            this.dgvUsuario.Columns["Item"].HeaderText = "Item";
            this.dgvUsuario.Columns["Item"].Width = 40;
            this.dgvUsuario.Columns["Item"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvUsuario.Columns["ApyNom"].Visible = true;
            this.dgvUsuario.Columns["ApyNom"].HeaderText = "Empleado";
            this.dgvUsuario.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvUsuario.Columns["ApyNom"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvUsuario.Columns["NombreUsuario"].Visible = true;
            this.dgvUsuario.Columns["NombreUsuario"].HeaderText = "Usuario";
            this.dgvUsuario.Columns["NombreUsuario"].Width = 200;
            this.dgvUsuario.Columns["NombreUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            this.dgvUsuario.Columns["EstaBloqueado"].Visible = true;
            this.dgvUsuario.Columns["EstaBloqueado"].HeaderText = "Bloqueado";
            this.dgvUsuario.Columns["EstaBloqueado"].Width = 60;
            this.dgvUsuario.Columns["EstaBloqueado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvUsuario.Columns["EstaBloqueado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvUsuario.Columns["EstaEliminado"].Visible = true;
            this.dgvUsuario.Columns["EstaEliminado"].HeaderText = "Eliminado";
            this.dgvUsuario.Columns["EstaEliminado"].Width = 60;
            this.dgvUsuario.Columns["EstaEliminado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvUsuario.Columns["EstaEliminado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(this.txtBuscar.Text);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var seCreoAlgunUsuario = false;

            var listaEmpleadosIDs = new List<int>();

                try
                {
                    listaEmpleadosIDs.Clear();

                    for (var i = 0; i < this.dgvUsuario.RowCount; i++)
                    {
                        if (this.dgvUsuario["NombreUsuario", i].Value.ToString() != Clases.Constante.UsuarioNoAsignado)
                            continue;

                        if (!Convert.ToBoolean(this.dgvUsuario["Item", i].Value)) continue;

                        listaEmpleadosIDs.Add(Convert.ToInt32(this.dgvUsuario["EmpleadoId", i].Value));
                    }

                    if(listaEmpleadosIDs.Any())
                    {
                        seCreoAlgunUsuario = _usuarioServicio.CrearUsuario(listaEmpleadosIDs);
                    }

                    Mensaje.Mostrar(
                        seCreoAlgunUsuario ? "Los Usuarios se Crearon Correctamente" : "No se Creo Usuarios",
                        Constantes.TipoMensaje.Informacion);
                }
                catch (Exception ex)
                {
                    Mensaje.Mostrar("Ocurrio un Error al Crear los Usuarios", Constantes.TipoMensaje.Error);
                }

            if(seCreoAlgunUsuario) ActualizarDatos(string.Empty);
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            var seBloqueoAlgunUsuario = false;

            using (var tran = new TransactionScope())
            {
                try
                {
                    for (var i = 0; i < this.dgvUsuario.RowCount; i++)
                    {
                        if (
                            this.dgvUsuario["NombreUsuario", i].Value.ToString().Equals(
                                Clases.Constante.UsuarioNoAsignado)) continue;

                        if (!Convert.ToBoolean(this.dgvUsuario["Item", i].Value)) continue;

                        var usuarioId = Convert.ToInt32(this.dgvUsuario["UsuarioId", i].Value);
                        
                        var estaBloqueado = this.dgvUsuario["EstaBloqueado", i].Value.ToString().Equals("SI")
                                                ? true
                                                : false;

                        _usuarioServicio.BloquearUsuario(!estaBloqueado, usuarioId);

                        seBloqueoAlgunUsuario = true;
                    }

                    tran.Complete();

                    Mensaje.Mostrar(
                        seBloqueoAlgunUsuario ? "Los Usuarios se Bloquearon Correctamente" : "No se Bloqueo Usuarios",
                        Constantes.TipoMensaje.Informacion);
                }
                catch (Exception ex)
                {
                    tran.Dispose();

                    Mensaje.Mostrar("Ocurrio un Error al Bloquear los Usuarios", Constantes.TipoMensaje.Error);
                }
            }

            if (seBloqueoAlgunUsuario) ActualizarDatos(string.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seEliminoAlgunUsuario = false;

            using (var tran = new TransactionScope())
            {
                try
                {
                    for (var i = 0; i < this.dgvUsuario.RowCount; i++)
                    {
                        if (
                            this.dgvUsuario["NombreUsuario", i].Value.ToString().Equals(
                                Clases.Constante.UsuarioNoAsignado)) continue;

                        if (!Convert.ToBoolean(this.dgvUsuario["Item", i].Value)) continue;

                        var usuarioId = Convert.ToInt32(this.dgvUsuario["UsuarioId", i].Value);

                        var estaEliminado = this.dgvUsuario["EstaEliminado", i].Value.ToString().Equals("SI")
                                                ? true
                                                : false;

                        _usuarioServicio.EliminarUsuario(!estaEliminado, usuarioId);

                        seEliminoAlgunUsuario = true;
                    }

                    tran.Complete();

                    Mensaje.Mostrar(
                        seEliminoAlgunUsuario ? "Los Usuarios se Eliminaron Correctamente" : "No se Elimino Usuarios",
                        Constantes.TipoMensaje.Informacion);
                }
                catch (Exception ex)
                {
                    tran.Dispose();

                    Mensaje.Mostrar("Ocurrio un Error al Elimnar los Usuarios", Constantes.TipoMensaje.Error);
                }
            }

            if (seEliminoAlgunUsuario) ActualizarDatos(string.Empty);
        }

        private void btnResetearPassword_Click(object sender, EventArgs e)
        {
            var contadorItemsSeleccionados = 0;

            for (var i = 0; i < this.dgvUsuario.RowCount; i++)
            {
                if (this.dgvUsuario["NombreUsuario", i].Value.ToString().Equals(
                                Clases.Constante.UsuarioNoAsignado)) continue;

                if (!Convert.ToBoolean(this.dgvUsuario["Item", i].Value)) continue;

                contadorItemsSeleccionados++;

                if (contadorItemsSeleccionados <= 1) continue;

                Mensaje.Mostrar("Debe seleccionar un solo Usuario", Constantes.TipoMensaje.Informacion);
                break;
            }

            if(contadorItemsSeleccionados > 1) return;

            
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).RowCount <= 0) return;

            if (e.RowIndex >= 0)
            {
                ((DataGridView)sender).EndEdit();
            }
        }

        private void btnMarcarTodo_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvUsuario, "Item", true);
        }

        private void btnDesmarcarTodo_Click(object sender, EventArgs e)
        {
            MarcarItems(this.dgvUsuario, "Item", false);
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            var form_NuevoEmpleado = new Presentacion.RecursosHumanos
                ._00105_ABM_Empleado(Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);

            if (form_NuevoEmpleado.ShowDialog() != DialogResult.Yes) return;

            ActualizarDatos(string.Empty);
        }
    }
}
