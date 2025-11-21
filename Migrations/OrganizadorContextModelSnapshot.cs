using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using TrilhaApiDesafio.Context;
using System;

namespace TrilhaApiDesafio.Migrations
{
    [DbContext(typeof(OrganizadorContext))]
    partial class OrganizadorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0") // pode ajustar conforme seu .NET
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("TrilhaApiDesafio.Models.Tarefa", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:Identity", "1, 1");

                b.Property<string>("Titulo")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Descricao")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("Data")
                    .HasColumnType("datetime2");

                b.Property<int>("Status")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Tarefas");
            });
        }
    }
}
