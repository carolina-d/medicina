using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Comun.Entidades;
using Infraestructura.Base.Contextos;

namespace Infraestructura.Comun.Contexto
{
    public class ContextoComun : ContextoBase, IContextoComun
    {
        private IDbSet<Sexo> _sexo;
        public IDbSet<Sexo> SEXO
        {
            get { return _sexo ?? (_sexo = Set<Sexo>()); }
            set { }
        }

        private IDbSet<EstadoCivil> _estadoCivil;
        public IDbSet<EstadoCivil> ESTADOCIVIL
        {
            get { return _estadoCivil ?? (_estadoCivil = Set<EstadoCivil>()); }
            set { }
        }

        private IDbSet<ObraSocial> _obraSocial;
        public IDbSet<ObraSocial> OBRASOCIAL
        {
            get { return _obraSocial ?? (_obraSocial = Set<ObraSocial>()); }
            set { }
        }
    }
}
