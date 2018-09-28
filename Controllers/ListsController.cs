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
        ListManager _lm = new ListManager();

        [HttpGet]
        public ActionResult<string> Get()
        {
            
            var x = _lm.GetAllItems(1,5);
            var name = x.Where(i => i.Id == 1).FirstOrDefault();
            var exp = JsonConvert.SerializeObject(x.ToArray());

            return Ok(exp);
        }

        [HttpGet("{description}")]
        public ActionResult<string> Get(string description)
        {
            var x = _lm.FindItemsByDescription(description,1,5);
            var name = x.Where(i => i.Id == 1).FirstOrDefault();
            var exp = JsonConvert.SerializeObject(x.ToArray());

            return Ok(exp);
        }

    }
}
