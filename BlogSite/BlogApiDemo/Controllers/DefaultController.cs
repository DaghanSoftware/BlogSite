using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult WriterList()
        {
            using var c = new Context();
            var value = c.Writers.ToList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult WriterAdd(Writer w)
        {
            using var c = new Context();
            var value = c.Writers.Add(w);
            c.SaveChanges();
            return Ok();
        }
    }
}
