using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllPointsTransport.Controllers
{
    public class WorkOrdersController : Controller
    {
        // GET: WorkOrder
        public ActionResult Index()
        {
            return View();
        }

        AllPointsTransport.Models.AllPointsTransportEntities db = new AllPointsTransport.Models.AllPointsTransportEntities();

        [ValidateInput(false)]
        public ActionResult WorkOrderViewPartial()
        {
            var model = db.WorkOrders;
            return PartialView("_WorkOrderViewPartial", model.ToList());
        }

        //[HttpPost, ValidateInput(false)]
        //public ActionResult WorkOrderViewPartialAddNew(AllPointsTransport.Models.WorkOrder item)
        //{
        //    var model = db.WorkOrders;
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            model.Add(item);
        //            db.SaveChanges();
        //        }
        //        catch (Exception e)
        //        {
        //            ViewData["EditError"] = e.Message;
        //        }
        //    }
        //    else
        //        ViewData["EditError"] = "Please, correct all errors.";
        //    return PartialView("_WorkOrderViewPartial", model.ToList());
        //}
        //[HttpPost, ValidateInput(false)]
        //public ActionResult WorkOrderViewPartialUpdate(AllPointsTransport.Models.WorkOrder item)
        //{
        //    var model = db.WorkOrders;
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var modelItem = model.FirstOrDefault(it => it.WorkOrderID == item.WorkOrderID);
        //            if (modelItem != null)
        //            {
        //                this.UpdateModel(modelItem);
        //                db.SaveChanges();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            ViewData["EditError"] = e.Message;
        //        }
        //    }
        //    else
        //        ViewData["EditError"] = "Please, correct all errors.";
        //    return PartialView("_WorkOrderViewPartial", model.ToList());
        //}
        //[HttpPost, ValidateInput(false)]
        //public ActionResult WorkOrderViewPartialDelete(System.Int32 ID)
        //{
        //    var model = db.WorkOrders;
        //    if (ID >= 0)
        //    {
        //        try
        //        {
        //            var item = model.FirstOrDefault(it => it.WorkOrderID == ID);
        //            if (item != null)
        //                model.Remove(item);
        //            db.SaveChanges();
        //        }
        //        catch (Exception e)
        //        {
        //            ViewData["EditError"] = e.Message;
        //        }
        //    }
        //    return PartialView("_WorkOrderViewPartial", model.ToList());
        //}

        public ActionResult WorkOrderExternalEditForm(System.Int32 ID)
        {
            var model = db.WorkOrders;
            var item = model.FirstOrDefault(it => it.WorkOrderID == ID);

            return View("WorkOrderExternalEditFormView", item);      
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult WorkOrderExternalEditForm(AllPointsTransport.Models.WorkOrder item)
        {
            var model = db.WorkOrders;

            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.WorkOrderID == item.WorkOrderID);
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

            return RedirectToAction("Index");
        }

    }
}