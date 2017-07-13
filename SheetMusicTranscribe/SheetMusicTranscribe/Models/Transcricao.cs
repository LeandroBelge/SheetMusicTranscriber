using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetMusicTranscribe.Models
{
    public class Transcricao
    {
        public int Id { get; set; }
        
        public Musica musica { get; set; }

        public Artista artista { get; set; }

        public Album album { get; set; }

        public Revista revista { get; set; }

    }
}
