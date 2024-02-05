using DesafioFullStack.Domain.Application;
using DesafioFullStack.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFullStack.Controllers
{
    public class EquipamentosController(IEquipamentoApplication application) : Controller
    {
        public async Task<IActionResult> List()
        {
            var model = new EquipamentoListModel
            {
                Equipamentos = await application.SelectAll()
            };
            return View(model);
        }
    }
}
