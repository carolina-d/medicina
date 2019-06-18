using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Seguridad.PerfilFormulario
{
    public interface IPerfilFormularioServicio
    {
        void VincularFormularioPerfil(List<int> listaIdFormulario, int perfilId);
        void DesvincularFormularioPerfil(List<int> listaIdFormulario, int perfilId);

        IEnumerable<Dominio.Seguridad.Entidades.Formulario> MostrarFormulariosNoAsignados(int perfilId, string cadena);
        IEnumerable<Dominio.Seguridad.Entidades.Formulario> MostrarFormulariosAsignados(int perfilId, string cadena);
    }
}
