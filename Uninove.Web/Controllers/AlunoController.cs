using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class AlunoController : Controller
    {
        // Método Index - Define os dados na ViewBag
        public IActionResult Index()
        {
            ViewBag.Nome = "João Silva";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";

            return View();
        }

        // Método Detalhes - Recebe o ID pela URL
        public IActionResult Detalhes(int id)
        {
            ViewData["Mensagem"] = $"Exibindo detalhes do aluno com ID: {id}";
            return View();
        }

        public IActionResult Sobre()
        {
            ViewData["Mensagem"] = $"Sobre o Projeto🚀";
            ViewBag.Unidade = "Uninove Campus Memorial";
            return View();
        }
    }
}