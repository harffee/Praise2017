using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Praise2018.Models;
using Praise2018.Abstract;


namespace Praise2018.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin
        private IAccountsRepo repo;
        public AccountController (IAccountsRepo accountRepo)
        {
            this.repo = accountRepo;
        }
        public PartialViewResult UserList()
        {
            
                //取出Name和头像
                //var member = from b in db.Accounts

                             //select b;

           // IEnumerable people = member.ToArray();
           // IEnumerable people = new IEnumerable(member);
                return PartialView(repo);
            
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
        public PartialViewResult AddUser()
        {
            try
            {
                if(ModelState.IsValid)
                {
                    repo.Accounts.(accounts);
                    db.SaveChanges();
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            //return PartialView();

            DeleteUser();
        }

        // 1. 分页
        public PartialViewResult DeleteUser()
        {
            var member = from b in db.Accounts

                         select b;
            return PartialView(member);
        }

        //[HttpPost]
        //public PartialViewResult DeleteUser()
        //{
        //    return PartialView();
        //}
    }
}
