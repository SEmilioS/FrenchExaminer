using FEWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FEWebApp.Controllers
{
    public class NotesController : Controller
    {
        public readonly DB _repositorio;
        public NotesController(DB db) 
        {
            _repositorio = db;
        }
        public IActionResult Index()
        {
            var notes = _repositorio._notes;
            return View(notes);
        }
    }
}
