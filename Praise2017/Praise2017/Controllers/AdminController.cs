using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

        public PartialViewResult UserControlBtn()
        {
           
            return PartialView();
        }

        public PartialViewResult AddUser()
        {
            return PartialView(new Account());
        }

          [HttpPost]
        public PartialViewResult AddUser([Bind(Include ="Name,Alias,Role")] Account accounts)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Accounts.Add(accounts);
                    db.SaveChanges();
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return PartialView();
        }

        public PartialViewResult DeleteUser()
        {
            return PartialView();
        }

        //[HttpPost]
        //public PartialViewResult DeleteUser()
        //{
        //    return PartialView();
        //}
    }
}
