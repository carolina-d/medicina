using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.Seguridad.DTOs;

namespace Servicio.Seguridad.Formulario
{
    public interface IFormularioServicio
    {
        void CargarFormularios(ref List<FormularioDTO> _formAsembly);
        void ActualizarBaseDeDatos(List<FormularioDTO> _listaFormularios);
    }
}
