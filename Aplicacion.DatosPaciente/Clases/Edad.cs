using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DatosPaciente.Clases
{
    public static class Edad
    {
        public static string Calcular(DateTime dInicio, DateTime dFin)
        {
            int Dias = dFin.Day - dInicio.Day;

            int Meses = dFin.Month - dInicio.Month;

            int Anio = dFin.Year - dInicio.Year;

            if (Dias < 0)
            {
                int DiasMes = DateTime.DaysInMonth(dInicio.Year, dInicio.Month);

                Dias = (DiasMes - dInicio.Day) + dFin.Day;

                Meses = Meses - 1;
            }


            if (Meses < 0)
            {
                Meses = 12 + Meses;

                Anio = Anio - 1;
            }

            return string.Format("{0} Años {1} {2} {3} {4}", Anio, Meses, (Meses > 1 ? "Mes" : "Mes"),
                                 Dias, (Dias > 1 ? "Días" : "Dia"));
        }
    }
}
