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
        public PartialViewResult Admin()
        {
            //取出Name和头像
            var member = from b in db.Accounts
                       
                         select new { b.Name, b.Picture };
                                         
            //string[] people = member.ToArray();

            return PartialView(member);
        }

    }
}
