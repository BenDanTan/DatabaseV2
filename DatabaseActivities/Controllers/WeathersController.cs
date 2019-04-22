using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using DatabaseActivities.Service;

namespace DatabaseActivities.Controllers
{
    public class WeathersController : Controller
    {
        private WeatherService service = new WeatherService();

        // GET: Weathers
        public ActionResult Index()
        {
            return View(service.GetAllWeathers());
        }

        // GET: Weathers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weather weather = service.GetWeatherById((int)id);
            if (weather == null)
            {
                return HttpNotFound();
            }
            return View(weather);
        }

        // GET: Weathers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Weathers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,date,hi,low,luckyNumber")] Weather weather)
        {
            if (ModelState.IsValid)
            {
                service.AddWeather(weather);
                return RedirectToAction("Index");
            }

            return View(weather);
        }

        // GET: Weathers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weather weather = service.GetWeatherById((int)id);
            if (weather == null)
            {
                return HttpNotFound();
            }
            return View(weather);
        }

        // POST: Weatherss/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,date,hi,low,luckyNumber")] Weather weather)
        {
            if (ModelState.IsValid)
            {
                service.SaveEdits(weather);
                return RedirectToAction("Index");
            }
            return View(weather);
        }

        // GET: Weathers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weather weather = service.GetWeatherById((int)id);
            if (weather == null)
            {
                return HttpNotFound();
            }
            return View(weather);
        }

        // POST: Weathers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Weather weather = service.GetWeatherById(id);
            service.DeleteWeather(weather);
            return RedirectToAction("Index");        }
    }
}
