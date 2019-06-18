using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Seguridad.Seguridad
{
    public interface ISeguridadServicio
    {
        bool VerificarAccesoAlSistema(string usuario, string password);
        bool VerificarSiEstaBloqueado(string usuario);
        bool VerificarAccesoFormulario(string usuario, string formulario);
        bool VerificarAccesoFormulario(string formulario);

        void CargarFormulariosPerfil(string usuarioLogin);
    }
}
