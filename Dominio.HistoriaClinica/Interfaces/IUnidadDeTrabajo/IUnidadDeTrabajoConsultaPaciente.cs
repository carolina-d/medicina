using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;

namespace Dominio.ConsultaPaciente.Interfaces.IUnidadDeTrabajo
{
    public interface IUnidadDeTrabajoConsultaPaciente
    {
        IRepositorio<Dominio.ConsultaPaciente.Entidades.Consulta> ConsultaRepositorio { get; set; }
        IRepositorio<Dominio.ConsultaPaciente.Entidades.EstudioPedido> EstudiosPedidosRepositorio { get; set; }
        IRepositorio<Dominio.ConsultaPaciente.Entidades.EstudioRealizado> EstudiosRealizadosRepositporio { get; set; }
        IRepositorio<Dominio.ConsultaPaciente.Entidades.HistoriaClinica> HistoriaClinicaRepositorio { get; set; }
        IRepositorio<Dominio.ConsultaPaciente.Entidades.Certificado> CertificadoRepositorio { get; set; }
        IRepositorio<Dominio.ConsultaPaciente.Entidades.MotivoConsulta> MotivoConsultaRepositorio { get; set; }
        IRepositorio<Dominio.ConsultaPaciente.Entidades.Sintoma> SintomasRepositorio { get; set; }
        IRepositorio<Dominio.ConsultaPaciente.Entidades.MedicamentoRecetado> MedicamentosRecetadosRepositorio { get; set; }
        IRepositorio<Dominio.ConsultaPaciente.Entidades.Vademecum> VademecumRepositorio { get; set; }
        IRepositorio<Dominio.ConsultaPaciente.Entidades.TipoEstudio> TipoEstudioRepositorio { get; set; } 
        void Commit();
        void Disposed();
    }
}
