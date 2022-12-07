using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PontoAll_2810.Models
{
    [Table("BancoHoras")]
    public class BancoHoras
    {
        [Key]
        public int IdBancoHoras { get; set; }
        public string UserId { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSaida { get; set; }

        public DateTime Data { get; set; }

        public string CalculoHoras(string hora, string sHora)
        {

            // trazer data , if faixa de horarios ,  
            var f = hora.Split(':');
            var h = int.Parse(f[0]);
            var m = int.Parse(f[1]);

            var f2 = sHora.Split(':');
            var h2 = int.Parse(f2[0]);
            var m2 = int.Parse(f2[1]);

            var time = new TimeSpan(h, m, 0);
            var time2 = new TimeSpan(h2, m2, 0);

            var somaHora = time.Subtract(time2);

            return (somaHora.ToString());
        }
    }
   
}
