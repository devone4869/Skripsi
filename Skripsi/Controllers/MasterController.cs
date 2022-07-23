using Skripsi.Models;
using Skripsi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skripsi.Controllers
{
    public class MasterController : Controller
    {

        private static string path = "/views/master/";
        private MasterRepository masterRepository = new MasterRepository();

        public ActionResult Area()
        {
            if (Session["sessionUser"] == null)
            {
                return RedirectToAction("signout");
            }

            tn_u_login user = (tn_u_login)Session["sessionUser"];
            return View(path + "master_area.cshtml", user);
        }

        /* GET LIST MASTER ETHNIC */
        [HttpGet]
        public JsonResult GetListArea()
        {

            List<tn_m_area> listethnic = masterRepository.GetlistArea();
            var jsonResult = Json(listethnic, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;

        }

       
        [HttpGet]
        public JsonResult GetDetailArea(int? id)
        {

            tn_m_area area = masterRepository.GetDetailArea(id);
            return Json(area, JsonRequestBehavior.AllowGet);

        }


        /* SAVE MASTER ETHNIC */
        [HttpPost]
        public ActionResult SaveEthnic(tn_m_area area)
        {

            if (Session["sessionUser"] == null)
            {
                return Json("timeout", JsonRequestBehavior.AllowGet);
            }

            bool save = false;
            try
            {

                tn_u_login user = (tn_u_login)Session["sessionUser"];
                area.created_by = user.u_id;
                save = masterRepository.SaveArea(area);

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return Json("error", JsonRequestBehavior.AllowGet);

            }

            return Json(save, JsonRequestBehavior.AllowGet);

        }

        
        [HttpPost]
        public ActionResult DelteArea(int? id)
        {

            if (Session["sessionUser"] == null)
            {
                return Json("timeout", JsonRequestBehavior.AllowGet);
            }

            bool delete = false;
            try
            {
                delete = masterRepository.DeleteArea(id);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return Json("error", JsonRequestBehavior.AllowGet);

            }

            return Json(delete, JsonRequestBehavior.AllowGet);

        }
    }
}