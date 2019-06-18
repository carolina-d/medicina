using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.Comun.Interfaces.UnidadDeTrabajo;
using Dominio.CorreoElectronico.Interfaces.UnidadDeTrabajo;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEmpresa;
using Dominio.Seguridad.Interfaces.Repositorios;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Infraestructura.Base.Repositorios;
using Infraestructura.Comun.Contexto;
using Infraestructura.Comun.UnidadDeControl;
using Infraestructura.DatosPaciente.Contexto;
using Infraestructura.DatosPaciente.UnidadDeTrabajo;
using Infraestructura.RecursosHumanos.Contexto;
using Infraestructura.RecursosHumanos.UnidadDeTrabajo;
using Infraestructura.Seguridad.Contexto;
using Infraestructura.Seguridad.Repositorios;
using Infraestructura.Seguridad.UnidadDeTrabajo;
using Infraestructura.ServidorCorreo.Contexto;
using Infraestructura.ServidorCorreo.UnidadDeTrabajo;
using Infraestructura.Turno.UnidadDeControl;
using Infraestructura.Turnos.Contexto;
using Servicio.DatosPaciente.PlanVacunacion;
using Servicio.Seguridad.Formulario;
using Servicio.Seguridad.PerfilFormulario;
using Servicio.Seguridad.PerfilUsuario;
using Servicio.Seguridad.Seguridad;
using Servicio.Seguridad.Usuario;
using StructureMap;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;
using Dominio.ConsultaPaciente.Interfaces.IUnidadDeTrabajo;
using Infraestructura.HistoriaClinica.UnidadDeControl;
using Dominio.Turnos.Interfaces.IUnidadDeTrabajo;

namespace Aplicacion.IoC.StructureMap
{
    public class StructureMapContainer
    {
        /// <summary>
        /// Configure
        /// </summary>
        public void Configure()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    // Automatically maps interface IXyz to class Xyz
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.ConnectImplementationsToTypesClosing(typeof(IRepositorio<>));
                    scan.Assembly(GetType().Assembly);
                    scan.LookForRegistries();
                });

                x.For(typeof(IRepositorio<>)).Use(typeof(Repositorio<>));
                x.ForSingletonOf<DbContext>().HybridHttpOrThreadLocalScoped();

                // Comun
                x.For<IContextoComun>().Use<ContextoComun>();
                x.For<IUnidadDeTrabajoComun>().Use<UnidadDeTrabajoComun>();

                // Recursos Humanos
                x.For<IContextoRecursosHumanos>().Use<ContextoRecursosHumanos>();
                x.For<IUnidadDeTrabajoRecursosHumanos>().Use<UnidadDeTrabajoRecursosHumanos>();
                x.For<IEmpleadoEmpresaServicio>().Use<EmpleadoEmpresaServicio>();

                // Seguridad
                x.For<IContextoSeguridad>().Use<ContextoSeguridad>();
                x.For<IUnidadDeTrabajoSeguridad>().Use<UnidadDeTrabajoSeguridad>();  
                x.For<IUsuarioRepositorio>().Use<UsuarioRepositorio>();
                x.For<IUsuarioServicio>().Use<UsuarioServicio>();
                x.For<IPerfilUsuarioServicio>().Use<PerfilUsuarioServicio>();
                x.For<IPerfilFormularioServicio>().Use<PerfilFormularioServicio>();
                x.For<IFormularioServicio>().Use<FormularioServicio>();
                x.For<ISeguridadServicio>().Use<SeguridadServicio>();

                // Correro Electronico
                x.For<IContextoCorreoElectronico>().Use<ContextoCorreoElectronico>();
                x.For<IUnidadDeTrabajoCorreoElectronico>().Use<UnidadDeTrabajoCorreoElectronico>();
                
                // Datos del Paciente + Vacunacion
                x.For<IUnidadDeTrabajoDatosPaciente>().Use<UnidadDeTrabajoDatosPaciente>();
                x.For<IContextoDatosPaciente>().Use<ContextoDatosPaciente>();
                x.For<IPlanVacunacionServicio>().Use<PlanVacunacionServicio>();


                x.For<IUnidadDeTrabajoConsultaPaciente>().Use<UnidadDeTrabajoConsultaPaciente>();

                // Turnos
                x.For<IUnidadDeTrabajoTurno>().Use<UnidadDeTrabajoTurnos>();
                x.For<IContextoTurnos>().Use<ContextoTurnos>();
 

                //Ejemplo de como declarar las propiedades en StructureMap
                //x.SetAllProperties(p => p.OfType<Repository<Expedientes>>());
            });
        }
    }
}
