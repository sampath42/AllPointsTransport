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
    public class DriversController : Controller
    {
        private AllPointsTransportEntities db = new AllPointsTransportEntities();

        // GET: Drivers
        public ActionResult Index()
        {
            return View();
        }

        AllPointsTransport.Models.AllPointsTransportEntities db1 = new AllPointsTransport.Models.AllPointsTransportEntities();

        [ValidateInput(false)]
        public ActionResult DriverPartial()
        {
            var model = db1.Drivers;
            return PartialView("_DriverPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult DriverPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] AllPointsTransport.Models.Driver item)
        {
            var model = db1.Drivers;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db1.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_DriverPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult DriverPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] AllPointsTransport.Models.Driver item)
        {
            var model = db1.Drivers;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.DriverID == item.DriverID);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db1.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_DriverPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult DriverPartialDelete(System.Int32 DriverID)
        {
            var model = db1.Drivers;
            if (DriverID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.DriverID == DriverID);
                    if (item != null)
                        model.Remove(item);
                    db1.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_DriverPartial", model.ToList());
        }
    }
}
