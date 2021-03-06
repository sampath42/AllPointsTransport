﻿using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AllPointsTransport.Models;

namespace AllPointsTransport.Controllers
{
    public class TrucksController : Controller
    {

        // GET: Trucks
        public ActionResult Index()
        {
            return View();
        }




        AllPointsTransport.Models.AllPointsTransportEntities db = new AllPointsTransport.Models.AllPointsTransportEntities();

        [ValidateInput(false)]
        public ActionResult GridView1Partial()
        {
            var model = db.Trucks;
            return PartialView("_GridView1Partial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialAddNew(AllPointsTransport.Models.Truck item)
        {
            var model = db.Trucks;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridView1Partial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialUpdate(AllPointsTransport.Models.Truck item)
        {
            var model = db.Trucks;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.TruckID == item.TruckID);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridView1Partial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialDelete(System.Int32 ID)
        {
            var model = db.Trucks;
            if (ID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.TruckID == ID);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridView1Partial", model.ToList());
        }
    }
}
