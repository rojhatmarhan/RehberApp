using App.Models;
using BussinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ContactManager manager = new ContactManager();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var contacts = manager.GetAll();
            return View(contacts);
        }

        public JsonResult Detail(int id)
        {
            var contact = manager.GetAll().Where(x => x.ContactId == id).FirstOrDefault();
            if (contact == null)
                return Json(null);

            return Json(contact.Details);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}