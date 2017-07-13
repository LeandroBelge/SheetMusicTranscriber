using Microsoft.EntityFrameworkCore;
using SheetMusicTranscribe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetMusicTranscribe
{
    public class DataService : IDataService
    {
        private readonly Contexto _contexto;

        public DataService(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public void InicializaDB()
        {
            this._contexto.Database.EnsureCreated();
        }

        public List<Transcricao> GetTranscricoes()
        {
            var query = from t in _contexto.Transcricoes
                        .Include(m => m.musica)
                        .Include(a => a.artista)
                        .Include(r => r.revista)
                        orderby t.musica.Nome 
                        select t;
            List<Transcricao> lista = new List<Transcricao>();
            foreach (var item in query)
            {
                lista.Add(item);
            }

            return lista;
        }
    }
}
