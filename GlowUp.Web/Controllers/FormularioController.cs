using Microsoft.AspNetCore.Mvc;

namespace GlowUp.Web.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
