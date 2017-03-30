using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using System.Web;

namespace Praise2017.Controllers
{
    public class HomeController : Controller
    {
        //获取当前登录用户
        string user = System.Environment.UserName;



        private EFDbContext db = new EFDbContext();


        public PartialViewResult DetailList()
        {
            var query = from b in db.Details
                            //orderby b.UpdateDate
                        select b;

            return PartialView(query);
        }


        //显示本月排行
        //public PartialViewResult TopPraise()
        //{

        //}

        ////显示当前用户信息
        public PartialViewResult PerInfo()
        {
            //得到赞总数
            //发出赞总数
            //当前用户角色 都要被显示
            var info = from b in db.Accounts
                       where b.Alias == user
                       select b;
            return PartialView(info);
        }

        //查询用户

    }
}