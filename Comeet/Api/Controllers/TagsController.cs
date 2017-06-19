using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class TagsController : ApiController
    {
        private IDbHandler DbHandler;
        TagsController(IDbHandler dbHandler)
        {
            DbHandler = dbHandler;
        }

        // GET: api/Tags
        public IEnumerable<Tag> Get()
        {
            return DbHandler.
        }

        // GET: api/Tags/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tags
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tags/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tags/5
        public void Delete(int id)
        {
        }
    }
}
