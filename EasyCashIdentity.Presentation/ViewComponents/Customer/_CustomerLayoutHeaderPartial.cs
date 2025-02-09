using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentity.Presentation.ViewComponents.Cusotmer
{
    public class _CustomerLayoutHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
