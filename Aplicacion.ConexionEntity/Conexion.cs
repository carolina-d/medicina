using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.ConexionEntity
{
    public static class Conexion
    {
        //private static string _servidor = @".\SQLEXPRESS";
        //private static string _baseDatos = @"ConsultorioDB";

        private static string _servidor = ConfiguracionConexion.Default.Servidor;
        private static string _baseDatos = ConfiguracionConexion.Default.BaseDatos;

        public static string NombreServidor
        {
            set { _servidor = value; }
        }

        public static string NombreBaseDatos
        {
            set { _baseDatos = value; }
        }

        public static string CadenaConexion
        {
            //get { return @"Data Source=" + _servidor + ";Initial Catalog=" + _baseDatos + ";User Id=cad;Password=cad;"; }
            get { return @"Data Source=" + _servidor + ";Initial Catalog=" + _baseDatos + ";Integrated Security=true"; }
        }
    }
}
