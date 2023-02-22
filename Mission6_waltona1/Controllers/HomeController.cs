using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_waltona1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_waltona1.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext maContext { get; set; }

        // Constructor
        public HomeController(MovieFormContext someName)
        {
            maContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = maContext.Categories.ToList();

            return View("MovieForm");
            //return View(new FormResponse());
            //maybe new FormResponse
        }

        [HttpPost]
        public IActionResult MovieForm (FormResponse response)
        {
            if(ModelState.IsValid)
            {
                maContext.Add(response);
                maContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = maContext.Categories.ToList();

                return View(response);
            }
        }
        public IActionResult MyPodcasts()
        {
            return View("MyPodcasts");
        }
        [HttpGet]
        public IActionResult WaitList ()
        {
            var applications = maContext.Responses
                .Include(x => x.category)
                .ToList();

            return View(applications);
        }
        [HttpGet]
        public IActionResult Edit(int formid)
        {
            ViewBag.Categories = maContext.Categories.ToList();

            var Form = maContext.Responses.Single(x => x.FormId == formid);

            return View("MovieForm", Form);
        }
        [HttpPost]
        public IActionResult Edit(FormResponse fr)
        {

            maContext.Update(fr);
            maContext.SaveChanges();

            return RedirectToAction("WaitList");
        }
        [HttpGet]
        public IActionResult Delete(int formid)
        {
            var Form = maContext.Responses.Single(x => x.FormId == formid);

            return View(Form);
        }
        [HttpPost]
        public IActionResult Delete(FormResponse fr)
        {
            maContext.Responses.Remove(fr);
            maContext.SaveChanges();
            return RedirectToAction("WaitList");
        }
    }
}
