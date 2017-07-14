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
        public DbSet<Transcricao> Transcricoes { get; set; }

        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
    }
}
