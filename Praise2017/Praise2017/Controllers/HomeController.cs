using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Praise2017.Abstract;
using Praise2017.Models;

namespace Praise2017.Controllers
{
    public class HomeController : Controller
    {
        public IAccountRepo repository;
        public HomeController(IAccountRepo detailRepo)
        {
            this.repository = detailRepo;
        }
        // GET: Home
        public ViewResult datailList()
        {
            return View(repository.Details);
        }
    }
}