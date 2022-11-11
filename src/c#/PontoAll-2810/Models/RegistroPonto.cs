using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PontoAll_2810.Models
{
    [Table("RegistroPonto")]
    public class RegistroPonto
    {
        [Key]      
        public int IdRegistroPonto { get; set; }
        [Required]
        public string DataRegistro { get; set; }
        
        public string HoraRegistro { get; set; }
        
        public string LocalizacaoRegistro { get; set; }

        public Perfil Perfil { get; set; }

        public string SomaHora { get; set; }

        [ForeignKey("UsuarioId")]

        public Colaborador Usuario { get; set; }

        //[ForeignKey("MatriculaId")]
        // public Colaborador Matricula { get; set; }

        public string CalculoHoras()
        {

            return ("1");
        }
    }
     
}


public enum TipoPonto
{
    entrada,
    saida
}