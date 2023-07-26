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
    public class TrackOrderController : ApiController
    {
        [Route("api/trackOrders")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = TrackOrderServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpGet]
        [Route("api/trackOrders/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = TrackOrderServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/trackOrders/add")]
        [HttpPost]
        public HttpResponseMessage Add(TrackOrderDTO obj)
        {
            var data = TrackOrderServices.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/trackOrders/update")]
        public HttpResponseMessage Update(TrackOrderDTO obj)
        {
            var data = TrackOrderServices.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/trackOrders/delete")]
        public HttpResponseMessage Delete(int id)
        {
            var data = TrackOrderServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
