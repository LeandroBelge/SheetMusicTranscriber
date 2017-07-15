using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SheetMusicTranscribe.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SheetMusicTranscribe.Controllers
{
    public class PrincipalController : Controller
    {
        private readonly IDataService _dataService;
        public PrincipalController(IDataService DataService)
        {
            this._dataService = DataService;
        }
        // GET: /<controller>/
        public IActionResult Principal()
        {
            List<Transcricao> Transcricoes = this._dataService.getTranscricoes();
            return View(Transcricoes);
        }

        [HttpPost]
        public void Persistir([FromBody] Transcricao transcricao)
        {
            _dataService.Persistir(transcricao);
        }
        [HttpPost]
        public void Excluir([FromBody] int IdTranscricao)
        {
            _dataService.Excluir(IdTranscricao);
        }
    }
}
