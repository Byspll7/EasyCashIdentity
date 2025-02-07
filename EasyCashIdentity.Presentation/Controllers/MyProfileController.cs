using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.Presentation.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
