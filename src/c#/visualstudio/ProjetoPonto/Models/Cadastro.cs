using System.ComponentModel.DataAnnotations;

namespace ProjetoPonto.Models
{
    public class Cadastro
    {
        /*
        id_colaborador int (9) AI PK
        cpf varchar(15)
        nome varchar(150)
        nascimento varchar(20)
        email varchar(60)
        cargo varchar(60)
        senha varchar(10)
        admin varchar(1)
        */

        public int Id_Colaborador { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Informe o CPF do usuário", AllowEmptyStrings = false)]
        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Nascimento { get; set; }

        public string Email { get; set; }

        public string Cargo { get; set; }


        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public string Admin { get; set; }
    }
}