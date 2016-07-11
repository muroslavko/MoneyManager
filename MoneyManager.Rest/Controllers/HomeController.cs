using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MoneyManager.Shared.Logger;

namespace MoneyManager.Rest.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ILogger _logger;

        public HomeController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HomeController>();
        }
        public ActionResult Index()
        {
            _logger.Debug("Index");
            return View();
        }
    }
}
