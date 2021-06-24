using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webtest410716217.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index(float? number)
        {
            var result = "";
            if (number.HasValue && number <= 7 && 0 < number)
            {
                result = "星期" + number;
            }else if(number < 0 && number >= 8)
            {
                result = "輸入錯誤，無法查詢。";
            }

            ViewBag.result = result;
            return View();
        }
    }
}