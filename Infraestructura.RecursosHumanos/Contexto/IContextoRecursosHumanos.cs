using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.RecursosHumanos.Entidades;

namespace Infraestructura.RecursosHumanos.Contexto
{
    public interface IContextoRecursosHumanos
    {
        IDbSet<Empleado> EMPLEADO { get; set; }
        IDbSet<Empresa> EMPRESA { get; set; }
        IDbSet<Especialidad> ESPECIALIDAD { get; set; }
        IDbSet<Consultorio> CONSULTORIO { get; set; }
    }
}
