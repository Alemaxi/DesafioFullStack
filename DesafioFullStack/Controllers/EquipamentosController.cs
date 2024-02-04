using Microsoft.AspNetCore.Mvc;

namespace DesafioFullStack.Controllers
{
    public class EquipamentosController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
