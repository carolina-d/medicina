using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DatosPaciente.DTOs
{
    public class PacienteDTO
    {
        public int Id { get; set; }
        
        public string ApyNom { get; set; }
        
        public string Dni { get; set; }
        
        public DateTime FechaNacimiento { get; set; }

        public string Edad { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string ObraSocial { get; set; }

        public string NumeroAfiliado { get; set; }
    }
}
