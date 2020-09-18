using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YETIAPITEST3.Models;

namespace YETIAPITEST3.Controllers
{
    public class ValuesController : ApiController
    {
        private YETIEntities db = new YETIEntities();
        [Route("api/person")]
        // GET api/values
        public IEnumerable<Person> GetPerson()
        {
            return db.Person.ToList();
        }
        // GET api/values/5
        public string GetPerson(int id)
        {
            return "value";
        }
        // POST api/values
        public void PostPerson([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void PutPerson(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void DeletePerson(int id)
        {
        }
        [Route("api/event")]
        // GET api/values
        public IEnumerable<Event> GetEvent()
        {
            return db.Event.ToList();
        }

        // GET api/values/5
        public string GetEvent(int id)
        {
            return "value";
        }

        // POST api/values
        public void PostEvent([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void PutEvent(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void DeleteEvent(int id)
        {
        }
    }
}
