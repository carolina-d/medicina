using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.RecursosHumanos.Entidades;
using Infraestructura.Base.Contextos;
using Infraestructura.Base.Repositorios;

namespace Infraestructura.RecursosHumanos.Contexto
{
    public class ContextoRecursosHumanos : ContextoBase, IContextoRecursosHumanos
    {
        private IDbSet<Empresa> _empresa;
        public IDbSet<Empresa> EMPRESA
        {
            get { return _empresa ?? (_empresa = Set<Empresa>()); }
            set { }
        }

        private IDbSet<Empleado> _empleado;
        public IDbSet<Empleado> EMPLEADO
        {
            get { return _empleado ?? (_empleado = Set<Empleado>()); }
            set { }
        }

        private IDbSet<Especialidad> _especialidad;
        public IDbSet<Especialidad> ESPECIALIDAD
        {
            get { return _especialidad ?? (_especialidad = Set<Especialidad>()); }
            set { }
        }

        private IDbSet<Consultorio> _consultorio;
        public IDbSet<Consultorio> CONSULTORIO
        {
            get { return _consultorio ?? (_consultorio = Set<Consultorio>()); }
            set { }
        }

        protected override void OnModelCreating(DbModelBuilder constructor)
        {
            base.OnModelCreating(constructor);

            constructor.Entity<Empleado>()
                .HasMany(x => x.Empresas)
                .WithMany(y => y.Empleados)
                .Map(m => m.MapLeftKey("EmpleadoId")
                    .MapRightKey("EmpresaId")
                    .ToTable("EmpresaEmpleado"));

        }
    }
}
