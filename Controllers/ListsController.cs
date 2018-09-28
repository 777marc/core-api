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

        [HttpGet("{pageIndex}/{pageSize}")]
        public ActionResult<string> Get(int pageIndex, int pageSize)
        {
            var allItems = _lm.GetAllItems(pageIndex,pageSize);
            var exp = JsonConvert.SerializeObject(allItems.ToArray());
            return Ok(exp);
        }

        [HttpGet("{description}/{pageIndex}/{pageSize}")]
        public ActionResult<string> Get(string description)
        {
            var itemsByDescription = _lm.FindItemsByDescription(description,1,5);
            var exp = JsonConvert.SerializeObject(itemsByDescription.ToArray());
            return Ok(exp);
        }

    }
}
