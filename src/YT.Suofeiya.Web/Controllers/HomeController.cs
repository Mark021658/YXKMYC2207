using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using YT.Suofeiya.Menu;

namespace YT.Suofeiya.Web.Controllers
{
    public class HomeController : SuofeiyaControllerBase
    {
        private readonly IMenuAppService _menuAppService;

        public HomeController(IMenuAppService menuAppService)
        {
            _menuAppService = menuAppService;
        }

        public ActionResult Index()
        {
            List<MenuDto> menus = _menuAppService.GetMenuList();
            ViewBag.menus = menus;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}