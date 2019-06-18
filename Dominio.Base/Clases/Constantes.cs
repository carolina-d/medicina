using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Base.Clases
{
    public static class Constantes
    {
        public static class Sexo
        {
            public const string Masculino = "Masculino";
            public const int CodigoMasculino = 1;
            
            public const string Femenino = "Femenino";
            public const int CodigoFemenino = 2;

            public const string SinEspecificar = "Sin Especificar";
            public const int CodigoSinEspecificar = 3;

            public static List<string> ListaSexos = new List<string>
            {
                Masculino,
                Femenino,
                SinEspecificar
            };

            public static Dictionary<int, string> TipoSexos = new Dictionary<int, string>()
            {
                {CodigoMasculino, Masculino},
                {CodigoFemenino, Femenino},
                {CodigoSinEspecificar, SinEspecificar}
            };
        }

        public static class EstadoCivil
        {
            public const string Soltero = "Soltero/a";
            public const int CodigoSoltero = 1;

            public const string Casado = "Casado/a";
            public const int CodigoCasado = 2;

            public const string Divorciado = "Divorciado/a";
            public const int CodigoDivorciado = 3;

            public const string Separado = "Separado";
            public const int CodigoSeparado = 4;

            public const string Viudo = "Viudo/a";
            public const int CodigoViudo = 5;

            public const string UniónMaritalHecho = "Unión marital de hecho";
            public const int CodigoUniónMaritalHecho = 6;

            public static List<string> ListaEstadosCiviles = new List<string>
            {
                Soltero,
                Casado,
                Divorciado,
                Separado,
                Viudo,
                UniónMaritalHecho
            };

            public static Dictionary<int, string> TipoEstadosCiviles = new Dictionary<int, string>()
            {
                {CodigoSoltero, Soltero},
                {CodigoCasado, Casado},
                {CodigoDivorciado, Divorciado},
                {CodigoSeparado, Separado},
                {CodigoViudo, Viudo},
                {CodigoUniónMaritalHecho, UniónMaritalHecho}
            };
        }

        public static class Especialidad
        {
            public static string Administrativo = "Administrativo/a";
            public static int CodigoAdministrativo = 1;

            public static string Pediatria = "Pediatria";
            public static int CodigoPediatria = 2;

            public static string Traumatologia = "Traumatología";
            public static int CodigoTraumatologia = 3;

            public static string Urologia = "Urología";
            public static int CodigoUrologia = 4;

            public static string ClinicaGeneral = "Clínica General";
            public static int CodigoClinicaGeneral = 5;

            public static string Ginecologia = "Ginecología";
            public static int CodigoGinecologia = 6;

            public static List<string> ListaEspecialidades = new List<string>
            {
                Administrativo,
                Pediatria,
                Traumatologia,
                Urologia,
                ClinicaGeneral,
                Ginecologia
            };

            public static Dictionary<int, string> TipoEspecialidades = new Dictionary<int, string>()
            {
                {CodigoAdministrativo, Administrativo},
                {CodigoPediatria, Pediatria},
                {CodigoTraumatologia, Traumatologia},
                {CodigoUrologia, Urologia},
                {CodigoClinicaGeneral, ClinicaGeneral},
                {CodigoGinecologia, Ginecologia}
            };
        }
    }
}
