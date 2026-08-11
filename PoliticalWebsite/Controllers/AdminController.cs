using PoliticalWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoliticalWebsite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminDashboard(Admin model)
        {
            if (Session["LoginId"] == null)
            {
                return RedirectToAction("Login","Home");
            }
            else
            {

                Admin newdata = new Admin();
                try
                {
                    DataSet Ds = newdata.GetDetails();
                    ViewBag.GalleryImage = Ds.Tables[0].Rows[0]["GalleryImage"].ToString();
                    ViewBag.NewsImage = Ds.Tables[0].Rows[0]["NewsImage"].ToString();
                    ViewBag.EventImage = Ds.Tables[0].Rows[0]["EventImage"].ToString();
                    ViewBag.Contact = Ds.Tables[0].Rows[0]["Contact"].ToString();
                }
                catch (Exception ex)
                {
                    TempData["Dashboard"] = ex.Message;
                }


                List<Admin> lst = new List<Admin>();
                DataSet ds = model.ContactDetails();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        Admin obj = new Admin();
                        obj.Pk_ContactId = r["Pk_ContactId"].ToString();
                        obj.Name = r["Name"].ToString();
                        obj.Email = r["Email"].ToString();
                        obj.Mobile = r["Mobile"].ToString();
                        obj.Subject = r["Subject"].ToString();
                        obj.Message = r["Message"].ToString();
                        obj.Date = r["Date"].ToString();
                        lst.Add(obj);
                    }
                    model.lstcontact = lst;
                }
            }
            return View(model);

        }

        public ActionResult ContactDetails(Admin model)
        {
            ViewBag.PageName = "ContactDetails";
            if (Session["LoginId"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                List<Admin> lst = new List<Admin>();
                DataSet ds = model.ContactDetails();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        Admin obj = new Admin();
                        obj.Pk_ContactId = r["Pk_ContactId"].ToString();
                        obj.Name = r["Name"].ToString();
                        obj.Email = r["Email"].ToString();
                        obj.Mobile = r["Mobile"].ToString();
                        obj.Subject = r["Subject"].ToString();
                        obj.Message = r["Message"].ToString();
                        obj.Date = r["Date"].ToString();
                        lst.Add(obj);
                    }
                    model.lstcontact = lst;
                }
            }
            return View(model);
        }
        public ActionResult KushahariMahotsavDetails(Admin model)
        {
            ViewBag.PageName = "KushahariMahotsavDetails";
            if (Session["LoginId"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                List<Admin> lst = new List<Admin>();
                DataSet ds = model.KushahariMahotsavDetails();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        Admin obj = new Admin();
                        obj.Pk_ContactId = r["Pk_MahotsavId"].ToString();
                        obj.Name = r["Name"].ToString();
                        obj.FatherName = r["FatherName"].ToString();
                        obj.Email = r["Email"].ToString();
                        obj.Mobile = r["Mobile"].ToString();
                        obj.WhatsappNo = r["WhatsappNo"].ToString();
                        obj.State = r["State"].ToString();
                        obj.Address = r["Address"].ToString();
                        obj.Subject = r["Subject"].ToString();
                        obj.Message = r["Message"].ToString();
                        obj.Date = r["Date"].ToString();
                        lst.Add(obj);
                    }
                    model.lstKushahariMahotsav = lst;
                }
            }
            return View(model);
        }
        public ActionResult YouthConversationDetails(YouthConversation model)
        {
            ViewBag.PageName = "YouthConversationDetails";
            if (Session["LoginId"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                List<YouthConversation> lst = new List<YouthConversation>();
                DataSet ds = model.YouthConversationDetails();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        YouthConversation obj = new YouthConversation();
                        obj.Pk_Id = r["Pk_Id"].ToString();
                        obj.FullName = r["FullName"].ToString();
                        obj.FatherName = r["FatherName"].ToString();
                        obj.Age = r["Age"].ToString();
                        obj.MobileNo = r["MobileNo"].ToString();
                        obj.Email = r["Email"].ToString();
                        obj.Address = r["Address"].ToString();
                        obj.InstituteName = r["InstituteName"].ToString();
                        obj.Course = r["Course"].ToString();
                        obj.Date = r["Date"].ToString();
                        lst.Add(obj);
                    }
                    model.lstYouthConversation = lst;
                }
            }
            return View(model);
        }
    }
}