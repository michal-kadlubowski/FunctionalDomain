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
            var tasks = new List<KanbanBoard.Task>();
            tasks.Add(new KanbanBoard.Task("Title",null, KanbanBoard.Status.Done, KanbanBoard.TaskType.Bug));
            var dtoResultList = tasks.Select(t => new TaskDto(t)).ToList(); 
            return Json(dtoResultList);
        }        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
