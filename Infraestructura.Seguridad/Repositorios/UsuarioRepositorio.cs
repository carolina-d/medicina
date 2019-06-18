using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.Seguridad.Clases;
using Dominio.Seguridad.Entidades;
using Dominio.Seguridad.Entidades.Vistas;
using Dominio.Seguridad.Interfaces.Repositorios;
using Infraestructura.Base.Repositorios;
using Infraestructura.Seguridad.Contexto;
using Dominio.RecursosHumanos.Entidades;

namespace Infraestructura.Seguridad.Repositorios
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        private readonly ContextoSeguridad _contexto;

        public UsuarioRepositorio(ContextoSeguridad contexto)
            : base(contexto)
        {
            this._contexto = contexto;
        }
        
        public IEnumerable<VwEmpleadoUsuario> ObtenerEmpleadoUsuarioTodo(Expression<Func<VwEmpleadoUsuario, bool>> filtro = null)
        {
            var context = ((IObjectContextAdapter)_contexto).ObjectContext;

            var resultado = context.CreateObjectSet<VwEmpleadoUsuario>();

            context.Refresh(RefreshMode.ClientWins, resultado);

            return resultado.ToList();
        }
    }
}
