using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvc.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [EmailAddress]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string CPF { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Ativo { get; set; }
    }
}