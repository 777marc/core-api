using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_api.Classes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            ListManager lm = new ListManager();
            var x = lm.FindItemsByDescription("desc",1,3);
            var name = x.Where(i => i.Id == 1).FirstOrDefault();
            var exp = JsonConvert.SerializeObject(x.ToArray());

            return exp;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
