using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SheetMusicTranscribe;

namespace SheetMusicTranscribe.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SheetMusicTranscribe.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int?>("artistaId");

                    b.HasKey("Id");

                    b.HasIndex("artistaId");

                    b.ToTable("Albuns");
                });

            modelBuilder.Entity("SheetMusicTranscribe.Models.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("SheetMusicTranscribe.Models.Musica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int?>("albumId");

                    b.Property<int?>("artistaId");

                    b.HasKey("Id");

                    b.HasIndex("albumId");

                    b.HasIndex("artistaId");

                    b.ToTable("Musicas");
                });

            modelBuilder.Entity("SheetMusicTranscribe.Models.Revista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPublicacao");

                    b.Property<string>("Edicao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Revistas");
                });

            modelBuilder.Entity("SheetMusicTranscribe.Models.Transcricao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("albumId");

                    b.Property<int?>("artistaId");

                    b.Property<int?>("musicaId");

                    b.Property<int?>("revistaId");

                    b.HasKey("Id");

                    b.HasIndex("albumId");

                    b.HasIndex("artistaId");

                    b.HasIndex("musicaId");

                    b.HasIndex("revistaId");

                    b.ToTable("Transcricoes");
                });

            modelBuilder.Entity("SheetMusicTranscribe.Models.Album", b =>
                {
                    b.HasOne("SheetMusicTranscribe.Models.Artista", "artista")
                        .WithMany("albuns")
                        .HasForeignKey("artistaId");
                });

            modelBuilder.Entity("SheetMusicTranscribe.Models.Musica", b =>
                {
                    b.HasOne("SheetMusicTranscribe.Models.Album", "album")
                        .WithMany("musicas")
                        .HasForeignKey("albumId");

                    b.HasOne("SheetMusicTranscribe.Models.Artista", "artista")
                        .WithMany()
                        .HasForeignKey("artistaId");
                });

            modelBuilder.Entity("SheetMusicTranscribe.Models.Transcricao", b =>
                {
                    b.HasOne("SheetMusicTranscribe.Models.Album", "album")
                        .WithMany()
                        .HasForeignKey("albumId");

                    b.HasOne("SheetMusicTranscribe.Models.Artista", "artista")
                        .WithMany()
                        .HasForeignKey("artistaId");

                    b.HasOne("SheetMusicTranscribe.Models.Musica", "musica")
                        .WithMany()
                        .HasForeignKey("musicaId");

                    b.HasOne("SheetMusicTranscribe.Models.Revista", "revista")
                        .WithMany()
                        .HasForeignKey("revistaId");
                });
        }
    }
}
