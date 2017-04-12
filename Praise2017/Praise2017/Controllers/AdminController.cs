using System;
using System.Collections;
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

                             select b;

           // IEnumerable people = member.ToArray();
           // IEnumerable people = new IEnumerable(member);
                return PartialView(member);
            
        }

        public PartialViewResult AddUser()
        {
           
            return PartialView();
        }
    }
}
