using System.Web.Mvc;

namespace RIA.Train.Web.Controllers
{
    public class AboutController : TrainControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}