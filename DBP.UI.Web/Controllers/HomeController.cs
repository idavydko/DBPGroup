
using System.Web.Mvc;
using DBP.Core.BL.Services.Page;

namespace DBP.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageService _pageService;

        public HomeController(IPageService pageService)
        {
            _pageService = pageService;
        }

        public ActionResult Index()
        {
            _pageService.A();

            return View();
        }
	}
}