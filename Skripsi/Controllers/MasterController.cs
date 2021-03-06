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

        [HttpPost]
        public ActionResult SaveArea(tn_m_area area)
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
        public ActionResult DeleteArea(int? id)
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

        public ActionResult Manufacture()
        {
            if (Session["sessionUser"] == null)
            {
                return RedirectToAction("signout");
            }

            tn_u_login user = (tn_u_login)Session["sessionUser"];
            return View(path + "master_manufacture.cshtml", user);
        }

        [HttpGet]
        public JsonResult GetListManufacture()
        {

            List<tn_m_manufacture> list = masterRepository.GetListManufacture();
            var jsonResult = Json(list, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;

        }

        [HttpGet]
        public JsonResult GetDetailManufacture(int? id)
        {

            tn_m_manufacture manu = masterRepository.GetDetailManufacture(id);
            return Json(manu, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult SaveManufacture(tn_m_manufacture manu)
        {

            if (Session["sessionUser"] == null)
            {
                return Json("timeout", JsonRequestBehavior.AllowGet);
            }

            bool save = false;
            try
            {

                tn_u_login user = (tn_u_login)Session["sessionUser"];
                manu.created_by = user.u_id;
                save = masterRepository.SaveManufacture(manu);

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return Json("error", JsonRequestBehavior.AllowGet);

            }

            return Json(save, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult DeleteManufacture(int? id)
        {

            if (Session["sessionUser"] == null)
            {
                return Json("timeout", JsonRequestBehavior.AllowGet);
            }

            bool delete = false;
            try
            {
                delete = masterRepository.DeleteManufacture(id);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return Json("error", JsonRequestBehavior.AllowGet);

            }

            return Json(delete, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Material()
        {
            if (Session["sessionUser"] == null)
            {
                return RedirectToAction("signout");
            }

            tn_u_login user = (tn_u_login)Session["sessionUser"];
            return View(path + "master_material.cshtml", user);
        }

        [HttpGet]
        public JsonResult GetListMaterial()
        {

            List<tn_m_material> list = masterRepository.GetListMaterial();
            var jsonResult = Json(list, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;

        }

        [HttpGet]
        public JsonResult GetDetailMaterial(int? id)
        {

            tn_m_material manu = masterRepository.GetDetailMaterial(id);
            return Json(manu, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult SaveMaterial(tn_m_material materi)
        {

            if (Session["sessionUser"] == null)
            {
                return Json("timeout", JsonRequestBehavior.AllowGet);
            }

            bool save = false;
            try
            {

                tn_u_login user = (tn_u_login)Session["sessionUser"];
                materi.created_by = user.u_id;
                save = masterRepository.SaveMaterial(materi);

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return Json("error", JsonRequestBehavior.AllowGet);

            }

            return Json(save, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult DeleteMaterial(int? id)
        {

            if (Session["sessionUser"] == null)
            {
                return Json("timeout", JsonRequestBehavior.AllowGet);
            }

            bool delete = false;
            try
            {
                delete = masterRepository.DeleteMaterial(id);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return Json("error", JsonRequestBehavior.AllowGet);

            }

            return Json(delete, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Equipment()
        {
            if (Session["sessionUser"] == null)
            {
                return RedirectToAction("signout");
            }

            tn_u_login user = (tn_u_login)Session["sessionUser"];
            return View(path + "master_equipment.cshtml", user);
        }
    }
}