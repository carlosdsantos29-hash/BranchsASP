using Microsoft.AspNetCore.Mvc;

namespace BranchsController.Controllers
{
    public class Cidade : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CidadeDetalhes()
        {
            return View();
        }
    }
}
