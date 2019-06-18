using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.RecursosHumanos.Entidades;
using Dominio.Seguridad.Entidades;
using Dominio.Seguridad.Entidades.Vistas;

namespace Dominio.Seguridad.Interfaces.Repositorios
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        /// <summary>
        /// Metodo para Obtener todos los empleados con o sin Usuarios
        /// </summary>
        /// <param name="filtro">Filtro de Busqueda</param>
        /// <returns>Lista de Empleados</returns>
        IEnumerable<VwEmpleadoUsuario> ObtenerEmpleadoUsuarioTodo(Expression<Func<VwEmpleadoUsuario, bool>> filtro = null);
    }
}
