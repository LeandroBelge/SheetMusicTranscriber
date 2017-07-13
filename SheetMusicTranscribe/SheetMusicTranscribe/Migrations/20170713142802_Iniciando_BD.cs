using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SheetMusicTranscribe.Migrations
{
    public partial class Iniciando_BD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artistas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Revistas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataPublicacao = table.Column<DateTime>(nullable: false),
                    Edicao = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albuns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    artistaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albuns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albuns_Artistas_artistaId",
                        column: x => x.artistaId,
                        principalTable: "Artistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Musicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    albumId = table.Column<int>(nullable: true),
                    artistaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musicas_Albuns_albumId",
                        column: x => x.albumId,
                        principalTable: "Albuns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Musicas_Artistas_artistaId",
                        column: x => x.artistaId,
                        principalTable: "Artistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transcricoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    albumId = table.Column<int>(nullable: true),
                    artistaId = table.Column<int>(nullable: true),
                    musicaId = table.Column<int>(nullable: true),
                    revistaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcricoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transcricoes_Albuns_albumId",
                        column: x => x.albumId,
                        principalTable: "Albuns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transcricoes_Artistas_artistaId",
                        column: x => x.artistaId,
                        principalTable: "Artistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transcricoes_Musicas_musicaId",
                        column: x => x.musicaId,
                        principalTable: "Musicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transcricoes_Revistas_revistaId",
                        column: x => x.revistaId,
                        principalTable: "Revistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albuns_artistaId",
                table: "Albuns",
                column: "artistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_albumId",
                table: "Musicas",
                column: "albumId");

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_artistaId",
                table: "Musicas",
                column: "artistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcricoes_albumId",
                table: "Transcricoes",
                column: "albumId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcricoes_artistaId",
                table: "Transcricoes",
                column: "artistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcricoes_musicaId",
                table: "Transcricoes",
                column: "musicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcricoes_revistaId",
                table: "Transcricoes",
                column: "revistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transcricoes");

            migrationBuilder.DropTable(
                name: "Musicas");

            migrationBuilder.DropTable(
                name: "Revistas");

            migrationBuilder.DropTable(
                name: "Albuns");

            migrationBuilder.DropTable(
                name: "Artistas");
        }
    }
}
