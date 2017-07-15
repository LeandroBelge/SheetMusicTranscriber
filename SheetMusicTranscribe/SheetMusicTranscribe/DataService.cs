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

        public List<Transcricao> getTranscricoes()
        {
            return _contexto.Transcricoes.ToList();
        }

        public void Persistir(Transcricao transcricao)
        {
            _contexto.Transcricoes.Add(transcricao);
            _contexto.SaveChanges();
        }

        public void Excluir(int Id)
        {
            _contexto.Transcricoes.ToList();
            _contexto.Transcricoes.Remove(_contexto.Transcricoes.Where(x => x.Id == Id).FirstOrDefault());
            _contexto.SaveChanges();
        }
    }
}
