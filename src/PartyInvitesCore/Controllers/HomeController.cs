using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvitesCore.Models;

namespace PartyInvitesCore.Controllers
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
        // Im guessing that the original getmethod is used for first coming to the page
        public ViewResult RsvpForm()
        {
            // By default, MVC will return a view with the same name action method:
            // since this View() does not have an argument, it will return RsvpForm view
            return View();
        }

        [HttpPost]
        // the postmethod is when the page is reposted.
        public ViewResult RsvpForm(GuestResponses guestResponse)
        {
            // By default, MVC will return a view with the same name action method:
            // since this View() does not have an argument, it will return RsvpForm view

            if (ModelState.IsValid) // modelstate is valid will check object to see if it is correct.
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else // returning the same view will also return any errors.
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {

            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

    }
}
