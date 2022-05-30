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

        [HttpGet("{id}")]
        public IActionResult WriterGet(int id)
        {
            using var c = new Context();
            var yazarlar = c.Writers.Find(id);
            if (yazarlar==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(yazarlar);
            }
            
        }

        [HttpDelete("{id}")]
        public IActionResult WriterDelete(int id)
        {
            using var c = new Context();
            var yazar = c.Writers.Find(id);
            if (yazar == null)
            {
                return NotFound();
            }
            else
            {
                c.Writers.Remove(yazar);
                c.SaveChanges();
                return Ok(yazar);
            }
        }

        [HttpPut("{id}")]
        public IActionResult WriterUpdate(Writer w)
        {
            using var c= new Context();
            var yazar = c.Writers.Find(w.WriterID);
            if (yazar==null)
            {
                return NotFound();
            }
            else
            {
                yazar.WriterName = w.WriterName;
                c.Writers.Update(yazar);
                c.SaveChanges();
                return Ok(yazar);
            }
        }
    }
}
