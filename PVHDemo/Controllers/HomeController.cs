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
        
        public HomeController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegistrationViewModel registrationViewModel)
        {
            if(ModelState.IsValid)
            {
                _registrationService.SaveRegistration(registrationViewModel);
            }
            
            return View(registrationViewModel);
        }
    }
}
