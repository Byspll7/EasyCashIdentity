using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EasyCashIdentity.Presentation.ViewComponents.Cusotmer
{
    public class _CustomerLayoutNavbarPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
