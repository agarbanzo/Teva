using System;
using System.Web;
using System.Web.Mvc;
using VOCE_TEVA_Asthma_Single_Page_Website.Api;
using VOCE_TEVA_Asthma_Single_Page_Website.Models;

namespace VOCE_TEVA_Asthma_Single_Page_Website.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpCookie cookie = new HttpCookie("error");
            if(TempData["error"] == null)
                cookie.Value = "";
            else
                cookie.Value = TempData["error"].ToString();
            this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(EmailModel model)
        {
            try
            {
                TempData["error"] = "Success";
                EmailSender emailSender = new EmailSender();
                emailSender.SendEmail(model);
                return RedirectToAction("Index", "Home");
                
            }
            catch(Exception e)
            {
                TempData["error"] = "Error";
                return RedirectToAction("Index", "Home");
                
            }
        }
    }
}