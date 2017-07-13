using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetMusicTranscribe.Models
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Album> albuns { get; set; }
    }
}
