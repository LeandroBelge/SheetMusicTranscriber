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
    }
}
