﻿// <auto-generated />
using System;
using Api_Jogos_Isaac.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api_Jogos_Isaac.Migrations
{
    [DbContext(typeof(Jogos_Context))]
    partial class Jogos_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api_Jogos_Isaac.Domains.Jogos", b =>
                {
                    b.Property<Guid>("JogosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeDoJogo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Plataforma")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("JogosID");

                    b.HasIndex("NomeDoJogo")
                        .IsUnique();

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("Api_Jogos_Isaac.Domains.Usuarios", b =>
                {
                    b.Property<Guid>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JogoFavorito")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JogoFavoritoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("UsuarioID");

                    b.HasIndex("JogoFavorito");

                    b.HasIndex("NickName")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Api_Jogos_Isaac.Domains.Usuarios", b =>
                {
                    b.HasOne("Api_Jogos_Isaac.Domains.Jogos", "Jogos")
                        .WithMany()
                        .HasForeignKey("JogoFavorito");

                    b.Navigation("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}
