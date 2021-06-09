using DocumentFormat.OpenXml.Office2010.ExcelAc;
using OpenXmlPowerTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class HomeController : Controller
    {
        private ClinicEntities db = new ClinicEntities();
  public IEnumerable<EmployeeOfClinic> EmployeeOfClinics { get; set; }
        public ActionResult Index()
        {


                  

        ViewBag.categories = db.Specialty.ToList();
    ViewBag.Authors = db.EmployeeOfClinic.ToList();
            return View();

        }

      
        private IList<Employee> Getsubcategories(int categoryId)
        {
            return db.Employee.Where(m => m.Specialty_ID == categoryId).ToList();
        }
        public JsonResult LoadSubCatBycategoryId(int categoryId)
        {
            var subcategoriesList = Getsubcategories(categoryId);
            var subcategoriesData = subcategoriesList.Select(m => new SelectListItem()
            {
                Text = m.Name.ToString(),
                Value = m.Specialty_ID.ToString(),
            });
            return Json(subcategoriesData, JsonRequestBehavior.AllowGet);
        }
        private IList<Service> Getsubcategories2(int categoryId)
        {
            return db.Service.Where(m => m.Specialty_ID == categoryId).ToList();
        }
        public JsonResult LoadSubCatBycategoryId2(int categoryId)
        {
            var subcategoriesList = Getsubcategories2(categoryId);
            var subcategoriesData = subcategoriesList.Select(m => new SelectListItem()
            {
                Text = m.Name.ToString(),
                Value = m.Specialty_ID.ToString(),
            });
            return Json(subcategoriesData, JsonRequestBehavior.AllowGet);
        }
        private IList<EmployeeOfClinic> Getsubcategories3(int categoryId)
        {
            
            return db.EmployeeOfClinic.Where(m => m.EmployeeID == categoryId).ToList();
        }
        public JsonResult LoadSubCatBycategoryId3(int categoryId)
        {
            var subcategoriesList = Getsubcategories3(categoryId);
            var subcategoriesData = subcategoriesList.Select(m => new SelectListItem()
            {
                Text = m.Clinic.Name.ToString(),
                Value = m.Employee.id.ToString(),
            });
            return Json(subcategoriesData, JsonRequestBehavior.AllowGet);
        }
    }


}
