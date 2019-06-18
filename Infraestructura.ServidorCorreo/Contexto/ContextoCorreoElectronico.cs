using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.CorreoElectronico.Entidades;
using Infraestructura.Base.Contextos;

namespace Infraestructura.ServidorCorreo.Contexto
{
    public class ContextoCorreoElectronico : ContextoBase ,IContextoCorreoElectronico
    {
        private IDbSet<ConfiguracionMail> _configuracionMail;
        public IDbSet<ConfiguracionMail> CONFIGURACIONMAIL
        {
            get { return _configuracionMail ?? (_configuracionMail = Set<ConfiguracionMail>()); }
            set { }
        }
    }
}
