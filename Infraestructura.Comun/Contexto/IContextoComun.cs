using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Comun.Contexto
{
    public interface IContextoComun
    {
        IDbSet<Dominio.Comun.Entidades.Sexo> SEXO { get; set; }
        IDbSet<Dominio.Comun.Entidades.EstadoCivil> ESTADOCIVIL { get; set; }
        IDbSet<Dominio.Comun.Entidades.ObraSocial> OBRASOCIAL { get; set; }
         
    }
}
