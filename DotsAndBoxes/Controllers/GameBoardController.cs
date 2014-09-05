using System.Web.Mvc;

namespace DotsAndBoxes.Controllers
{
    public class GameBoardController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            return new JsonResult();
        }



    }
}
