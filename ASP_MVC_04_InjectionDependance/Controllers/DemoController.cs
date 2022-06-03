using ASP_MVC_04.Servcice;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_04_InjectionDependance.Controllers
{
    public class DemoController : Controller
    {
        public MonSuperService _Service1 { get; set; }
        public MonSuperService _Service2 { get; set; }

        public DemoController(MonSuperService service1, MonSuperService service2)
        {
            _Service1 = service1;   
            _Service2 = service2;
        }

        public IActionResult Index()
        {
            string msg1 = _Service1.GetMessage();
            string msg2 = _Service2.GetMessage();

            ViewBag.Message1 = msg1;
            ViewBag.Message2 = msg2;
            return View();
        }
    }
}
