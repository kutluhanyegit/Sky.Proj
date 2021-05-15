using Microsoft.AspNetCore.Mvc;
using Sky.Business.Concrate;
using Sky.DataAccess.Concrate.EntityFramework;
using Sky.Entities.Concrate;

namespace Sky.UI.Controllers
{
    [Route("model-yonetimi")]
    public class model_yonetimiController:Controller
    {
        public IActionResult index()
        {
          return View();
        }
    }
}