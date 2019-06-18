using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio.CorreoElectronico.Entidades;
using Dominio.CorreoElectronico.Interfaces.Repositorios;

namespace Dominio.CorreoElectronico.Interfaces.UnidadDeTrabajo
{
    public interface IUnidadDeTrabajoCorreoElectronico
    {
        ICorreoElectronicoRepositorio<ConfiguracionMail> CorreoElectronicoRepositorio { get; }

        // ---------------------------------------------------------------------//
        void Commit();
        void Disposed();
    }
}
