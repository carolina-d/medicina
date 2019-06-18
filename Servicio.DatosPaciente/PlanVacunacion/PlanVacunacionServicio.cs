using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;

namespace Servicio.DatosPaciente.PlanVacunacion
{
    public class PlanVacunacionServicio : IPlanVacunacionServicio
    {
        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;

        public PlanVacunacionServicio(IUnidadDeTrabajoDatosPaciente uowDatosPaciente)
        {
            this._uowDatosPaciente = uowDatosPaciente;
        }

        public void GenerarPlanDeVacunacionParaUnPaciente(int pacienteId)
        {
            using (var Tran = new TransactionScope())
            {
                try
                {
                    var calendarioVacunacion = _uowDatosPaciente.CalendarioVacunacionRepositorio.ObtenerTodo();

                    var planVacunacionPaciente =
                        _uowDatosPaciente.PlanVacunacionRepositorio.ObtenerPorFiltro(x => x.PacienteId == pacienteId);

                    foreach (var calendario in calendarioVacunacion)
                    {
                        if (planVacunacionPaciente.Any(x => x.CalendarioVacunacionId == calendario.Id)) continue;

                        var paciente = _uowDatosPaciente.PacienteRepositorio.ObtenerPorId(pacienteId);

                        var nuevoPlan = new Dominio.DatosPaciente.Entidades.PlanVacunacion
                                            {
                                                CalendarioVacunacionId = calendario.Id,
                                                PacienteId = paciente.Id,
                                                FechaPlan = CalcularFechaDeAplicacion(calendario.Anio,
                                                                                      calendario.Mes,
                                                                                      calendario.Dia,
                                                                                      paciente.FechaNacimiento),
                                                Estado = false,
                                                FechaReal = null,
                                                Observacion = string.Empty
                                            };

                        _uowDatosPaciente.PlanVacunacionRepositorio.Insertar(nuevoPlan);
                    }

                    _uowDatosPaciente.Commit();

                    Tran.Complete();
                }
                catch (Exception ex)
                {
                    Tran.Dispose();
                    throw new Exception(ex.Message);
                }
            }
        }

        private DateTime CalcularFechaDeAplicacion(int anio, int mes, int dia, DateTime fechaNacimiento)
        {
            var fechaAplicacion = fechaNacimiento.AddYears(anio).AddMonths(mes).AddDays(dia);

            return fechaAplicacion;
        }
    }
}
