using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class StatusController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        [Route("status")]
        public HttpResponseMessage GetStatus()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { 
                now = DateTime.UtcNow
            });
        }
    }
}
