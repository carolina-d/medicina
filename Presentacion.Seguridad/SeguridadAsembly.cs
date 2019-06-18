using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Seguridad
{
    public static class SeguridadAsembly
    {
        public static Assembly SegAssembly { get { return Assembly.GetExecutingAssembly(); } }
    }
}
