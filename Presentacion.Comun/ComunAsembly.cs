using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Comun
{
    public static class ComunAsembly
    {
        public static Assembly SegAssembly { get { return Assembly.GetExecutingAssembly(); } }
    }
}
