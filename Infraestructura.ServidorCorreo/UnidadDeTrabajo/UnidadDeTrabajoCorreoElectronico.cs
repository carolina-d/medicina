using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.CorreoElectronico.Entidades;
using Dominio.CorreoElectronico.Interfaces.Repositorios;
using Dominio.CorreoElectronico.Interfaces.UnidadDeTrabajo;
using Infraestructura.ServidorCorreo.Contexto;
using Infraestructura.ServidorCorreo.Repositorio;

namespace Infraestructura.ServidorCorreo.UnidadDeTrabajo
{
    public class UnidadDeTrabajoCorreoElectronico : IUnidadDeTrabajoCorreoElectronico
    {
        private readonly ContextoCorreoElectronico _contexto;
        private bool _dispose;

        public UnidadDeTrabajoCorreoElectronico(ContextoCorreoElectronico contexto)
        {
            _contexto = contexto;
        }

        private ICorreoElectronicoRepositorio<ConfiguracionMail> _correoElectronicoRepositorio;
        public ICorreoElectronicoRepositorio<ConfiguracionMail> CorreoElectronicoRepositorio
        {
            get { return _correoElectronicoRepositorio ?? (_correoElectronicoRepositorio = new CorreoElectronicoRepositorio(_contexto)); }
        }

        // Servicios
        
        
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
