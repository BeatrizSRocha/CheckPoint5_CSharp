using Microsoft.AspNetCore.Mvc;

namespace CP_05.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
