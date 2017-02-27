using System.Linq;
using System.Web.Mvc;

namespace Praise2017.Controllers
{
    public class HomeController : Controller
    {

        private EFDbContext db = new EFDbContext();
       // var db = new EFDbContext;

        public PartialViewResult DetailList()
        {
            var query = from b in db.Details
                        //orderby b.UpdateDate
                        select b;
            
            return PartialView(query);
        }



    }
}