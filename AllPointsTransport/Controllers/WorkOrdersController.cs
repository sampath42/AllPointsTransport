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


        AllPointsTransport.Models.AllPointsTransportEntities db1 = new AllPointsTransport.Models.AllPointsTransportEntities();

        [ValidateInput(false)]
        public ActionResult WOLineItemsPartial(int WorkOrderNo)
        {
            //var model = db1.WOLineItems;

            var model = from w in db1.WOLineItems
                        where w.WorkOrderNo == WorkOrderNo orderby w.RowOrder
                        select w ;

            return PartialView("_WOLineItemsPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult WOLineItemsPartialAddNew(AllPointsTransport.Models.WOLineItem item)
        {
            var model = db1.WOLineItems;
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
            return PartialView("_WOLineItemsPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult WOLineItemsPartialUpdate(AllPointsTransport.Models.WOLineItem item)
        {
            var model = db1.WOLineItems;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.WorkOrderLineItemID == item.WorkOrderLineItemID);
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
            return PartialView("_WOLineItemsPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult WOLineItemsPartialDelete(System.Int32 WorkOrderLineItemID)
        {
            var model = db1.WOLineItems;
            if (WorkOrderLineItemID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.WorkOrderLineItemID == WorkOrderLineItemID);
                    if (item != null)
                        model.Remove(item);
                    db1.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_WOLineItemsPartial", model.ToList());
        }

        AllPointsTransport.Models.AllPointsTransportEntities db2 = new AllPointsTransport.Models.AllPointsTransportEntities();

        [ValidateInput(false)]
        public ActionResult DriverPayGridViewPartial(int WorkOrderNo)
        {
            var model = from w in db2.DriverPays
                        where w.WorkOrderNo == WorkOrderNo
                        orderby w.RowOrder
                        select w;
            return PartialView("_DriverPayGridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult DriverPayGridViewPartialAddNew(AllPointsTransport.Models.DriverPay item)
        {
            var model = db2.DriverPays;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_DriverPayGridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DriverPayGridViewPartialUpdate(AllPointsTransport.Models.DriverPay item)
        {
            var model = db2.DriverPays;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.WorkOrderID == item.WorkOrderID);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db2.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_DriverPayGridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DriverPayGridViewPartialDelete(System.Int32 WorkOrderID)
        {
            var model = db2.DriverPays;
            if (WorkOrderID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.WorkOrderID == WorkOrderID);
                    if (item != null)
                        model.Remove(item);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_DriverPayGridViewPartial", model.ToList());
        }




    }



}