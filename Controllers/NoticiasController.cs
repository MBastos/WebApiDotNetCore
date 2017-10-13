using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiDotNetCore.Context;
using WebApiDotNetCore.Models;	
using System.Data;
using System.Web;

namespace WebApiDotNetCore.Controllers
{
    [Route("api/[controller]")]
    public class NoticiasController : Controller
    {        

        // GET api/values
        [HttpGet]
        public IEnumerable<Noticia> Get([FromServices]CmsContext _db)
        {
            return _db.Noticias;
        }        

        // GET api/Noticias/5
        [HttpGet("{id}")]
        public Noticia Get([FromServices]CmsContext _db, int id)
        {
            return _db.Noticias.Find(id);            
        }      

         // POST api/noticias
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/noticias/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Noticias/5
        [HttpDelete("{id}")]
        public void Delete([FromServices]CmsContext _db, int id)
        {
            Noticia noticia = _db.Noticias.Find(id);
            
            if(noticia == null)
                NotFound();

            _db.Noticias.Remove(noticia);
        }  
    }
}
