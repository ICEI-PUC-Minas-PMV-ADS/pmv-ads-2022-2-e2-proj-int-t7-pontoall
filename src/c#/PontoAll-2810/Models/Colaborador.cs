using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PontoAll_2810.Models
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Key]

        [Display(Name = "Registro")]
        [Column("Usu_Id")]        
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome!")]
        [Display(Name = "Nome Completo")]
        [Column("Nome")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CPF!")]
        [Display(Name = "CPF")]
        [Column("CPF")]        
        public string CPF { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o E-mail!")]
        [Display(Name = "Email")]
        [Column("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }        

        [Display(Name = "Celular")]
        [Column("Celular")]
        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }

        
        [Display(Name = "CH Contrato")]
        [Column("CargaHoraria")]        
        public CH CargaHoraria { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data de Cadastro!")]
        [Display(Name = "Data do Cadastro")]
        [Column("DataCadastro")]
        [DataType(DataType.Date)]
        public string  DataCadastro { get; set; }

        [Display(Name = "Admissão")]
        [Column("Admissao")]
        [DataType(DataType.Date)]
        public string Admissao { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar a Senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [Column("Senha")]
        public string Senha { get; set; }

        //[Display(Name = "Matricula")]
        //[Column("Matricula")]
        //public string Matricula { get; set; }

        [Display(Name = "Função")]
        public Funcao Funcao { get; set; }

        [Display(Name = "Salario")]
        [Column("Salario")]       
        public string Salario { get; set; }

        [Display(Name = "Desligamento")]
        [Column("Desligamento")]
        [DataType(DataType.Date)]
        public string Desligamento { get; set; }
        // Ajuda no menu
        public ICollection<Colaborador> Usuarios { get; set; }



    }
}
public enum Funcao
{
    Estagiario,
    Desenvolvedor,    
    Analista,   
    Atendente,
    Advogado,
    Supervisor,
    TecnicoInformatica,
    AuxiliarServiçosGerais,
    Proprietario_ResponsavelLegal
}
public enum CH
{    
    CHSemanal_10Hs,
    CHSemanal_20Hs,
    CHSemanal_24Hs,
    CHSemanal_30Hs,
    CHSemanal_36Hs,
    CHSemanal_40Hs,
    CHSemanal_44Hs,
    Frelancer,
    Não_Aplicavel
}
