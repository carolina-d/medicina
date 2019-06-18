using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio.ConsultaPaciente.Entidades;
using Infraestructura.Base;
using Dominio.Base;
using Infraestructura.Base.Contextos;

namespace Infraestructura.ConsultaPaciente.Contexto
{
    public class ContextoConsultaPaciente: ContextoBase,IContextoConsultaPaciente
    {
        private IDbSet<Consulta> _consulta;
        public IDbSet<Consulta> CONSULTA
        {
            get { return _consulta ?? (_consulta = Set<Consulta>()); }
            set
            {
                
            }
        }

        private IDbSet<EstudioPedido> _estudiosPedidos;
        public IDbSet<EstudioPedido> ESTUDIOSPEDIDOS
        {
            get
            {
                return _estudiosPedidos ?? (_estudiosPedidos = Set<EstudioPedido>()); 
            }
            set { }
        }

        private IDbSet<EstudioRealizado> _estudiosRealizados;
        public IDbSet<EstudioRealizado> ESTUDIOSREALIZADOS
        {
            get
            {
                return _estudiosRealizados ?? (_estudiosRealizados = Set<EstudioRealizado>()); 
            }
            set
            {   
            }
        }

        
       
        private IDbSet<Certificado> _certificado;
        public IDbSet<Certificado> CERTIFICADO
        {
            get { return _certificado ?? (_certificado = Set<Certificado>()); }
            set
            {
            }
        }





        private IDbSet<MedicamentoRecetado> _medicamentosRecetados;
        public IDbSet<MedicamentoRecetado> MEDICAMENTOSRECETADOS
        {
            get
            {
                return _medicamentosRecetados ?? (_medicamentosRecetados = Set<MedicamentoRecetado>());
            }
            set
            {
            }
        }
        private IDbSet<MotivoConsulta> _motivoConsulta;
        public IDbSet<MotivoConsulta> MOTIVOCONSULTA
        {
            get
            {
                return _motivoConsulta ?? (_motivoConsulta = Set<MotivoConsulta>());
            }
            set
            {
            }
        }
        private IDbSet<Sintoma> _sintomas;
        public IDbSet<Sintoma> SINTOMAS
        {
            get
            {
                return _sintomas ?? (_sintomas = Set<Sintoma>());
            }
            set
            {
            }
        }
        private IDbSet<Vademecum> _vademecum;
        public IDbSet<Vademecum> VADEMECUM
        {
            get
            {
                return _vademecum ?? (_vademecum = Set<Vademecum>());
            }
            set
            {
            }
        }



        private IDbSet<Dominio.ConsultaPaciente.Entidades.HistoriaClinica> _historiaClinica;
        IDbSet<Dominio.ConsultaPaciente.Entidades.HistoriaClinica> IContextoConsultaPaciente.HISTORIACLINICA
        {
            get
            {
                return _historiaClinica ?? (_historiaClinica = Set<Dominio.ConsultaPaciente.Entidades.HistoriaClinica>());
            }
            set
            {
            }
        }

        private IDbSet<Dominio.ConsultaPaciente.Entidades.TipoEstudio> _tipoEstudio;
        IDbSet<Dominio.ConsultaPaciente.Entidades.TipoEstudio> IContextoConsultaPaciente.TIPOESTUDIO
        {
            get
            {
                return _tipoEstudio ?? (_tipoEstudio = Set<Dominio.ConsultaPaciente.Entidades.TipoEstudio>());
            }
            set
            {
            }
        }
    }
}
