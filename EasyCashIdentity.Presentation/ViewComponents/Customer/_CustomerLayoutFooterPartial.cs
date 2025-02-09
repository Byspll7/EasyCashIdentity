using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.Presentation.ViewComponents.Cusotmer
{
    public class _CustomerLayoutFooterPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
