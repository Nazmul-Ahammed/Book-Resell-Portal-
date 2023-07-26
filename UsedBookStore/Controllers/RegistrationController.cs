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
    public class RegistrationController : ApiController
    {
        [Route("api/users")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = RegistrationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpGet]
        [Route("api/users/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = RegistrationService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/users/add")]
        [HttpPost]
        public HttpResponseMessage Add(RegistrationDTO obj)
        {
            var data = RegistrationService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
