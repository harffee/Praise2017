using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Praise2017.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private EFDbContext db = new EFDbContext();
        public PartialViewResult Details()
        {

            IEnumerable<string> member = from b in db.Accounts
                                         select b.Name;
            string[] people = member.ToArray();

            return PartialView();
        }

    }
}
