using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.Presentation.ViewComponents.Cusotmer
{
    public class _CustomerLayoutScriptPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
