using SheetMusicTranscribe.Models;
using System.Collections.Generic;

namespace SheetMusicTranscribe
{
    public interface IDataService
    {
        void InicializaDB();

        List<Transcricao> getTranscricoes();
        void Persistir(Transcricao transcricao);
        void Excluir(int Id);
    }
}