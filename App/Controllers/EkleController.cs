using App.Models;
using BussinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class EkleController : Controller
    {
        ContactManager contactManager = new ContactManager();
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Add(string ad, string soyad, string telefon, List<Detay> detay)
        {
            try
            {
                List<Detail> details = new List<Detail>();
                foreach (var item in detay)
                {
                    details.Add(new Detail()
                    {
                        Adress1 = item.adres1,
                        Adress2 = item.adres2,
                        Height = Convert.ToInt32(item.uzunluk),
                        Weight = Convert.ToInt32(item.kilo)
                    });
                }

                Contact contact = new Contact()
                {
                    Name = ad,
                    LastName = soyad,
                    Phone = telefon,
                    Details = details
                };

                int id = contactManager.Add(contact);


                RedirectToAction("Index","Home");
                return Json("başarılı");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
    }
}
