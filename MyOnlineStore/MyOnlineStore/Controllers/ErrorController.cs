﻿using System.Web.Mvc;

namespace MyOnlineStore.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult FileUploadLimitExceeded()
        {
            return View();
        }
    }
}