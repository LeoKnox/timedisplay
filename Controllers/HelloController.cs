using System;
using Microsoft.AspNetCore.Mvc;
namespace time_display.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            //ViewBag.Time = CurrentTime.ToString();
            ViewBag.Date = CurrentTime.ToString("MMM dd, yyyy");
            ViewBag.Time = CurrentTime.ToString("h:MM tt");
            return View();
        }
    }
}