﻿// <auto-generated />
using JOBSSys_0002.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace JOBSSys_0002.Migrations
{
    [DbContext(typeof(PessoaContext))]
    [Migration("20171215211841_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JOBSSys_0002.Models.Pessoa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cidade");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.Property<string>("Profissao");

                    b.Property<string>("Senha");

                    b.HasKey("ID");

                    b.ToTable("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
