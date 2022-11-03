﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PontoAll_2810.Models;

namespace PontoAll_2810.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221103223548_inicial5")]
    partial class inicial5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PontoAll_2810.Models.BancoHoras", b =>
                {
                    b.Property<int>("IdBancoHoras")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .HasColumnType("text");

                    b.Property<string>("Notificacoes")
                        .HasColumnType("text");

                    b.Property<string>("Ocorrencias")
                        .HasColumnType("text");

                    b.Property<string>("SaldoBancoHoras")
                        .HasColumnType("text");

                    b.HasKey("IdBancoHoras");

                    b.ToTable("BancoHoras");
                });

            modelBuilder.Entity("PontoAll_2810.Models.Operador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Operador");
                });

            modelBuilder.Entity("PontoAll_2810.Models.RegistroPonto", b =>
                {
                    b.Property<int>("IdRegistroPonto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DataRegistro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HoraRegistro")
                        .HasColumnType("text");

                    b.Property<string>("LocalizacaoRegistro")
                        .HasColumnType("text");

                    b.Property<string>("SomaHora")
                        .HasColumnType("text");

                    b.HasKey("IdRegistroPonto");

                    b.ToTable("RegistroPonto");
                });

            modelBuilder.Entity("PontoAll_2810.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Usu_Id")
                        .HasColumnType("int");

                    b.Property<string>("Admissao")
                        .HasColumnName("Admissao")
                        .HasColumnType("text");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnName("CPF")
                        .HasColumnType("text");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnName("Cargo")
                        .HasColumnType("text");

                    b.Property<string>("Celular")
                        .HasColumnName("Celular")
                        .HasColumnType("text");

                    b.Property<string>("DataCadastro")
                        .HasColumnName("DataCadastro")
                        .HasColumnType("text");

                    b.Property<string>("Desligamento")
                        .HasColumnName("Desligamento")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("text");

                    b.Property<string>("Jornada")
                        .IsRequired()
                        .HasColumnName("Jornada")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Previlegios")
                        .HasColumnName("Previlegios")
                        .HasColumnType("text");

                    b.Property<string>("Salario")
                        .HasColumnName("Salario")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("Senha")
                        .HasColumnType("text");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PontoAll_2810.Models.Operador", b =>
                {
                    b.HasOne("PontoAll_2810.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PontoAll_2810.Models.Usuario", b =>
                {
                    b.HasOne("PontoAll_2810.Models.Usuario", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
