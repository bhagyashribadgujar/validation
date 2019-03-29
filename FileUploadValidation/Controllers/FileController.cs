using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FileUploadValidation.Models;
using System.Web.UI.WebControls;


namespace FileUploadValidation.Controllers
{
    public class FileController : Controller
    {
        //  
        // GET: /File/  

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult fileupload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult fileupload(HttpPostedFileBase file)
        {
            FileUpload1 fs = new FileUpload1();
            fs.filesize = 550;
            string us = fs.UploadUserFile(file);
            if (us != null)
            {
                ViewBag.ResultErrorMessage = fs.ErrorMessage;
            }
            return View();
        }
    }
}