using System.ComponentModel.DataAnnotations;

namespace ProjetoPonto.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Informe o e-mail do usuário", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}