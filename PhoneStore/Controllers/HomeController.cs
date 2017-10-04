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

        public HomeController(IPhoneRepository phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }

        public ActionResult Index()
        {
            var phones = _phoneRepository.GetAll();
            ViewBag.Phones = phones;
            
            return View();
        }
    }
}