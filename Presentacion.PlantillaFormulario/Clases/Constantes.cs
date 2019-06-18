using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.PlantillaFormulario.Clases
{
    public class Constantes
    {
        public const string datoObligatorio = "Dato Obligatorio";

        public static class TipoMensaje
        {
            public const string Error = "Error";
            public const string Advertencia = "Advertencia";
            public const string Informacion = "Información";
            public const string Pregunta = "Pregunta";
        }

        public static class Validacion
        {
            public static void DatoExistente(TextBox txt, ErrorProvider error, string mensajeMostrar)
            {
                error.Icon = Recursos.Informacion2;
                error.SetError(txt, mensajeMostrar);
            }
        }
    }
}
