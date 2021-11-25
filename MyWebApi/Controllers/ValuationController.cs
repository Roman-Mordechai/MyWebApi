using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApi.Controllers
{
    [RoutePrefix("vehicle")]
    [ModelValidationActivationFilter]
    public class ValuationController : ApiController
    {
        [HttpPost]
        [Route("valuation")]
        public IHttpActionResult GetValuation([FromBody] ValuationRequestModel model)
        {
            return Ok();
        }
    }
}
