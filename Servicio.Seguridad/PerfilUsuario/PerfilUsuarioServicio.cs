using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;

namespace Servicio.Seguridad.PerfilUsuario
{
    public class PerfilUsuarioServicio : IPerfilUsuarioServicio
    {
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;

        public PerfilUsuarioServicio(IUnidadDeTrabajoSeguridad uowSeguridad)
        {
            this._uowSeguridad = uowSeguridad;
        }
        
        public void VincularUsuarioPerfil(List<int> listaIdUsuario, int perfilId)
        {
            var perfil = _uowSeguridad.PerfilRepositorio.ObtenerPorId(perfilId,"Usuarios");

            foreach (var id in listaIdUsuario)
            {
                var usuario = _uowSeguridad.UsuarioRepositorio.ObtenerPorId(id);

                perfil.Usuarios.Add(usuario);
            }

            _uowSeguridad.Commit();
        }

        public void DesvincularUsuarioPerfil(List<int> listaIdUsuario, int perfilId)
        {
            var perfil = _uowSeguridad.PerfilRepositorio.ObtenerPorId(perfilId, "Usuarios");

            foreach (var id in listaIdUsuario)
            {
                var usuario = _uowSeguridad.UsuarioRepositorio.ObtenerPorId(id);

                perfil.Usuarios.Remove(usuario);
            }

            _uowSeguridad.Commit();
        }

        public IEnumerable<Dominio.Seguridad.Entidades.Usuario> MostrarUsuariosNoAsignados(int perfilId, string cadena)
        {
            var perfil = _uowSeguridad.PerfilRepositorio.ObtenerPorId(perfilId, "Usuarios");

            if(perfil != null)
            {
                var usuarios = _uowSeguridad.UsuarioRepositorio.ObtenerTodo()
                    .Except(perfil.Usuarios).Where(x=>x.NombreUsuario.Contains(cadena));

                return usuarios.ToList();
            }
            else
            {
                return _uowSeguridad.UsuarioRepositorio.ObtenerPorFiltro(x => x.Id.Equals(-1)).ToList();
            }
        }

        public IEnumerable<Dominio.Seguridad.Entidades.Usuario> MostrarUsuariosAsignados(int perfilId, string cadena)
        {
            var perfil = _uowSeguridad.PerfilRepositorio.ObtenerPorId(perfilId, "Usuarios");

            if(perfil != null)
            {
                var resultado = perfil.Usuarios.Where(x=>x.NombreUsuario.Contains(cadena));

                return resultado.ToList();
            }
            else
            {
                return _uowSeguridad.UsuarioRepositorio.ObtenerPorFiltro(x => x.Id.Equals(-1)).ToList();
            }
        }
    }
}
