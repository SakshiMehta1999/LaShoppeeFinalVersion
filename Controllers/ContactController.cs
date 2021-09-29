using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Controllers
{
    public class ContactController : Controller
    {
        [Route("Contact/Index")]
        public IActionResult Index() {
            return View();
        }
    }
}
