using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiDotNetCore.Forms
{
    public class FormularioDeNoticias : IValidatableObject
    {
        [Required(ErrorMessage = "Informe o título da notícia.")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "Informe o conteúdo da notícia.")]
        public string Conteudo { get; set; }

        public DateTime? DataPublicacao { get; set; }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrWhiteSpace(Titulo))
            {
                yield return new ValidationResult("Marque ao menos uma disciplina para o aluno cursar.");
            }

            if (String.IsNullOrWhiteSpace(Conteudo))
            {
                yield return new ValidationResult("Informe a turma que deseja enturmar o aluno.");
            }

            if (DateTime.Compare(DataPublicacao.Value,DateTime.Now) <= 0)
            {
                yield return new ValidationResult("A data da publicação deve ser maior ou igual a hoje.");
            }
        }
    }
}