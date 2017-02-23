using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Praise2017.Abstract;
using Praise2017.Models;
using Praise2017.Concrete;

namespace Praise2017.Controllers
{
    public class HomeController : Controller
    {
        //public IAccountRepo repository;
        //public HomeController(IAccountRepo detailRepo)
        //{
        //    repository = detailRepo;
        //}
        // GET: Home
        //public ViewResult DetailList()
        //{
        //    return View(repository.Details);
        //}

        public ActionResult DetailList()
        {
            
            return View(repository.Details);
        }

    }
}