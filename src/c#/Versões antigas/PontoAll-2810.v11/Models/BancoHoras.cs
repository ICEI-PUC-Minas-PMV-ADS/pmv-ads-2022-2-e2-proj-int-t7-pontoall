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
        public string Matricula { get; set; }
        public string Ocorrencias { get; set; }
        public string Notificacoes { get; set; }
        public string SaldoBancoHoras { get; set; }
    }
   
}
