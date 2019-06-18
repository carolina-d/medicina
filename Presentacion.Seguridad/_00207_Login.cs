using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using Servicio.Seguridad.Seguridad;

namespace Presentacion.Seguridad
{
    public partial class _00207_Login : Form
    {
        private readonly ISeguridadServicio _seguridadServicio;
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;

        public bool TieneAcceso { get; set; }
        public string UsuarioLogin { get; set; }

        private int cantidadDeAccesosFallidos;

        public _00207_Login(ISeguridadServicio seguridadServicio,
            IUnidadDeTrabajoSeguridad uowSeguridad)
        {
            InitializeComponent();

            this.Name = "_00207_Login";
            this.imgSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;

            this._seguridadServicio = seguridadServicio;
            this._uowSeguridad = uowSeguridad;

            cantidadDeAccesosFallidos = 0;
        }

        private void linkSalirSistema_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            TieneAcceso = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (_seguridadServicio.VerificarAccesoAlSistema(this.txtUsuario.Text, this.txtPassword.Text))
            {
                TieneAcceso = true;
                UsuarioLogin = this.txtUsuario.Text;

                if(_seguridadServicio.VerificarSiEstaBloqueado(this.txtUsuario.Text))
                {
                    Mensaje.Mostrar(string.Format("El  Usuario {0} esta Bloqueado. Comuniquese con el Administrador", this.txtUsuario.Text),
                                    Presentacion.PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);
                    TieneAcceso = false;
                }

                this.Close();
            }
            else
            {
                cantidadDeAccesosFallidos++;

                if (cantidadDeAccesosFallidos > 2)
                {
                    var usuarioLogin =
                        _uowSeguridad.UsuarioRepositorio.ObtenerPorFiltro(
                            x => x.NombreUsuario.Equals(this.txtUsuario.Text)).FirstOrDefault();

                    if(usuarioLogin != null)
                    {
                        usuarioLogin.EstaBloqueado = true;

                        _uowSeguridad.UsuarioRepositorio.Modificar(usuarioLogin);
                        _uowSeguridad.Commit();

                        Mensaje.Mostrar(string.Format("El  Usuario {0} se Bloqueara. Comuniquese con el Administrador", this.txtUsuario.Text),
                                    Presentacion.PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);

                        TieneAcceso = false;
                        this.Close();
                    }
                }
                else
                {
                    Mensaje.Mostrar("El Usuario o la Contraseña no son correctos.",
                                    Presentacion.PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);
                    this.txtPassword.Clear();
                    this.txtPassword.Focus();
                }
            }
        }

        private void _00207_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void imgVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtPassword.PasswordChar = char.MinValue;
        }

        private void imgVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            this.txtPassword.PasswordChar = '*';
        }
    }
}
