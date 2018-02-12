using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestWebsite.Controllers
{
    public class ContactController : ApiController
    {
        // GET: Contact
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "Katie" };
        }

        // Get api/values/5
        public string Get(int _id)
        {
            return "value";
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        //PUT api/values/5
        public void Put(int _id, [FromBody]string value)
        {

        }

        //DELETE api/values/5
        public void Delete(int _id)
        {

        }
    }
}
