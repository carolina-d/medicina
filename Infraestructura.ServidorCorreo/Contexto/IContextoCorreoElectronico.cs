using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.CorreoElectronico.Entidades;

namespace Infraestructura.ServidorCorreo.Contexto
{
    public interface IContextoCorreoElectronico
    {
        IDbSet<ConfiguracionMail> CONFIGURACIONMAIL { get; set; }
    }
}
