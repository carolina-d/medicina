using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Seguridad.Entidades;
using Dominio.Seguridad.Entidades.Vistas;

namespace Infraestructura.Seguridad.Contexto
{
    public interface IContextoSeguridad
    {
        IDbSet<Perfil> PERFIL { get; set; }
        IDbSet<Usuario> USUARIO { get; set; }
        IDbSet<Formulario> FORMULARIO { get; set; }
        IDbSet<VwEmpleadoUsuario> USUARIOEMPLEADOVW { get; set; }
        IDbSet<ConfiguracionSeguridad> CONFIGURACIONSEGURIDAD { get; set; }
        IDbSet<vwAccesoSistema> ACCESOSISTEMA { get; set; }
    }
}
