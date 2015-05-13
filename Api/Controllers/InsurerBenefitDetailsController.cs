using Service.Models;
using Service.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class InsurerBenefitDetailsController : ApiController
    {
        private readonly IQueryFor<string, BenefitDetails> insurerBenefitDetailsService;

        public InsurerBenefitDetailsController()
        {
            insurerBenefitDetailsService = new InsurerBenefitDetailsService();
        }
        public HttpResponseMessage Get([FromUri] string insurerId)
        {
            var insurerBenefitDetails = this.insurerBenefitDetailsService.ExecuteQueryWith(insurerId);
            return base.Request.CreateResponse(HttpStatusCode.OK, insurerBenefitDetails);
        }
    }
}
