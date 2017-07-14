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
        public string NomeAlbum { get; private set; }
        public string NomeMusica { get; private set; }
        public string NomeRevista { get; private set; }
        public DateTime DataPublicacao { get; private set; }
    }
}
