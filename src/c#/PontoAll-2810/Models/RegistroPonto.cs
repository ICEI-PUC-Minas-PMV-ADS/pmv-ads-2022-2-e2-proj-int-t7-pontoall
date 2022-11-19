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

        //[ForeignKey("UsuarioId")]

        public int UserId { get; set; }

        //[ForeignKey("MatriculaId")]
        // public Colaborador Matricula { get; set; }

        public string CalculoHoras(string hora, string sHora)
        {
            
            // trazer data , if faixa de horarios ,  
            var f = hora.Split(':');
            var h = int.Parse(f[0]);
            var m = int.Parse(f[1]);

            var f2 = sHora.Split(':');
            var h2 = int.Parse(f2[0]);
            var m2 = int.Parse(f2[1]);

            var time = new TimeSpan(h,m,0);
            var time2 = new TimeSpan(h2, m2, 0);

            var somaHora = time.Subtract(time2); 

            return (somaHora.ToString());
        }
    }
     
}


public enum TipoPonto
{
    entrada,
    saida
}