using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetMusicTranscribe.Models
{
    public class Transcricao
    {
        public int Id { get; set; }
        public string NomeArtista { get; set; }
        public string NomeAlbum { get; set; }
        public string NomeMusica { get; set; }
        public string NomeRevista { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}
