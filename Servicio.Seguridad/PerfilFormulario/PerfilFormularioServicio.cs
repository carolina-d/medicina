using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;

namespace Servicio.Seguridad.PerfilFormulario
{
    public class PerfilFormularioServicio : IPerfilFormularioServicio
    {
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;

        public PerfilFormularioServicio(IUnidadDeTrabajoSeguridad uowSeguridad)
        {
            this._uowSeguridad = uowSeguridad;
        }
        
        public void VincularFormularioPerfil(List<int> listaIdFormulario, int perfilId)
        {
            var perfil = _uowSeguridad.PerfilRepositorio.ObtenerPorId(perfilId,"Formularios");

            foreach (var id in listaIdFormulario)
            {
                var formulario = _uowSeguridad.FormularioRepositorio.ObtenerPorId(id);

                perfil.Formularios.Add(formulario);
            }

            _uowSeguridad.Commit();
        }

        public void DesvincularFormularioPerfil(List<int> listaIdFormulario, int perfilId)
        {
            var perfil = _uowSeguridad.PerfilRepositorio.ObtenerPorId(perfilId, "Formularios");

            foreach (var id in listaIdFormulario)
            {
                var formulario = _uowSeguridad.FormularioRepositorio.ObtenerPorId(id);

                perfil.Formularios.Remove(formulario);
            }

            _uowSeguridad.Commit();
        }

        public IEnumerable<Dominio.Seguridad.Entidades.Formulario> MostrarFormulariosNoAsignados(int perfilId, string cadena)
        {
            var perfil = _uowSeguridad.PerfilRepositorio.ObtenerPorId(perfilId, "Formularios");

            if(perfil != null)
            {
                var Formularios = _uowSeguridad.FormularioRepositorio.ObtenerTodo()
                    .Except(perfil.Formularios).Where(x=>x.DescripcionLarga.Contains(cadena));

                return Formularios.ToList();
            }
            else
            {
                return _uowSeguridad.FormularioRepositorio.ObtenerPorFiltro(x => x.Id.Equals(-1)).ToList();
            }
        }

        public IEnumerable<Dominio.Seguridad.Entidades.Formulario> MostrarFormulariosAsignados(int perfilId, string cadena)
        {
            var perfil = _uowSeguridad.PerfilRepositorio.ObtenerPorId(perfilId, "Formularios");

            if(perfil != null)
            {
                var resultado = perfil.Formularios.Where(x=>x.DescripcionLarga.Contains(cadena));

                return resultado.ToList();
            }
            else
            {
                return _uowSeguridad.FormularioRepositorio.ObtenerPorFiltro(x => x.Id.Equals(-1)).ToList();
            }
        }
    }
}
