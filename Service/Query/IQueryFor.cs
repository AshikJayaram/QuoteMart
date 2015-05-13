using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Query
{
    public interface IQueryFor<in t1,out t2>
    {
        t2 ExecuteQueryWith(t1 input);
    }
}
