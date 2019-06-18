using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoObraSocial;
using Dominio.Comun.Entidades;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoObraSocial;

namespace Dominio.Comun.Interfaces.UnidadDeTrabajo
{
    public interface IUnidadDeTrabajoComun
    {
        // Repositorios
        IRepositorio<Dominio.Comun.Entidades.EstadoCivil> EstadoCivilRepositorio { get; }
        IRepositorio<Dominio.Comun.Entidades.Sexo> SexoRepositorio { get; }
        IRepositorio<Dominio.Comun.Entidades.ObraSocial> ObraSocialRepositorio { get; }

        // Servicios
        IEmpleadoObraSocialServicio EmpleadoObraSocialServicio { get; }


        // ---------------------------------------------------------------------//
        void Commit();
        void Disposed();
    }
}
