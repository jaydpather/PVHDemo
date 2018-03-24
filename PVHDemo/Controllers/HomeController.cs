using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace PVHDemo.Controllers
{
    public class HomeController : Controller
    {
        private IRegistrationService _registrationService;
        
        public HomeController()
        {
            _registrationService = new RegistrationService(new DAL.RegistrationRepository()); //todo: replace with dependency injection
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegistrationViewModel registrationViewModel)
        {
            _registrationService.SaveRegistration(registrationViewModel);
            return View(registrationViewModel);
        }
    }
}
