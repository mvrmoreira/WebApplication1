using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SalesController : ApiController
    {
        [Route("sales")]
        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage CreateSale(CreateSaleRequest request)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return new HttpResponseMessage(HttpStatusCode.Accepted);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
