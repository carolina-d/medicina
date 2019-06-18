using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Seguridad.Usuario
{
    public interface IUsuarioServicio
    {
        /// <summary>
        /// Metodo para crear un Usuario de sistema
        /// </summary>
        /// <param name="empleadoIds">Lista de Identificadores de Empleados que se les crearan un usuario de sistema</param>
        /// <returns>retorna Verdadero si se creo algun usuario caso contrario retorna Falso</returns>
        bool CrearUsuario(List<int> empleadoIds);

        /// <summary>
        /// Metodo para Bloquear/Desbloquear un Usuario
        /// </summary>
        /// <param name="estaBloqueado">True (Bloquea) - False (Desbloquea)</param>
        /// <param name="usuarioId">Identificador del Usuario</param>
        void BloquearUsuario(bool estaBloqueado, int usuarioId);

        /// <summary>
        /// Metodo para Eliminar/Reactivar un Usuario
        /// </summary>
        /// <param name="estaEliminado">True (Elimina) - False (Reactiva)</param>
        /// <param name="usuarioId">Identificador del Usuario</param>
        void EliminarUsuario(bool estaEliminado, int usuarioId);

        /// <summary>
        /// Metodo para Restablecer la contraseña del usuario
        /// </summary>
        /// <param name="usuarioId">Identificador del Usuario</param>
        void ResetPasswordUsuario(int usuarioId);
    }
}
