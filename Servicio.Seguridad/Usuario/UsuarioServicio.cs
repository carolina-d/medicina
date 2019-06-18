using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Aplicacion.Seguridad.Clases;
using Dominio.CorreoElectronico.Interfaces.UnidadDeTrabajo;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Dominio.RecursosHumanos.Entidades;
using StructureMap;

namespace Servicio.Seguridad.Usuario
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly IUnidadDeTrabajoCorreoElectronico _uowCorreoElectronico;
        private readonly IUnidadDeTrabajoRecursosHumanos _uowRecursosHumanos;
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;

        public UsuarioServicio(IUnidadDeTrabajoCorreoElectronico uowCorreoElectronico,
            IUnidadDeTrabajoRecursosHumanos uowRecursosHumanos,
            IUnidadDeTrabajoSeguridad uowSeguridad)
        {
            this._uowCorreoElectronico = uowCorreoElectronico;
            this._uowRecursosHumanos = uowRecursosHumanos;
            this._uowSeguridad = uowSeguridad;
        }


        public bool CrearUsuario(List<int> empleadoIds)
        {
            var seCreoAlgunUsuario = false;
            
            using (var tran = new TransactionScope())
            {
                try
                {
                    var configCorreo =
                                _uowCorreoElectronico.CorreoElectronicoRepositorio.ObtenerTodo().FirstOrDefault();

                    foreach (var id in empleadoIds)
                    {
                        var empleado = _uowRecursosHumanos.EmpleadoRepositorio.ObtenerPorId(id);

                        var usuario = ObtenerUsuario(empleado);

                        _uowSeguridad.UsuarioRepositorio.Insertar(usuario);

                        _uowSeguridad.Commit();

                        // --------------------------    Correo Electronico   --------------------------- //
                        
                        if (string.IsNullOrEmpty(empleado.Mail))
                        {
                            if (configCorreo != null )
                            {
                                if (configCorreo.EnviarCrearUsuario)
                                {
                                    string mensajeMail = "Hola " + empleado.ApyNom + ":" + Environment.NewLine;

                                    mensajeMail +=
                                        "Le damos la  Bienvenida a X-Medicina. Ahora podrá disfrutar del mejor" +
                                        Environment.NewLine;

                                    mensajeMail += "sistema de Gestión para Consultorios Médicos." + Environment.NewLine;

                                    mensajeMail += "El usuario es: " + usuario.NombreUsuario + " y su contraseña: " +
                                                   Encriptar.DesencriptarCadena(usuario.Password) + Environment.NewLine;

                                    mensajeMail += "Saludos.";

                                    _uowCorreoElectronico.CorreoElectronicoRepositorio.EnviarMail(empleado.Mail,
                                                                                                 "Creacion de Usuario de Sistema",
                                                                                                  mensajeMail);
                                }
                            }
                            else
                            {
                                throw new Exception("No Existe una Configuración de Correo Electronico");
                            }
                        }

                        tran.Complete();

                        seCreoAlgunUsuario = true;
                    }

                }
                catch (Exception ex)
                {
                    tran.Complete();
                    throw new Exception(ex.Message);
                }
            }

            return seCreoAlgunUsuario;
        }

        public void BloquearUsuario(bool estaBloqueado, int usuarioId)
        {
            try
            {
                var usuario = _uowSeguridad.UsuarioRepositorio.ObtenerPorId(usuarioId);
                usuario.EstaBloqueado = estaBloqueado;
                _uowSeguridad.UsuarioRepositorio.Modificar(usuario);
                _uowSeguridad.Commit();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void EliminarUsuario(bool estaEliminado, int usuarioId)
        {
            try
            {
                var usuario = _uowSeguridad.UsuarioRepositorio.ObtenerPorId(usuarioId);
                usuario.EstaEliminado = estaEliminado;
                _uowSeguridad.UsuarioRepositorio.Modificar(usuario);
                _uowSeguridad.Commit();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public void ResetPasswordUsuario(int usuarioId)
        {
            try
            {
                var usuario = _uowSeguridad.UsuarioRepositorio.ObtenerPorId(usuarioId);

                var configSeguridad = _uowSeguridad.ConfiguracionSeguridadRepositorio.ObtenerTodo();

                usuario.Password = Encriptar.EncriptarCadena(configSeguridad.Any() ? configSeguridad.First().PasswordDefecto : Constante.PasswordPorDefecto);
                _uowSeguridad.UsuarioRepositorio.Modificar(usuario);
                _uowSeguridad.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // --------------------------------------------------------------------------------------- //
 
        #region Metodos Privados

        private Dominio.Seguridad.Entidades.Usuario ObtenerUsuario(Empleado empleado)
        {
            var nombre = ObtenerNombreUsuario(empleado.Apellido, empleado.Nombre);

            var usuarioNuevo = ObjectFactory.GetInstance<Dominio.Seguridad.Entidades.Usuario>();
            
            var configSistema = _uowSeguridad.ConfiguracionSeguridadRepositorio.ObtenerTodo();

            usuarioNuevo.EstaBloqueado = false;
            usuarioNuevo.EstaEliminado = false;
            usuarioNuevo.NombreUsuario = nombre;
            usuarioNuevo.Password = Encriptar.EncriptarCadena(configSistema.Any() ? configSistema.First().PasswordDefecto : Constante.PasswordPorDefecto);
            usuarioNuevo.EmpleadoId = empleado.Id;

            return usuarioNuevo;
        }

        private string ObtenerNombreUsuario(string apellido, string nombre)
        {
            var contadorLetras = 1;
            var nombreUsuario = (nombre.Trim().Substring(0, contadorLetras) + apellido.Trim()).ToUpper();

            while (_uowSeguridad.UsuarioRepositorio.ObtenerPorFiltro(x=>x.NombreUsuario.Equals(nombreUsuario)).Any())
            {
                contadorLetras++;
                nombreUsuario = (nombre.Trim().Substring(0, contadorLetras) + apellido.Trim()).ToUpper();
            }

            return nombreUsuario.ToUpper();
        }

        #endregion
    }
}
