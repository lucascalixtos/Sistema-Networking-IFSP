﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlataformaNetworking.Data;

namespace PlataformaNetworking.Migrations
{
    [DbContext(typeof(PlataformaNetworkingContext))]
    [Migration("20200926163910_MudancaVaga")]
    partial class MudancaVaga
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlataformaNetworking.Models.CommentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText");

                    b.Property<DateTime>("CommentTime");

                    b.Property<int>("IdUsuario");

                    b.Property<int?>("PostId");

                    b.Property<int?>("UsuarioId");

                    b.Property<int?>("UsuarioPostId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("UsuarioPostId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.DislikeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DislikedAt");

                    b.Property<int>("IdUsuario1");

                    b.Property<int>("IdUsuario2");

                    b.Property<int?>("Usario1Id");

                    b.Property<int?>("Usario2Id");

                    b.HasKey("Id");

                    b.HasIndex("Usario1Id");

                    b.HasIndex("Usario2Id");

                    b.ToTable("Dislike");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.LikeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario1");

                    b.Property<int>("IdUsuario2");

                    b.Property<int?>("PostModelId");

                    b.Property<int?>("Usuario1Id");

                    b.Property<int?>("Usuario2Id");

                    b.HasKey("Id");

                    b.HasIndex("PostModelId");

                    b.HasIndex("Usuario1Id");

                    b.HasIndex("Usuario2Id");

                    b.ToTable("Like");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.PostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FotoUsuario");

                    b.Property<int>("IdUsuario");

                    b.Property<string>("Imagem");

                    b.Property<string>("NomeUsuario");

                    b.Property<DateTime>("PostTime");

                    b.Property<string>("TextoPost");

                    b.Property<int?>("UsuarioPostId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioPostId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("ProfilePictureUrl");

                    b.Property<string>("Senha");

                    b.Property<int>("Situacao");

                    b.Property<string>("Sobrenome");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Conteudo");

                    b.Property<DateTime>("DataPostagem");

                    b.Property<int>("IdUsuario");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Vaga");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Aluno", b =>
                {
                    b.HasBaseType("PlataformaNetworking.Models.Usuario");

                    b.Property<int>("AnoIngresso");

                    b.Property<string>("Curriculo");

                    b.Property<string>("Curso");

                    b.Property<string>("Habilidades");

                    b.Property<int?>("VagaId");

                    b.HasIndex("VagaId");

                    b.ToTable("Aluno");

                    b.HasDiscriminator().HasValue("Aluno");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Empresa", b =>
                {
                    b.HasBaseType("PlataformaNetworking.Models.Usuario");

                    b.Property<string>("CNPJ");

                    b.Property<string>("Ramo");

                    b.Property<string>("RazaoSocial");

                    b.ToTable("Empresa");

                    b.HasDiscriminator().HasValue("Empresa");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.CommentModel", b =>
                {
                    b.HasOne("PlataformaNetworking.Models.PostModel", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.HasOne("PlataformaNetworking.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.HasOne("PlataformaNetworking.Models.Usuario", "UsuarioPost")
                        .WithMany()
                        .HasForeignKey("UsuarioPostId");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.DislikeModel", b =>
                {
                    b.HasOne("PlataformaNetworking.Models.Usuario", "Usario1")
                        .WithMany()
                        .HasForeignKey("Usario1Id");

                    b.HasOne("PlataformaNetworking.Models.Usuario", "Usario2")
                        .WithMany()
                        .HasForeignKey("Usario2Id");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.LikeModel", b =>
                {
                    b.HasOne("PlataformaNetworking.Models.PostModel")
                        .WithMany("Likes")
                        .HasForeignKey("PostModelId");

                    b.HasOne("PlataformaNetworking.Models.Usuario", "Usuario1")
                        .WithMany()
                        .HasForeignKey("Usuario1Id");

                    b.HasOne("PlataformaNetworking.Models.Usuario", "Usuario2")
                        .WithMany()
                        .HasForeignKey("Usuario2Id");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.PostModel", b =>
                {
                    b.HasOne("PlataformaNetworking.Models.Usuario", "UsuarioPost")
                        .WithMany()
                        .HasForeignKey("UsuarioPostId");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Aluno", b =>
                {
                    b.HasOne("PlataformaNetworking.Models.Vaga")
                        .WithMany("Candidatos")
                        .HasForeignKey("VagaId");
                });
#pragma warning restore 612, 618
        }
    }
}
