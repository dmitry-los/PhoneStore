using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneStore.Models;

namespace PhoneStore.Controllers
{
    public class HomeController : Controller
    {
        private IPhoneRepository _phoneRepository;
        private IPurchaseRepository _purchaseRepository;

        public HomeController(IPhoneRepository phoneRepository, IPurchaseRepository purchaseRepository)
        {
            _phoneRepository = phoneRepository;
            _purchaseRepository = purchaseRepository;
        }

        public ActionResult Index()
        {
            var phones = _phoneRepository.GetAll();
            ViewBag.Phones = phones;
            
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.PhoneId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.UtcNow;
            _purchaseRepository.Add(purchase);

            return $"Thanks, {purchase.Person}, for buying. Have a nice day!";
        }
    }
}