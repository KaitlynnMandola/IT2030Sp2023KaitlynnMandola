using Microsoft.AspNetCore.Mvc;
//error caused because the following was missing. It was causing an error on line 15
using KaitlynnKeyboardsAndKilobytes.Models;

namespace KaitlynnKeyboardsAndKilobytes.Controllers
{
    public class ContactController : Controller
    {
        //missing [HttpGet] attribute
        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.FV = 0;  this line is not needed, you can remove it
            return View();
        }

        //missing [HttpPost] attribute
        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            //ViewBag.FV = model.ContactModel();  this line is not needed, you can remove it
            return View(model);
        }
    }
}
