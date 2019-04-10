using DatabaseActivities.Models.Entity;
using DatabaseActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class WeatherController : Controller
    {

        private WeatherService service = new WeatherService();

        // GET: Weather
        public ActionResult Index()
        {
            return View(service.GetAllWeathers());
        }

        // GET: Weather/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Weather/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Date,Hi,Low")] Weather weather)
        {
            if (ModelState.IsValid)
            {
                service.AddWeather(weather);
                return RedirectToAction("Index");
            }

            return View(weather);
        }

        [HttpPost]
        public ActionResult Hottest()
        {
            return View("Index", service.GetHottestDay());
        }

        [HttpPost]
        public ActionResult largest()
        {
            return View("Index", service.GetLargestRange());
        }

        [HttpPost]
        public ActionResult Filtered(DateTime begin, DateTime end)
        {
            return View("Index", service.GetWeatherDateRange(begin, end));
        }
    }
}