using Curso___Projeto___Setembro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso___Projeto___Setembro.Controllers
{
    public class AlunosController : Controller
    {
        public IActionResult Index()
        {
            // Aqui você pode retornar uma lista de alunos
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                // Lógica para salvar o aluno
                return RedirectToAction("Index");
            }
            return View(aluno);
        }
    }
}