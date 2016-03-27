using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class 客戶詳細資料ViewController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();
        // GET: 客戶詳細資料View
        public ActionResult Index()
        {
            var data = db.客戶詳細資料View;
            return View(data);
        }
    }
}