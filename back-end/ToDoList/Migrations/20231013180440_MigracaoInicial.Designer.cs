﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToDoList.Context;

#nullable disable

namespace ToDoList.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20231013180440_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ToDoList.Models.Atividades", b =>
                {
                    b.Property<int>("AtividadesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AtividadesId"));

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<DateTime>("HoraDeCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("AtividadesId");

                    b.ToTable("Atividades");
                });
#pragma warning restore 612, 618
        }
    }
}
