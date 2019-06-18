using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Base.Contextos
{
    public interface IContextoBase
    {
        int ExecuteSqlCommand(string sqlCommand, params object[] param);
    }
}
