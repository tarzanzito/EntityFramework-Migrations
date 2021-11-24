using System;
using System.ComponentModel.DataAnnotations;

namespace Migration2.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Informe o nome do aluno")]
        [MaxLength(80, ErrorMessage = "O nome deve ter no máximo 80 caracteres")]
        public string Nome { get; set; }
        public int? Idade { get; set; }
        public bool Ativo { get; set; }
    }
}
