using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Aplicacion.Seguridad.Clases;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;

namespace Servicio.Seguridad.Seguridad
{
    public class SeguridadServicio : ISeguridadServicio
    {
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;

        public SeguridadServicio(IUnidadDeTrabajoSeguridad uowSeguridad)
        {
            this._uowSeguridad = uowSeguridad;
        }

        public bool VerificarAccesoAlSistema(string usuario, string password)
        {
            if (Constante.UsuarioPorDefecto.Equals(usuario)
                && Constante.PasswordPorDefecto.Equals(password))
                return true;

            var passwordEncriptado = Encriptar.EncriptarCadena(password);

            var existe = _uowSeguridad.UsuarioRepositorio.ObtenerPorFiltro(x => x.NombreUsuario.Equals(usuario)
                                                                   && x.Password.Equals(passwordEncriptado)).Any();

            return existe;
        }

        public bool VerificarSiEstaBloqueado(string usuario)
        {
            var _usuario =
                _uowSeguridad.UsuarioRepositorio.ObtenerPorFiltro(x => x.NombreUsuario.Equals(usuario)).FirstOrDefault();

            if(_usuario != null)
            {
                if (_usuario.EstaBloqueado)
                    return true;
                else
                {
                    return false;
                }
            }

            return false;
        }

        public bool VerificarAccesoFormulario(string usuario,string formulario)
        {
            var resultado = _uowSeguridad.AccesoSistemaRepositorio.ObtenerPorFiltro(x => x.NombreUsuario.Equals(usuario)
                                                                                         &&
                                                                                         x.DescripcionLarga.Equals(
                                                                                             formulario));
            
            return resultado.Any();
        }

        public bool VerificarAccesoFormulario(string formulario)
        {
            if (Constante.UsuarioPorDefecto.Equals(Thread.CurrentPrincipal.Identity.Name))
                return true;

            var tieneAcceso = Thread.CurrentPrincipal.IsInRole(formulario);

            return tieneAcceso;
        }

        public void CargarFormulariosPerfil(string usuarioLogin)
        {
            var listaForms = _uowSeguridad.AccesoSistemaRepositorio.ObtenerPorFiltro(
                    x => x.NombreUsuario.Equals(usuarioLogin))
                    .
                    Select(x => x.DescripcionLarga).ToArray();

            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(usuarioLogin, "Passport"), listaForms);
        }
    }
}
