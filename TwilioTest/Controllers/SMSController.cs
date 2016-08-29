using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Twilio.Mvc;
using Twilio.TwiML;

namespace TwilioTest.Controllers
{
    public class SMSController : ApiController
    {

        // GET: api/SMS/5
        public HttpResponseMessage Get()
        {
            NameValueCollection data = Request.RequestUri.ParseQueryString();

            dynamic obj = new ExpandoObject();
            obj.Message = "test";
            string content = "test";
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent(content);
            return response;
        }


        // POST: api/SMS
        public HttpResponseMessage Post(TwilioRequest twilioRequest)
        {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
            response.Content = new StringContent(JsonConvert.SerializeObject(twilioRequest));
            return response;
        }


        // PUT: api/SMS/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SMS/5
        public void Delete(int id)
        {
        }
    }
}
