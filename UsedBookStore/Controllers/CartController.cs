using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UsedBookStore.Controllers
{
    public class CartController : ApiController
    {
        [Route("api/cart")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = CartServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpGet]
        [Route("api/cart/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = CartServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Cart/add")]
        [HttpPost]
        public HttpResponseMessage Add(CartDTO obj)
        {
            var data = CartServices.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    
}
}
