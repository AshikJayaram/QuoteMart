
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Query
{
    public class InsurerService : IQueryFor<Customer, IList<QuoteDetails>>
    {
        public IList<QuoteDetails> ExecuteQueryWith(Customer customer)
        {
            IList<QuoteDetails> quoteList = new List<QuoteDetails>();
            quoteList.Add(new QuoteDetails
            {
                Benefits = new List<string> { "Benefit1", "Benefit2", "Benefit3" },
                InsurerId = 01,
                Premium = 4240.00,
                ImagePath = "../../Images/logo1.jpg"
            });

           quoteList.Add(new QuoteDetails
            {
                Benefits = new List<string> { "Benefit1", "Benefit2", "Benefit3" },
                InsurerId = 02,
                Premium = 5645.00,
                ImagePath = "../../Images/logo2.jpg"
            });

             quoteList.Add(new QuoteDetails
            {
                Benefits = new List<string> { "Benefit1", "Benefit2", "Benefit3" },
                InsurerId = 03,
                Premium = 4480.60,
                ImagePath = "../../Images/logo3.jpg"
            });
             quoteList.Add(new QuoteDetails
            {
                Benefits = new List<string> { "Benefit1", "Benefit2", "Benefit3" },
                InsurerId = 04,
                Premium = 4480.60,
                ImagePath = "../../Images/logo4.jpg"
            });
            quoteList.Add(new QuoteDetails
            {
                Benefits = new List<string> { "Benefit1", "Benefit2", "Benefit3" },
                InsurerId = 05,
                Premium = 5678.98,
                ImagePath = "../../Images/logo5.jpg"
            });
             quoteList.Add(new QuoteDetails
            {
                Benefits = new List<string> { "Benefit1", "Benefit2", "Benefit3" },
                InsurerId = 06,
                Premium = 4675.87,
                ImagePath = "../../Images/logo6.png"
            });
             quoteList.Add(new QuoteDetails
            {
                Benefits = new List<string> { "Benefit1", "Benefit2", "Benefit3" },
                InsurerId = 07,
                Premium = 6785.63,
                ImagePath = "../../Images/logo7.png"
            });
             quoteList.Add(new QuoteDetails
            {
                Benefits = new List<string> { "Benefit1", "Benefit2", "Benefit3" },
                InsurerId = 08,
                Premium = 3978.99,
                ImagePath = "../../Images/logo8.jpg"
            });
             quoteList.Add(new QuoteDetails
            {
                Benefits = new List<string> { "Benefit1", "Benefit2", "Benefit3" },
                InsurerId = 09,
                Premium = 4299.99,
                ImagePath = "../../Images/logo9.jpg"
            });

             return quoteList;
        }
    }
}
