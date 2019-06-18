using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.Base.Repositorios;
using Dominio.CorreoElectronico.Entidades;

namespace Dominio.CorreoElectronico.Interfaces.Repositorios
{
    public interface ICorreoElectronicoRepositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : Entidad
    {
        void EnviarMail(string direccionDestino, string asunto, string mensaje);
    }
}
