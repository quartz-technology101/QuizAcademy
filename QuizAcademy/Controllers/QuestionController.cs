using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizAcademy.Controllers
{
    [Authorize(Roles="CanManageQuestions")]
    public class QuestionController : Controller
    {
        [Route("question")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("question/new")]
        public ActionResult New()
        {
            return View("QuestionForm");
        }
    }
}