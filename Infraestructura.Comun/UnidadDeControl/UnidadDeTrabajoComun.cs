using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.Comun.Interfaces.UnidadDeTrabajo;
using Infraestructura.Base.Repositorios;
using Infraestructura.Comun.Contexto;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoObraSocial;
using Infraestructura.Comun.Servicio.EmpleadoObraSocial;

namespace Infraestructura.Comun.UnidadDeControl
{
    public class UnidadDeTrabajoComun : IUnidadDeTrabajoComun
    {
        private readonly ContextoComun _contexto;
        private bool _dispose;

        public UnidadDeTrabajoComun(ContextoComun contexto)
        {
            _contexto = contexto;
        }

        // Repositorios
        private IRepositorio<Dominio.Comun.Entidades.Sexo> _sexoRepositorio;
        public IRepositorio<Dominio.Comun.Entidades.Sexo> SexoRepositorio
        {
            get { return _sexoRepositorio ?? (_sexoRepositorio = new Repositorio<Dominio.Comun.Entidades.Sexo>(_contexto)); }
        }

        private IRepositorio<Dominio.Comun.Entidades.EstadoCivil> _estadoCivilRepositorio;
        public IRepositorio<Dominio.Comun.Entidades.EstadoCivil> EstadoCivilRepositorio
        {
            get { return _estadoCivilRepositorio ?? (_estadoCivilRepositorio = new Repositorio<Dominio.Comun.Entidades.EstadoCivil>(_contexto)); }
        }

        private IRepositorio<Dominio.Comun.Entidades.ObraSocial> _obraSocialRepositorio;
        public IRepositorio<Dominio.Comun.Entidades.ObraSocial> ObraSocialRepositorio
        {
            get { return _obraSocialRepositorio ?? (_obraSocialRepositorio = new Repositorio<Dominio.Comun.Entidades.ObraSocial>(_contexto)); }
        }

        //  Servicios
        
        private IEmpleadoObraSocialServicio _empleadoObraSocialServicio;
        public IEmpleadoObraSocialServicio EmpleadoObraSocialServicio
        {
            get { return _empleadoObraSocialServicio ?? (_empleadoObraSocialServicio = new EmpleadoObraSocialServicio(_contexto)); }
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
