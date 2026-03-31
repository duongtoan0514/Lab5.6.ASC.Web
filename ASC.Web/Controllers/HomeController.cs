using ASC.DataAccess.Repository;
using ASC.Model;
using ASC.Web.Configuration;
using ASC.Web.Models;
using ASC.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ASC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IOptions<ApplicationSettings> _settings;

        public HomeController(ILogger<HomeController> logger, IOptions<ApplicationSettings> settings)
        {
            _logger = logger;
            _settings = settings;
        }
        public IActionResult Index([FromServices] IEmailSender emailSender)
        {
            var emailService = this.HttpContext.RequestServices
                                    .GetService(typeof(IEmailSender)) as IEmailSender;
            ViewBag.Title = _settings.Value.ApplicationTitle;
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}