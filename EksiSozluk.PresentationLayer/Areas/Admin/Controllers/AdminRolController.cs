using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Areas.Admin.Controllers
{
    public class AdminRolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
