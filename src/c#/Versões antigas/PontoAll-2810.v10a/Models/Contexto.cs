using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PontoAll_2810.Models;

namespace PontoAll_2810.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Colaborador> Colaborador { get; set; }

        public DbSet<BancoHoras> BancoHoras { get; set; }

        public DbSet<RegistroPonto> RegistroPonto { get; set; }

        public DbSet<User> User { get; set; }

    }
}