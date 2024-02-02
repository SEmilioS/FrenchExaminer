using FEWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FEWebApp.Controllers
{
    public class ResetController : Controller
    {
        public readonly DB _repositorio;
        public ResetController(DB db) 
        {
            _repositorio = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delete()
        {
            _repositorio.reset();

            return View("Deleted");
        }
    }
}
