using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using System.Data.Entity;

namespace Infraestructura.ConsultaPaciente.Contexto
{
    public interface IContextoConsultaPaciente
    {
        IDbSet<Dominio.ConsultaPaciente.Entidades.Consulta> CONSULTA { get; set; }
        IDbSet<Dominio.ConsultaPaciente.Entidades.EstudioPedido> ESTUDIOSPEDIDOS { get; set; }
        IDbSet<Dominio.ConsultaPaciente.Entidades.EstudioRealizado> ESTUDIOSREALIZADOS { get; set; }
        IDbSet<Dominio.ConsultaPaciente.Entidades.HistoriaClinica> HISTORIACLINICA { get; set; }
        IDbSet<Dominio.ConsultaPaciente.Entidades.Certificado> CERTIFICADO { get; set; }
        IDbSet<Dominio.ConsultaPaciente.Entidades.MedicamentoRecetado> MEDICAMENTOSRECETADOS { get; set; }
        IDbSet<Dominio.ConsultaPaciente.Entidades.MotivoConsulta> MOTIVOCONSULTA { get; set; }
        IDbSet<Dominio.ConsultaPaciente.Entidades.Sintoma> SINTOMAS { get; set; }
        IDbSet<Dominio.ConsultaPaciente.Entidades.Vademecum> VADEMECUM { get; set; }
        IDbSet<Dominio.ConsultaPaciente.Entidades.TipoEstudio> TIPOESTUDIO { get; set;
       
        } 
    }
}