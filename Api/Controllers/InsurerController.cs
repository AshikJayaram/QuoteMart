using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

using Service.Query;
using Service.Models;
using System.Net;
using System.Web.Http;

namespace Api.Controllers
{
    public class InsurerController : ApiController
    {

        private readonly IQueryFor<Customer, IList<QuoteDetails>>  insurerService;
        public InsurerController ()
	{
        insurerService = new InsurerService();        
        }
        public HttpResponseMessage Get([FromUri] Customer customer) {
            var insurerDetails = this.insurerService.ExecuteQueryWith(customer);
            return base.Request.CreateResponse(HttpStatusCode.OK,insurerDetails);
        }

        public HttpResponseMessage Post(Customer customer) {
            return base.Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}