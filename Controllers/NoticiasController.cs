using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiDotNetCore.Context;
using WebApiDotNetCore.Models;	
using System.Data;
using System.Web;
using WebApiDotNetCore.Forms;

namespace WebApiDotNetCore.Controllers
{
    [Route("api/[controller]")]
    public class NoticiasController : Controller
    {   
        /// <summary>
        /// Listar todas as notícias
        /// </summary>
        /// <param name="_db"></param>
        /// <returns>Lista de todas as notícias</returns>
        // GET api/values
        [HttpGet]
        public IEnumerable<Noticia> Get([FromServices]CmsContext _db)
        {
            return _db.Noticias;
        }        

        /// <summary>
        /// Retornar uma notícia de acordo com o Id passado como parâmetro
        /// </summary>        
        /// <param name="id">Id da notícia</param>
        /// <returns>Notícia</returns>
        // GET api/Noticias/5
        [HttpGet("{id}")]
        public Noticia Get([FromServices]CmsContext _db, int id)
        {
            return _db.Noticias.Find(id);            
        }      

        /// <summary>
        /// Cadastrar uma nova notícia
        /// </summary>        
        /// <param name="formularioDeNoticias">Formulário com os dados a serem inseridos</param>
        // POST api/noticias
        [HttpPost]
        public void Post([FromServices]CmsContext _db, [FromForm]FormularioDeNoticias formularioDeNoticias)
        {
            var noticia = new Noticia
            {
               Titulo = formularioDeNoticias.Titulo,
               Conteudo = formularioDeNoticias.Conteudo,
               DataCadastro = DateTime.Now,
               DataPublicacao = formularioDeNoticias.DataPublicacao 
            };
            _db.Noticias.Add(noticia);
        }

        /// <summary>
        /// Editar uma notícia com os dados do formulário de acordo com o id passado como parâmetro
        /// </summary>        
        /// <param name="id">Id da notícia</param>
        /// <param name="formularioDeNoticias">Formulário com dados da notícia a ser editado</param>
        // PUT api/noticias/5
        [HttpPut("{id}")]
        public void Put([FromServices]CmsContext _db, int id, [FromForm]FormularioDeNoticias formularioDeNoticias)
        {
            Noticia noticia = _db.Noticias.Find(id);
            if(noticia == null)
                NotFound();
            
            noticia.Titulo = formularioDeNoticias.Titulo;
            noticia.Conteudo = formularioDeNoticias.Conteudo;            
            noticia.DataPublicacao = formularioDeNoticias.DataPublicacao;

            _db.Noticias.Update(noticia);
        }

        /// <summary>
        /// Remover uma nóticia, caso exista, de acordo com o id da notícia passada como parâmetro
        /// </summary>        
        /// <param name="id">Id da notícia a ser removida</param>
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
