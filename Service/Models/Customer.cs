using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Models
{
    public class Customer : Person
    {       
        public IList<Dependant> Dependants { get; set; }
    }
}