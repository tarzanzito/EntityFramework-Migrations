using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migration2.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        public int Id { get; set; }

        //[DataType(DataType.Text)]
        [Required(ErrorMessage ="Informe o nome do aluno")]
        [MaxLength(80, ErrorMessage = "O nome deve ter no máximo 80 caracteres")]
        public string? Nome { get; set; }
        
     
        public int? Idade { get; set; }
        
        public bool? Ativo { get; set; }
    }
}
