using RoastedDuck.Entitys.Authorize.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RoastedDuck.Extends;

namespace RoastedDuck.Controllers
{
    public class TestController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage one()
        {
           // var item = request.AuthorizeAutograph();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage testone([FromBody]OrderListRequest request)
        {
           var item= request.AuthorizeAutograph();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

    }
}
