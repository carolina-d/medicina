using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion.ConsultaPaciente.DTO
{
    public class MedicRecetadoDTO
    {
        public int Id { get; set; }

        public int ConsultaId { get; set; }

        public int VademecumId { get; set; }

        public string NombreMedicamento { get; set; }

        public string Indicaciones { get; set; }
    }
}
