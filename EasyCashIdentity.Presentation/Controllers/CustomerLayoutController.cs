using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.Presentation.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
