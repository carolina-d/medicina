using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Base.Clases;

namespace Presentacion.PlantillaFormulario.Clases
{
    public static class Mensaje
    {
        public static DialogResult Mostrar(Exception exception, string tipoMensaje)
        {

            var dialogResult = DialogResult.None;

            var mensaje = exception.Message;

            switch (tipoMensaje)
            {
                case Constantes.TipoMensaje.Error:
                    dialogResult = MessageBox.Show(mensaje, Constantes.TipoMensaje.Error, MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    break;
                case Constantes.TipoMensaje.Advertencia:
                    dialogResult = MessageBox.Show(mensaje, Constantes.TipoMensaje.Advertencia, MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning);
                    break;
                case Constantes.TipoMensaje.Informacion:
                    dialogResult = MessageBox.Show(mensaje, Constantes.TipoMensaje.Informacion, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    break;
                case Constantes.TipoMensaje.Pregunta:
                    dialogResult = MessageBox.Show(mensaje, Constantes.TipoMensaje.Informacion, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    break;
                default:
                    dialogResult = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    break;
            }

            return dialogResult;
        }

        public static DialogResult Mostrar(string mensajeError, string tipoMensaje)
        {
            var dialogResult = DialogResult.None;

            switch (tipoMensaje)
            {
                case Constantes.TipoMensaje.Error:
                    {
                        dialogResult = MessageBox.Show(mensajeError, Constantes.TipoMensaje.Error, MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        break;
                    }
                case Constantes.TipoMensaje.Advertencia:
                    {
                        dialogResult = MessageBox.Show(mensajeError, Constantes.TipoMensaje.Advertencia, MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Warning);
                        break;
                    }
                case Constantes.TipoMensaje.Informacion:
                    {
                        dialogResult = MessageBox.Show(mensajeError, Constantes.TipoMensaje.Informacion, MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        break;
                    }
                case Constantes.TipoMensaje.Pregunta:
                    {
                        dialogResult = MessageBox.Show(mensajeError, "Atención", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                        break;
                    }
            }

            return dialogResult;
        }
    }
}
