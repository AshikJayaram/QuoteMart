using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class QuoteDetails
    {
        public int InsurerId { get; set; }
        public double Premium { get; set; }
        public IList<string> Benefits { get; set; }

        public string ImagePath { get; set; }
    }
}
