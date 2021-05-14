using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizAcademy.Controllers
{
    [AllowAnonymous]
    public class QuizController : Controller
    {
        [Route("quick-round")]
        public ActionResult QuickRound()
        {
            return View();
        }




        [Route("ultimate-round")]
        public ActionResult UltimateRound()
        {
            return View();
        }
    }
}