using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Seguridad.PerfilUsuario
{
    public interface IPerfilUsuarioServicio
    {
        void VincularUsuarioPerfil(List<int> listaIdUsuario, int perfilId);
        void DesvincularUsuarioPerfil(List<int> listaIdUsuario, int perfilId);

        IEnumerable<Dominio.Seguridad.Entidades.Usuario> MostrarUsuariosNoAsignados(int perfilId, string cadena);
        IEnumerable<Dominio.Seguridad.Entidades.Usuario> MostrarUsuariosAsignados(int perfilId, string cadena);
    }
}
