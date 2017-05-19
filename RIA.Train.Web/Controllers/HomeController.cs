using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace RIA.Train.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TrainControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}