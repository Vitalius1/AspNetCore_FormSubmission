using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // if(ViewBag.errors == null){
            //     ViewBag.errors = false;
            // }   
            ViewBag.errors = ModelState.Values;
            return View();
        }
        
        [HttpPost]
        [Route("")]
        public IActionResult Register(User NewUser)
        {
            if(!ModelState.IsValid)
            {
                System.Console.WriteLine("%%%%%%%%%%%%^^^^^^^^^^^^^^^^^^^^^^^^5%%%%%%%%%%%%%%%");
                // TempData["errors"] = ModelState.Values;
                // ViewBag.errors = ModelState.Values;
                // List<string> Errors = new List<string>();
                // foreach(var error in ModelState.Values){
                //     Errors.Add(error.Errors[0].ErrorMessage);
                //     // System.Console.WriteLine(error.Errors[0].ErrorMessage);
                // }
                // foreach(string er in Errors)
                // {
                //     System.Console.WriteLine(er);
                // }
                ViewBag.errors = ModelState.Values;
                return View("Index");
            }else
            {
            System.Console.WriteLine("*****************");
            return View("success");
            }
        }
    }
}
