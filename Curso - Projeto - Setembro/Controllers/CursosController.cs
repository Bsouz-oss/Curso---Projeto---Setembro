using Curso___Projeto___Setembro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso___Projeto___Setembro.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            // Aqui você pode retornar uma lista de cursos
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            if (ModelState.IsValid)
            {
                // Lógica para salvar o curso
                return RedirectToAction("Index");
            }
            return View(curso);
        }
    }
}