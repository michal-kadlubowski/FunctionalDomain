using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FunctionalDomain.DomainLogic;
using FunctionalDomain.Web.Models;

namespace FunctionalDomain.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var xx = new KanbanBoard.Task("Title","Description", KanbanBoard.Status.Done, KanbanBoard.TaskType.Bug);
            ViewData["Message"] = "Functional domain";

            return View();
        }

        public IActionResult AllTasks()
        {
            var result = new List<KanbanBoard.Task>();
            result.Add(new KanbanBoard.Task("Title","Description", KanbanBoard.Status.Done, KanbanBoard.TaskType.Bug));
            return Json(result);
        }        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
