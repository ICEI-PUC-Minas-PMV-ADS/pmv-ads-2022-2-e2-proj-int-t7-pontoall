using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PontoAll_2810.Models
{
    public class User
    {
        [Key]
        [Display(Name = "Login")]
        [Column("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Infomar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Infomar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        //[Required(ErrorMessage = "Obrigatório Infomar a perfil!")]
        public Perfil Perfil { get; set; }

        [Display(Name = "Colaborador")]
       // [Required(ErrorMessage = "Obrigatório Infomar o usuário!")]
        public int UsuarioId { get; set; }
                
        [ForeignKey("UsuarioId")]

        public Colaborador Usuario {get; set;}

        [ForeignKey("MatriculaId")]
        public Colaborador Matricula { get; set; }


    }
    public enum Perfil
    {
        Admin,
        Operador
    }
}
