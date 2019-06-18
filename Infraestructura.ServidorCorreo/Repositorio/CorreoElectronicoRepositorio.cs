using System.Net;
using System.Net.Mail;
using Aplicacion.Seguridad.Clases;
using Dominio.Base;
using Dominio.CorreoElectronico.Entidades;
using Dominio.CorreoElectronico.Interfaces.Repositorios;
using Infraestructura.Base.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura.CorreoElectronico.Clases;
using Infraestructura.ServidorCorreo.Contexto;

namespace Infraestructura.ServidorCorreo.Repositorio
{
    public class CorreoElectronicoRepositorio : Repositorio<ConfiguracionMail>, ICorreoElectronicoRepositorio<ConfiguracionMail>
    {
        private readonly ContextoCorreoElectronico _contexto;

        public CorreoElectronicoRepositorio(ContextoCorreoElectronico contexto)
            : base(contexto)
        {
            this._contexto = contexto;
        }

        public void EnviarMail(string direccionDestino, string asunto, string mensaje)
        {
            var configuracion = _contexto.CONFIGURACIONMAIL.FirstOrDefault();
            
            if(configuracion == null)
                throw new Exception("Por favor realice una Configuracion de Mail");

            var Mensaje = new MailMessage();

            Mensaje.To.Add(new MailAddress(direccionDestino));
            Mensaje.From = new MailAddress(configuracion.DireccionEnvia);
            Mensaje.Subject = asunto;
            Mensaje.Body = mensaje;

            var cliente = new SmtpClient(configuracion.SMTPServer, configuracion.OutPort)
            {
                EnableSsl = configuracion.UsaSSL
            };

            var pass = Encriptar.DesencriptarCadena(configuracion.Password);

            var credentials = new NetworkCredential(configuracion.NombreUsuario, pass, "");
            
            cliente.Credentials = credentials;

            cliente.Send(Mensaje);
        }
    }
}
