using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.IoC.StructureMap;
using StructureMap;
using X_Medicina.StructureMap;

namespace X_Medicina
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InicializadorInyectorDependencia();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ObjectFactory.GetInstance<_00001_Principal>().ShowDialog();
        }

        private static void InicializadorInyectorDependencia()
        {
            var ioc = new StructureMapContainer();

            ioc.Configure();

            new StructureMapDependencyResolver(ObjectFactory.Container);
            new StructureMapFilterProvider(ObjectFactory.Container);
        }
    }
}
