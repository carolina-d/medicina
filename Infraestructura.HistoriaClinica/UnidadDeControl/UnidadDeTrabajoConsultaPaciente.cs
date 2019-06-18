using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.ConsultaPaciente.Entidades;
using Dominio.ConsultaPaciente.Interfaces.IUnidadDeTrabajo;
using Infraestructura.Base.Repositorios;
using Infraestructura.ConsultaPaciente.Contexto;

namespace Infraestructura.HistoriaClinica.UnidadDeControl
{
    public class UnidadDeTrabajoConsultaPaciente:IUnidadDeTrabajoConsultaPaciente
    {
         private readonly ContextoConsultaPaciente _contexto;
        private bool _dispose;

        public UnidadDeTrabajoConsultaPaciente(ContextoConsultaPaciente contexto)
        {
            _contexto = contexto;
        }
        private IRepositorio<Dominio.ConsultaPaciente.Entidades.Consulta> _consultaRepositorio;
        public IRepositorio<Consulta> ConsultaRepositorio
        {
            get
            {
                return _consultaRepositorio ?? (_consultaRepositorio = new Repositorio<Dominio.ConsultaPaciente.Entidades.Consulta>(_contexto)); 
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        private IRepositorio<Dominio.ConsultaPaciente.Entidades.EstudioPedido> _estudiosPedidosRepositorio;
        public IRepositorio<EstudioPedido> EstudiosPedidosRepositorio
        {
            get
            {
                return _estudiosPedidosRepositorio ??
                       (_estudiosPedidosRepositorio =
                        new Repositorio<Dominio.ConsultaPaciente.Entidades.EstudioPedido>(_contexto));
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private IRepositorio<Dominio.ConsultaPaciente.Entidades.EstudioRealizado> _estudiosRealizadosRepositorio;
        public IRepositorio<EstudioRealizado> EstudiosRealizadosRepositporio
        {
            get
            {
                return _estudiosRealizadosRepositorio ??
                       (_estudiosRealizadosRepositorio =
                        new Repositorio<Dominio.ConsultaPaciente.Entidades.EstudioRealizado>(_contexto));
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        private IRepositorio<Dominio.ConsultaPaciente.Entidades.HistoriaClinica> _historiaClinicaRepositorio;
        public IRepositorio<Dominio.ConsultaPaciente.Entidades.HistoriaClinica> HistoriaClinicaRepositorio
        {
            get
            {
                return _historiaClinicaRepositorio ?? (_historiaClinicaRepositorio = new Repositorio<Dominio.ConsultaPaciente.Entidades.HistoriaClinica>(_contexto));
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        private IRepositorio<Dominio.ConsultaPaciente.Entidades.Certificado> _certificadoRepositorio;
        public IRepositorio<Certificado> CertificadoRepositorio
        {
            get
            {
                return _certificadoRepositorio ?? (_certificadoRepositorio = new Repositorio<Dominio.ConsultaPaciente.Entidades.Certificado>(_contexto));
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private IRepositorio<Dominio.ConsultaPaciente.Entidades.MedicamentoRecetado> _medicamentosRecetadosRepositorio;
        public IRepositorio<MedicamentoRecetado> MedicamentosRecetadosRepositorio
        {
            get
            {
                return _medicamentosRecetadosRepositorio ?? (_medicamentosRecetadosRepositorio = new Repositorio<Dominio.ConsultaPaciente.Entidades.MedicamentoRecetado>(_contexto));
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private IRepositorio<Dominio.ConsultaPaciente.Entidades.MotivoConsulta> _motivoConsultaRepositorio;
        public IRepositorio<MotivoConsulta> MotivoConsultaRepositorio
        {
            get
            {
                return _motivoConsultaRepositorio ?? (_motivoConsultaRepositorio = new Repositorio<Dominio.ConsultaPaciente.Entidades.MotivoConsulta>(_contexto));
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private IRepositorio<Dominio.ConsultaPaciente.Entidades.Sintoma> _sintomasRepositorio;
        public IRepositorio<Sintoma> SintomasRepositorio
        {
            get
            {
                return _sintomasRepositorio ?? (_sintomasRepositorio = new Repositorio<Dominio.ConsultaPaciente.Entidades.Sintoma>(_contexto));
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private IRepositorio<Dominio.ConsultaPaciente.Entidades.Vademecum> _vademecumRepositorio;
        public IRepositorio<Vademecum> VademecumRepositorio
        {
            get
            {
                return _vademecumRepositorio ?? (_vademecumRepositorio = new Repositorio<Dominio.ConsultaPaciente.Entidades.Vademecum>(_contexto));
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Disposed()
        {
            throw new NotImplementedException();
        }

        

        void IUnidadDeTrabajoConsultaPaciente.Commit()
        {
            throw new NotImplementedException();
        }

        void IUnidadDeTrabajoConsultaPaciente.Disposed()
        {
            throw new NotImplementedException();
        }

        private IRepositorio<Dominio.ConsultaPaciente.Entidades.TipoEstudio> _tipoEstudioRepositorio;
        public IRepositorio<TipoEstudio> TipoEstudioRepositorio
        {
            get
            {
                return _tipoEstudioRepositorio ?? (_tipoEstudioRepositorio = new Repositorio<Dominio.ConsultaPaciente.Entidades.TipoEstudio>(_contexto));
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
