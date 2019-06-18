using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.RecursosHumanos.Entidades;
using Dominio.Seguridad.Entidades;
using Dominio.Seguridad.Entidades.Vistas;
using Dominio.Seguridad.Interfaces.Repositorios;

namespace Dominio.Seguridad.Interfaces.UnidadDeTrabajo
{
    public interface IUnidadDeTrabajoSeguridad
    {
        // Repositorios
        IRepositorio<Perfil> PerfilRepositorio { get; }
        IRepositorio<Formulario> FormularioRepositorio { get; }
        IUsuarioRepositorio UsuarioRepositorio { get; }
        IRepositorio<ConfiguracionSeguridad> ConfiguracionSeguridadRepositorio { get; }
        IRepositorio<vwAccesoSistema> AccesoSistemaRepositorio { get; }

        // ---------------------------------------------------------------------//
        void Commit();
        void Disposed();
    }
}
