using CoachIT.Data;
using CoachIT.Data.Infrastructure;
using CoachIT.Data.Repositories;
using CoachIT.Data.Repositories.RepositoriesFolder;
using CoachIT.Domain.Entities;
using CoachIT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoachIT.Service;

namespace CoachIT.MVC.Controllers
{
    public class HomeController : Controller
    {




        private readonly ICategorieService productService;

        public HomeController(ICategorieService productService)
        {
            this.productService = productService;
            var c = productService.GetCategories();





        }


        //private CategorieRepository repo ;

        //public HomeController()
        //{

        //    try { 
        //    repo = new CategorieRepository(fac);

        //   var a= repo
        //    }
        //    catch(Exception exc)
        //    {

        //    }
        //}



        public ActionResult Detail()
        {
            var c = productService.GetCategories();
            return View(c);
        }

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
    }
}