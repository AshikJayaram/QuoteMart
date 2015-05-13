using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class BenefitDetails
    {
        public double Premium { get; set; }
        public IList<Benefit> Benefits { get; set; }
    }
}
