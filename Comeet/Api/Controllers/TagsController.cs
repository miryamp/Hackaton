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
            return DbHandler.GetAllTags();
        }

        // GET: api/Tags/5
        public IEnumerable<Tag> Get(string category)
        {
            return DbHandler.GetAllTagsInCategory(category);
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
