using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponent
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
