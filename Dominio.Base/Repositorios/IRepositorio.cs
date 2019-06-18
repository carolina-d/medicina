using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Base.Repositorios
{
    public interface IRepositorio<TEntidad> where TEntidad : Entidad
    {
        /// <summary>
        /// Método para Insertar un Nuevo Registro
        /// </summary>
        /// <param name="entidadNueva">Entidad a Agregar</param>
        void Insertar(TEntidad entidadNueva);

        /// <summary>
        /// Método para Eliminar un Registro
        /// </summary>
        /// <param name="entidadEliminar">Entidad a Eliminar</param>
        void Eliminar(TEntidad entidadEliminar);

        /// <summary>
        /// Método para Eliminar un Registro
        /// </summary>
        /// <param name="entidadEliminar">Identificador de la Entidad a Eliminar</param>
        void Eliminar(int entidadId);

        /// <summary>
        /// Método para Actualizar(Modificar) un Registro
        /// </summary>
        /// <param name="entidadModificar">Entidad a Modificar</param>
        void Modificar(TEntidad entidadModificar);

        /// <summary>
        /// Metodo para Obtener una Entidad por medio de su Identificador
        /// </summary>
        /// <param name="entidadId">Indentificador de la Entidad a Obtener</param>
        /// <returns>Entidad</returns>
        TEntidad ObtenerPorId(int entidadId);

        

        /// <summary>
        /// Metodo para Obtener una Entidad por medio de su Identificador
        /// </summary>
        /// <param name="entidadId">Indentificador de la Entidad a Obtener</param>
        /// <param name="propiedadNavegacion">Propiedades a Incluir</param>
        /// <returns>Entidad</returns>
        TEntidad ObtenerPorId(int entidadId, string propiedadNavegacion = "");

        /// <summary>
        /// Metodo para Obtener una Coleccion/Conjunto de Entidades que cumplan con el filtro
        /// </summary>
        /// <param name="filtro">Filtro de busqueda</param>
        /// <returns>Collecion de Entidades</returns>
        IEnumerable<TEntidad> ObtenerPorFiltro(Expression<Func<TEntidad, bool>> filtro = null);

        /// <summary>
        /// Metodo para Obtener una Coleccion/Conjunto de Entidades que cumplan con el filtro
        /// </summary>
        /// <param name="filtro">Filtro de busqueda</param>
        /// <param name="propiedadNavegacion">Propiedades a Incluir</param>
        /// <returns>Collecion de Entidades</returns>
        IEnumerable<TEntidad> ObtenerPorFiltro(Expression<Func<TEntidad, bool>> filtro = null, string propiedadNavegacion = "");

        /// <summary>
        /// Metodo para Obtener una Collecion de Entidades (Todas BD)
        /// </summary>
        /// <returns>Collecion con todas las Entidades</returns>
        IEnumerable<TEntidad> ObtenerTodo();

        /// <summary>
        /// Metodo para Obtener una Collecion de Entidades (Todas BD)
        /// </summary>
        /// <param name="propiedadNavegacion">Propiedades a Incluir</param>
        /// <returns>Collecion con todas las Entidades</returns>
        IEnumerable<TEntidad> ObtenerTodo(string propiedadNavegacion = "");

        string Validar(TEntidad entidadValidar);

        int Commit();
        void Disposed();
    }
}
