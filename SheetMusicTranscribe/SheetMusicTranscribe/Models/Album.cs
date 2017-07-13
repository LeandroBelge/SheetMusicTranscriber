using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetMusicTranscribe.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Artista artista { get; set; }
        public List<Musica> musicas { get; set; }
    }
}
