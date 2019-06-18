using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Seguridad.Clases
{
    public class Encriptar
    {
        private static string ClaveSecreta = "1MonitorFeo@Tiene@BrilloPerfecto";

        public static string EncriptarCadena(string cadena)
        {
            byte[] cadenaBytes = Encoding.UTF8.GetBytes(cadena);
            byte[] claveBytes = Encoding.UTF8.GetBytes(ClaveSecreta);

            //creamos un objeto de la clase Rijndael
            RijndaelManaged rij = new RijndaelManaged();
            //configuramos para que utilize el medo ECB
            rij.Mode = CipherMode.ECB;
            //configuramos para encriptar en 256bit
            rij.BlockSize = 256;
            //declaramos que si necesitas mas bytes agregue ceros
            rij.Padding = PaddingMode.Zeros;
            //declaramos un encriptador que use mi clave secreta y un vector de inicializacion aleatorio
            ICryptoTransform encriptador;
            encriptador = rij.CreateEncryptor(claveBytes, rij.IV);



            //declaramos un stream de memoria para que guarde los datos encriptados a medida que se van calculando
            MemoryStream memStream = new MemoryStream();

            //declaramos un stream de cibrado para que pueda escribir aqui la cadena a encriptar.
            //Esta clase utiliza el encriptador y el stream de memoria para realizar la encriptacion y para almacenarla
            CryptoStream cifradoStream;
            cifradoStream = new CryptoStream(memStream, encriptador, CryptoStreamMode.Write);

            //escribo los byte a encriptar. a medida que se va escribiendo se va encripdando la candena
            cifradoStream.Write(cadenaBytes, 0, cadenaBytes.Length);

            //aviso que la encriptacion termino
            cifradoStream.FlushFinalBlock();

            //convertimos los datos encripdatos de la memoria sobre el array
            byte[] cipherTextBytes = memStream.ToArray();

            //cierro los datos creados
            memStream.Close();
            cifradoStream.Close();

            //convierto el resultado en base 64 para que sea legible y devuelvo el resultado
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string DesencriptarCadena(string cadena)
        {
            //convierto la candena y la clave en arreglos de bytes para poder usarlas en las funciones de encriptacion
            //en este caso la cadena la convierto usando base 64 que la codificacion usada en el metodo encriptar
            byte[] cadenaBytes = Convert.FromBase64String(cadena);
            byte[] claveBytes = Encoding.UTF8.GetBytes(ClaveSecreta);

            //creo un objeto de la clase rijndael
            RijndaelManaged rij = new RijndaelManaged();
            //configuro que utilize el modo ECB
            rij.Mode = CipherMode.ECB;
            //configuro para que use encriptacion 256 bit
            rij.BlockSize = 256;
            //declaro que si necesita mas bytes agregue ceros
            rij.Padding = PaddingMode.Zeros;
            //declaro un desemcriptador que use mi clave secreado y un vector de inicializacion aleatorio
            ICryptoTransform desencriptador;
            desencriptador = rij.CreateDecryptor(claveBytes, rij.IV);



            //declaro un stream de memoria para que guarde losd datos encriptados
            MemoryStream memStream = new MemoryStream(cadenaBytes);

            //declaro un stream de cifrado para que pueda leer de aqui la cadena a desencriptar. Esta clase utiliza el desencriptador
            //y el stream de memoria para realizar la desencriptacion
            CryptoStream cifradoStream = new CryptoStream(memStream, desencriptador, CryptoStreamMode.Read);

            //declaro el lector para que lea desde el stream de cibrado a medida que vaya leyendo se ira desencriptando
            StreamReader lectorStream = new StreamReader(cifradoStream);

            //leo todos los bytes y los almaceno en una cadena
            string resultado = lectorStream.ReadToEnd();

            //cierro los stream creados
            memStream.Close();
            cifradoStream.Close();
            return resultado;
        }
    }
}
