using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace UsedBookStore.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdminController : ApiController
    {
        [EnableCors("*", "*", "*")]
        [Route("api/admins")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        [HttpGet]
        [Route("api/admins/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = AdminService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        
        [Route("api/admins/add")]
        [HttpPost]
        public HttpResponseMessage Add(AdminDTO obj)
        {
            var data = AdminService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/admins/update")]
        public HttpResponseMessage Update(AdminDTO obj)
        {
            var data = AdminService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        
        [Route("api/admins/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = AdminService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}

