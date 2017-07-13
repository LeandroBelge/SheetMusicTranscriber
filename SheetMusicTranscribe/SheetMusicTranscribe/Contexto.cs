using Microsoft.EntityFrameworkCore;
using SheetMusicTranscribe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetMusicTranscribe
{
    public class Contexto: DbContext
    {
        public DbSet<Album> Albuns { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }
        public DbSet<Revista> Revistas { get; set; }
        public DbSet<Transcricao> Transcricoes { get; set; }

        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
    }
}
