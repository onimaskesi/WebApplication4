using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurcYorumlayıcı.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (ServiceBurc.BurcServisClient servisClient = new ServiceBurc.BurcServisClient())
            {
                if(TempData["Gezegenler"] != null)
                {
                    ViewBag.Gezegenler = (List<string>)TempData["Gezegenler"];
                }
                else
                {
                    ViewBag.Gezegenler = new List<string>();
                }
                var model = servisClient.BurclarGetir().ToList();
                //var model = servisClient.BurcYorumuGetir().ToString();
                return View(model);
            }
        }

        public ActionResult BurcGezegeniGetir(string burc)
        {
            using (ServiceBurc.BurcServisClient servisClient = new ServiceBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir(burc).ToList();
                TempData["Gezegenler"] = model;
                return RedirectToAction("Index");
            }
        }
    }
}