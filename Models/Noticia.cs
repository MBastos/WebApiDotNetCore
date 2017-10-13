using System;

namespace WebApiDotNetCore.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataPublicacao { get; set; }
    }
}