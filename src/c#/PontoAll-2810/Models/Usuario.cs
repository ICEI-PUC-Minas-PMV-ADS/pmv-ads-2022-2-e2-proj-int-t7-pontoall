﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PontoAll_2810.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Usu_Id")]
        [Column("Usu_Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Column("CPF")]
        public string CPF { get; set; }
               

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }

        [Display(Name = "Celular")]
        [Column("Celular")]
        public string Celular { get; set; }

        [Display(Name = "Jornada")]
        [Column("Jornada")]
        public string Jornada { get; set; }

        [Display(Name = "DataCadastro")]
        [Column("DataCadastro")]
        public string DataCadastro { get; set; }

        [Display(Name = "Admissao1")]
        [Column("Admissao")]
        public string Admissao { get; set; }

        [Display(Name = "Senha")]
        [Column("Senha")]
        public string Senha { get; set; }

        [Display(Name = "Previlegios")]
        [Column("Previlegios")]
        public string Previlegios { get; set; }

        [Display(Name = "Cargo")]
        [Column("Cargo")]
        public string Cargo { get; set; }

        [Display(Name = "Salario")]
        [Column("Salario")]
        public string Salario { get; set; }

        [Display(Name = "Desligamento")]
        [Column("Desligamento")]
        public string Desligamento { get; set; }


    }
}