using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.PlantillaFormulario.Clases
{
    public class ValidacionDatos
    {
        /// <summary>
        /// Quita ' e = y remplaza por espacio en blanco
        /// </summary>
        /// <param name="_Cadena"> Cadena que le pasamos</param>
        /// <returns>valor modificado</returns>
        public static string VerificarCaracteres(string _Cadena)
        {
            string Valor = _Cadena;
            Valor.Replace("'", " ");
            Valor.Replace("=", " ");
            return Valor;
        }

        /// <summary>
        /// No permitimos letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (Char.IsWhiteSpace(e.KeyChar) || Char.IsUpper(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// No permitimos Numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void NoNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 2)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// No permitimos simbolos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void NoSimbolos(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 2)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// No Permite el click derecho del mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Mouse(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show(": No se puede hacer Clik", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// No se Que mierda hace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="error"></param>
        public static void VerificarNoVacios(object sender, EventArgs e, ErrorProvider error)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                error.SetError(((TextBox)sender), "");
            }
            else
            {
                error.SetError(((TextBox)sender), "Dato Obligatorio");
            }
        }

        /// <summary>
        /// No Permite nada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SinAcceso(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsLetter(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// No permite pegar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void NoPegar(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 22 || Convert.ToInt32(e.KeyChar) == 93)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Impedir Inyeccion en la db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void NoInyeccion(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == ';' || e.KeyChar == '+' || e.KeyChar == '"' || (int)e.KeyChar == 39)
            {
                e.Handled = true;
            }
        }

        public static bool NoGuardarVacio(string Cadena, ErrorProvider error, object sender, int caracteres)
        {
            bool cad = false;
            if (Cadena.Length > caracteres)
            {
                cad = true;
            }
            else
            {
                if (sender is TextBox)
                {
                    error.SetError(((TextBox)sender), "Dato Obligatorio");
                }
            }
            return cad;
        }

        public static void NoBarra(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void VerificarNoVaciosAdelante(object sender)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.TrimStart();
        }

        public static void VerificarNoVacios(object sender, CancelEventArgs e, ErrorProvider error)
        {
            if (sender is TextBox)
            {
                if (!string.IsNullOrEmpty(((TextBox)sender).Text))
                {
                    error.SetError(((TextBox)sender), "");
                }
                else
                {
                    error.SetError(((TextBox)sender), "Dato Obligatorio");
                }
            }

            if (sender is ComboBox)
            {
                if (!string.IsNullOrEmpty(((ComboBox)sender).Text))
                {
                    error.SetError(((ComboBox)sender), "");
                }
                else
                {
                    error.SetError(((ComboBox)sender), "Dato Obligatorio");
                }
            }
        }

        public static bool PwdValidar(string Contrasenia, string NuevaContrasenia)
        {
            bool Estado = false;

            Estado = Contrasenia == NuevaContrasenia ? true : false;

            return Estado;
        }



        public static bool NoGuardarVacio(string Cadena, ErrorProvider error, object sender, int Caracteres, string Mensaje1, string Mensaje2)
        {
            bool cad = false;
            if (Cadena.Length > Caracteres)
            {
                cad = true;
            }
            else
            {
                if (sender is TextBox)
                {
                    error.SetError(((TextBox)sender), Mensaje1 + " " + (Caracteres + 1).ToString() + " " + Mensaje2);
                }
            }
            return cad;
        }


        public static bool VerificarPwdCambiar(int CMaxima, int CMinima, int Mayuscula, int Minuscula, int Numeros, int Especiales, string Pwd)
        {
            bool Estado = false;

            Regex Mayus = new Regex("[A-Z]");
            Regex Minus = new Regex("[a-z]");
            Regex Num = new Regex("[0-9]");
            Regex Esp = new Regex("[^a-zA-Z0-9]");

            if (Pwd.Length >= CMinima && Pwd.Length <= CMaxima)
            {
                if (Mayus.Matches(Pwd).Count >= Mayuscula)
                {
                    if (Minus.Matches(Pwd).Count >= Minuscula)
                    {
                        if (Num.Matches(Pwd).Count >= Numeros)
                        {
                            if (Esp.Matches(Pwd).Count >= Especiales)
                            {
                                Estado = true;
                            }
                        }
                    }
                }
            }
            return Estado;
        }
        public static void VerificarPwdCambiar(int CMaxima, int CMinima, int Mayuscula, int Minuscula, int Numeros, int Especiales, string Pwd, ErrorProvider error, object sender, CancelEventArgs e)
        {
            bool Estado = false;

            Regex Mayus = new Regex("[A-Z]");
            Regex Minus = new Regex("[a-z]");
            Regex Num = new Regex("[0-9]");
            Regex Esp = new Regex("[^a-zA-Z0-9]");

            if (Pwd.Length >= CMinima && Pwd.Length <= CMaxima)
            {
                if (Mayus.Matches(Pwd).Count >= Mayuscula)
                {
                    if (Minus.Matches(Pwd).Count >= Minuscula)
                    {
                        if (Num.Matches(Pwd).Count >= Numeros)
                        {
                            if (Esp.Matches(Pwd).Count >= Especiales)
                            {
                                Estado = true;
                            }
                        }
                    }
                }
            }
            if (!Estado)
            {
                error.SetError(((TextBox)sender), "La Contraseña es Insegura");
            }
        }

        public static bool ContraseniaSegura(string Pwd, ErrorProvider error, object sender)
        {
            bool Estado = false;
            Regex Mayuscula = new Regex("[A-Z]");
            Regex Minuscula = new Regex("[a-z]");
            Regex Numeros = new Regex("[0-9]");
            Regex Especial = new Regex("[^a-zA-Z0-9]");

            if (Pwd.Length >= 6)
            {
                if (Mayuscula.Matches(Pwd).Count >= 1)
                {
                    if (Minuscula.Matches(Pwd).Count >= 1)
                    {
                        if (Numeros.Matches(Pwd).Count >= 1)
                        {
                            if (Especial.Matches(Pwd).Count >= 1)
                            {
                                Estado = true;
                            }
                        }
                    }
                }
            }

            if (!Estado)
            {
                error.SetError(((TextBox)sender), "La Contraseña es Insegura");
            }
            return Estado;
        }

        public static void VerificarMail(object sender, CancelEventArgs e, ErrorProvider error)
        {
            String expresion = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            if (sender is TextBox)
            {
                if (((TextBox)sender).Text.Length > 0)
                    if (Regex.IsMatch(((TextBox)sender).Text, expresion))
                    {
                        if (Regex.Replace(((TextBox)sender).Text, expresion, String.Empty).Length == 0)
                        {
                            error.SetError(((TextBox)sender), string.Empty);
                        }
                        else
                        {
                            error.SetError(((TextBox)sender), "Formato del Mail Incorrecto");
                        }
                    }
                    else
                    {
                        error.SetError(((TextBox)sender), "Formato del Mail Incorrecto");
                    }
                else
                {
                    error.SetError(((TextBox)sender), string.Empty);
                }
            }
        }

        public static void VerificarDni(object sender, CancelEventArgs e, ErrorProvider error)
        {
            if (sender is TextBox)
            {
                if (((TextBox)sender).Text.Length > 0)
                {
                    if (((TextBox)sender).Text.Length < 7)
                    {
                        error.SetError(((TextBox)sender), "Formato del Nro Documento Incorrecto");
                    }
                    else
                    {
                        error.SetError(((TextBox)sender), string.Empty);
                    }
                }
                else
                {
                    error.SetError(((TextBox)sender), string.Empty);
                }
            }
        }


        public static void ContraseniasIguales(string PwdNueva, string PwdReNueva, object sender, ErrorProvider errorProvider, CancelEventArgs e)
        {
            if (PwdNueva != PwdReNueva)
            {
                errorProvider.SetError(((TextBox)sender), "Las Contraseñas no son Iguales");
            }
        }


        public static bool ValidarCuit(string Cuit, ErrorProvider errorProvider, MaskedTextBox maskedTextBox)
        {
            if (Cuit.Length != 11)
            {
                errorProvider.SetError(maskedTextBox, "Formato de CUIT Incorrecto");
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool ValidarEmail(string Email, ErrorProvider errorProvider, TextBox textBox)
        {
            bool Estado = false;
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Email, expresion))
            {
                if (Regex.Replace(Email, expresion, String.Empty).Length == 0)
                {
                    errorProvider.SetError(textBox, string.Empty);
                    Estado = true;
                }
                else
                {
                    errorProvider.SetError(textBox, "Formato del Mail Incorrecto");
                }
            }
            else
            {
                errorProvider.SetError(textBox, "Formato del Mail Incorrecto");
            }
            return Estado;
        }
        
        public static void ValidarEmail(object sender, KeyPressEventArgs e)
        {
            var expresion = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            if (Regex.IsMatch(((TextBox)sender).Text, expresion))
            {
                e.Handled = true;
            }
        }
    }
}
