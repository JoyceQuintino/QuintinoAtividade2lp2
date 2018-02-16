﻿// <auto-generated />
using Atividade2EFCoreClassLib.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace Atividade2EFCoreClassLib.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20180208190649_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.Agencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BancoId");

                    b.Property<int>("Numero");

                    b.HasKey("Id");

                    b.HasIndex("BancoId");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.Banco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Bancos");
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.ClienteSolicitacao", b =>
                {
                    b.Property<int>("ClienteId");

                    b.Property<int>("SolicitacaoId");

                    b.HasKey("ClienteId", "SolicitacaoId");

                    b.HasIndex("SolicitacaoId");

                    b.ToTable("ClienteSolicitacoes");
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Contas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Conta");
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.Solicitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgenciaId");

                    b.Property<string>("text");

                    b.HasKey("Id");

                    b.HasIndex("AgenciaId");

                    b.ToTable("Solicitacoes");
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.ContaCorrente", b =>
                {
                    b.HasBaseType("Atividade2EFCoreClassLib.Entidades.Conta");


                    b.ToTable("ContaCorrente");

                    b.HasDiscriminator().HasValue("ContaCorrente");
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.ContaPoupanca", b =>
                {
                    b.HasBaseType("Atividade2EFCoreClassLib.Entidades.Conta");

                    b.Property<decimal>("Juros");

                    b.ToTable("ContaPoupanca");

                    b.HasDiscriminator().HasValue("ContaPoupanca");
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.Agencia", b =>
                {
                    b.HasOne("Atividade2EFCoreClassLib.Entidades.Banco", "Banco")
                        .WithMany()
                        .HasForeignKey("BancoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.ClienteSolicitacao", b =>
                {
                    b.HasOne("Atividade2EFCoreClassLib.Entidades.Cliente", "Cliente")
                        .WithMany("ClientesSolicitacoes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Atividade2EFCoreClassLib.Entidades.Solicitacao", "Solicitacao")
                        .WithMany("ClientesSolicitacoes")
                        .HasForeignKey("SolicitacaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.Conta", b =>
                {
                    b.HasOne("Atividade2EFCoreClassLib.Entidades.Cliente")
                        .WithOne("Conta")
                        .HasForeignKey("Atividade2EFCoreClassLib.Entidades.Conta", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Atividade2EFCoreClassLib.Entidades.Solicitacao", b =>
                {
                    b.HasOne("Atividade2EFCoreClassLib.Entidades.Agencia", "Agencia")
                        .WithMany()
                        .HasForeignKey("AgenciaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
