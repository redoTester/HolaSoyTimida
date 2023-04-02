using Microsoft.AspNetCore.Mvc;

namespace AppWeb01T_Core.Controllers
{
    public class CarrerasController : Controller
    {
        public IActionResult Index()
        {
            //enviar la fecha a traves del viewdata de clave fecha
            ViewData["fecha"] = DateTime.Now.ToString();
            return View();
        }
    }
}
