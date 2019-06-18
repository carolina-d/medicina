using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.CorreoElectronico.Entidades.Validacion;

namespace Dominio.CorreoElectronico.Entidades
{
    [Table("ConfiguracionMail")]
    [MetadataType(typeof (IValidacionConfiguracionMail))]
    public class ConfiguracionMail : Entidad
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public bool UsaSSL { get; set; }
        public string SMTPServer { get; set; }
        public int OutPort { get; set; }
        public string DireccionEnvia { get; set; }
        // -------------- Enviar un Mail cuando ----------- //
        public bool EnviarCrearUsuario { get; set; }
        public bool EnviarCumplirPaciente { get; set; }
        public bool EnviarCancelarTurno { get; set; }
    }
}
