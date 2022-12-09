﻿// <auto-generated />
using System;
using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NomeDoProjeto.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221209002719_MigracaoListarImc")]
    partial class MigracaoListarImc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Backend.Models.ImcModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("altura")
                        .HasColumnType("REAL");

                    b.Property<string>("classificacao")
                        .HasColumnType("TEXT");

                    b.Property<double>("imc")
                        .HasColumnType("REAL");

                    b.Property<double>("peso")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Imcs");
                });

            modelBuilder.Entity("Backend.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Backend.Models.ImcModels", b =>
                {
                    b.HasOne("Backend.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
