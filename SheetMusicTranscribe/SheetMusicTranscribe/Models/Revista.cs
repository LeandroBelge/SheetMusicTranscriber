using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetMusicTranscribe.Models
{
    public class Revista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Edicao { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}
