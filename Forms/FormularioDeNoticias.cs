using System;

namespace WebApiDotNetCore.Forms
{
    public class FormularioDeNoticias
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime? DataPublicacao { get; set; }
    }
}