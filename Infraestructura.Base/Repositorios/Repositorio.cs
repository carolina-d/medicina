using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Dominio.Base;
using Dominio.Base.Repositorios;

using Infraestructura.Base.Contextos;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Infraestructura.Base.Repositorios
{
    public class Repositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : Entidad
    {
        // Declaracion de Variables
        internal ContextoBase _contexto;
        internal ObjectContext Context;
        internal ObjectSet<TEntidad> DbSet;


        /// <summary>
        /// Constructor del Repositorio Generico
        /// </summary>
        /// <param name="contexto"></param>
        public Repositorio(ContextoBase contexto)
        {
            _contexto = contexto;
        }

        public void Insertar(TEntidad entidadNueva)
        {
            if(entidadNueva == null)
                throw new ArgumentNullException("La Entidad Nueva no puede ser un valor Null");

            _contexto.Set<TEntidad>().Add(entidadNueva);
        }

        public void Eliminar(TEntidad entidadEliminar)
        {
            if (entidadEliminar == null)
                throw new ArgumentNullException("La Entidad a Eliminar no puede ser un valor Null");

            if (_contexto.Entry(entidadEliminar).State == EntityState.Detached)
            {
                _contexto.Set<TEntidad>().Attach(entidadEliminar);
            }

            _contexto.Set<TEntidad>().Remove(entidadEliminar);
        }

        public void Eliminar(int entidadId)
        {
            var entidad = ObtenerPorId(entidadId);

            if(entidad == null)
                throw new ArgumentNullException("La Entidad a Eliminar no puede ser un valor Null");
            
            Eliminar(entidad);
        }

        public void Modificar(TEntidad entidadModificar)
        {
            if(entidadModificar==null)
                throw new ArgumentNullException("La Entidad a Modificar no puede ser un valor null");

            _contexto.Set<TEntidad>().Attach(entidadModificar);
            _contexto.Entry(entidadModificar).State = EntityState.Modified;
        }

        public TEntidad ObtenerPorId(int entidadId)
        {
            var entidad = _contexto.Set<TEntidad>().Find(entidadId);

            if (entidad == null)
                throw new Exception("Error al obtener la Entidad");

            return entidad;
        }

        public TEntidad ObtenerPorId(int entidadId, string propiedadNavegacion = "")
        {
            var resultado = propiedadNavegacion.Split(new[] {','}, 
                StringSplitOptions.RemoveEmptyEntries).Aggregate<string,
                IQueryable<TEntidad>>(_contexto.Set<TEntidad>(), (current, include) => current.Include(include));

            return resultado.FirstOrDefault();
        }

        public IEnumerable<TEntidad> ObtenerPorFiltro(Expression<Func<TEntidad, bool>> filtro = null)
        {
            var context = ((IObjectContextAdapter)_contexto).ObjectContext;
            var resultadoClient = context.CreateObjectSet<TEntidad>();
            context.Refresh(RefreshMode.ClientWins, resultadoClient);

            IQueryable<TEntidad> entidades = resultadoClient;
            
            if (filtro != null)
                entidades = entidades.Where(filtro);

            return entidades.ToList();
        }

        public IEnumerable<TEntidad> ObtenerPorFiltro(Expression<Func<TEntidad, bool>> filtro = null, string propiedadNavegacion = "")
        {
            var context = ((IObjectContextAdapter)_contexto).ObjectContext;
            var resultadoClient = context.CreateObjectSet<TEntidad>();
            context.Refresh(RefreshMode.ClientWins, resultadoClient);

            var resultado = propiedadNavegacion.Split(new[] { ',' },
                StringSplitOptions.RemoveEmptyEntries).Aggregate<string,
                IQueryable<TEntidad>>(resultadoClient, (current, include) => current.Include(include));

            if (filtro != null) resultado = resultado.Where(filtro);

            return resultado.ToList();
        }

        public IEnumerable<TEntidad> ObtenerTodo()
        {
            var context = ((IObjectContextAdapter)_contexto).ObjectContext;
            var resultadoClient = context.CreateObjectSet<TEntidad>();
            context.Refresh(RefreshMode.ClientWins, resultadoClient);

            return resultadoClient.ToList();
         
        }

        public IEnumerable<TEntidad> ObtenerTodo(string propiedadNavegacion = "")
        {
            var context = ((IObjectContextAdapter)_contexto).ObjectContext;
            var resultadoClient = context.CreateObjectSet<TEntidad>();
            context.Refresh(RefreshMode.ClientWins, resultadoClient);

            var resultado = propiedadNavegacion.Split(new[] { ',' },
                StringSplitOptions.RemoveEmptyEntries).Aggregate<string,
                IQueryable<TEntidad>>(resultadoClient, (current, include) => current.Include(include));
            
            return resultado.ToList();
        }
        
        /// <summary>
        /// Metodo para validar la expressiones por medio de Data Annotation
        /// </summary>
        /// <returns>Mensaje de Error</returns>
        public string Validar(TEntidad entidadValidar)
        {
            var mensajeError = string.Empty;
            
            //var erroresDeValidacion = _contexto.GetValidationErrors().Where(x => x.IsValid).SelectMany(x => x.ValidationErrors);
            var erroresDeValidacion = _contexto.Entry(entidadValidar).GetValidationResult().ValidationErrors.ToList();

            foreach (var error in erroresDeValidacion)
            {
                mensajeError += string.Format("Campo {0} - Error: {1}", error.PropertyName, error.ErrorMessage) +
                                Environment.NewLine;
            }

            return mensajeError;
        }

        public int Commit()
        {
            return _contexto.SaveChanges();
        }

        public void Disposed()
        {
            _contexto.Dispose();
        }
    }
}
