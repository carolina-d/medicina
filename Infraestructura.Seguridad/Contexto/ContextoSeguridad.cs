using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Seguridad.Entidades;
using Dominio.Seguridad.Entidades.Vistas;
using Infraestructura.Base.Contextos;

namespace Infraestructura.Seguridad.Contexto
{
    public class ContextoSeguridad : ContextoBase, IContextoSeguridad
    {
        private IDbSet<Usuario> _usuario;
        public IDbSet<Usuario> USUARIO
        {
            get { return _usuario ?? (_usuario = Set<Usuario>()); }
            set { }
        }

        private IDbSet<Perfil> _perfil;
        public IDbSet<Perfil> PERFIL
        {
            get { return _perfil ?? (_perfil = Set<Perfil>()); }
            set { }
        }

        private IDbSet<Formulario> _formulario;
        public IDbSet<Formulario> FORMULARIO
        {
            get { return _formulario ?? (_formulario = Set<Formulario>()); }
            set { }
        }

        private IDbSet<VwEmpleadoUsuario> _usuarioEmpleadoVW;
        public IDbSet<VwEmpleadoUsuario> USUARIOEMPLEADOVW
        {
            get { return _usuarioEmpleadoVW ?? (_usuarioEmpleadoVW = Set<VwEmpleadoUsuario>()); }
            set { }
        }

        private IDbSet<vwAccesoSistema> _vwAccesoSistema;
        public IDbSet<vwAccesoSistema> ACCESOSISTEMA
        {
            get { return _vwAccesoSistema ?? (_vwAccesoSistema = Set<vwAccesoSistema>()); }
            set { }
        }

        private IDbSet<ConfiguracionSeguridad> _configuracionSeguridad;
        public IDbSet<ConfiguracionSeguridad> CONFIGURACIONSEGURIDAD
        {
            get { return _configuracionSeguridad ?? (_configuracionSeguridad = Set<ConfiguracionSeguridad>()); }
            set { }
        }

        protected override void OnModelCreating(DbModelBuilder constructor)
        {
            base.OnModelCreating(constructor);

            constructor.Entity<Usuario>()
                .HasMany(x => x.Perfiles)
                .WithMany(y => y.Usuarios)
                .Map(m => m.MapLeftKey("UsuarioId")
                    .MapRightKey("PerfilId")
                    .ToTable("PerfilUsuario"));

            constructor.Entity<Formulario>()
                .HasMany(x => x.Perfiles)
                .WithMany(y => y.Formularios)
                .Map(m => m.MapLeftKey("FormularioId")
                    .MapRightKey("PerfilId")
                    .ToTable("PerfilFormulario"));
        }
    }
}
