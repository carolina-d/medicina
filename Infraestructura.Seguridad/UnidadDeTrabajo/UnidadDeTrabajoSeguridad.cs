using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.Seguridad.Entidades;
using Dominio.Seguridad.Entidades.Vistas;
using Dominio.Seguridad.Interfaces.Repositorios;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Infraestructura.Base.Repositorios;
using Infraestructura.Seguridad.Contexto;
using Infraestructura.Seguridad.Repositorios;

namespace Infraestructura.Seguridad.UnidadDeTrabajo
{
    public class UnidadDeTrabajoSeguridad : IUnidadDeTrabajoSeguridad
    {
        private readonly ContextoSeguridad _contexto;
        private bool _dispose;

        public UnidadDeTrabajoSeguridad(ContextoSeguridad contexto)
        {
            _contexto = contexto;
        }

        // Repositorios
        private IUsuarioRepositorio _usuarioRepositorio;
        public IUsuarioRepositorio UsuarioRepositorio
        {
            get { return _usuarioRepositorio ?? (_usuarioRepositorio = new UsuarioRepositorio(_contexto)); }
        }

        private IRepositorio<Usuario> _usuarioRepositorioGenerico;
        public IRepositorio<Usuario>  UsuarioRepositorioGenerico
        {
            get { return _usuarioRepositorioGenerico ?? (_usuarioRepositorioGenerico = new Repositorio<Usuario>(_contexto)); }
        }

        private IRepositorio<Perfil> _perfilRepositorio;
        public IRepositorio<Perfil> PerfilRepositorio
        {
            get { return _perfilRepositorio ?? (_perfilRepositorio = new Repositorio<Perfil>(_contexto)); }
        }

        private IRepositorio<Formulario> _formularioRepositorio;
        public IRepositorio<Formulario> FormularioRepositorio
        {
            get { return _formularioRepositorio ?? (_formularioRepositorio = new Repositorio<Formulario>(_contexto)); }
        }

        private IRepositorio<ConfiguracionSeguridad> _configuracionSeguridadRepositorio;
        public IRepositorio<ConfiguracionSeguridad> ConfiguracionSeguridadRepositorio
        {
            get { return _configuracionSeguridadRepositorio ?? (_configuracionSeguridadRepositorio = new Repositorio<ConfiguracionSeguridad>(_contexto)); }
        }

        private IRepositorio<vwAccesoSistema> _accesoSistemaRepositorio;
        public IRepositorio<vwAccesoSistema> AccesoSistemaRepositorio
        {
            get { return _accesoSistemaRepositorio ?? (_accesoSistemaRepositorio = new Repositorio<vwAccesoSistema>(_contexto)); }
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public void Disposed()
        {
            _contexto.Dispose();
        }
    }
}
