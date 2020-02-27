using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PartyInvites.Models;

namespace PartyInvites.Controllers

{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(Models.GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Models.Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }

}