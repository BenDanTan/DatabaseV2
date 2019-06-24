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
    public class ShippingContainerController : Controller
    {
        private ShippingContainerService service = new ShippingContainerService();

        // GET: ShippingContainers
        public ActionResult Index()
        {
            return View(service.GetAllShippingContainers());
        }

        // GET: ShippingContainer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingContainer shippingContainer = service.GetShippingContainerById((int)id);
            if (shippingContainer == null)
            {
                return HttpNotFound();
            }
            return View(shippingContainer);
        }

        // GET: ShippingContainer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShippingContainers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,weight,destination")] ShippingContainer shippingContainer)
        {
            if (ModelState.IsValid)
            {
                service.AddShippingContainer(shippingContainer);
                return RedirectToAction("Index");
            }

            return View(shippingContainer);
        }

        // GET: ShippingContainers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingContainer shippingContainer = service.GetShippingContainerById((int)id);
            if (shippingContainer == null)
            {
                return HttpNotFound();
            }
            return View(shippingContainer);
        }

        // POST: ShippingContainer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,weight,destination")] ShippingContainer shippingContainer)
        {
            if (ModelState.IsValid)
            {
                service.SaveEdits(shippingContainer);
                return RedirectToAction("Index");
            }
            return View(shippingContainer);
        }

        // GET: ShippingContainers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingContainer shippingContainer = service.GetShippingContainerById((int)id);
            if (shippingContainer == null)
            {
                return HttpNotFound();
            }
            return View(shippingContainer);
        }
    
        // POST: ShippingContainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShippingContainer shippingContainer = service.GetShippingContainerById(id);
            service.DeleteShippingContainer(shippingContainer);
            return RedirectToAction("Index");
        }
    }
}
