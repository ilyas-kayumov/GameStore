using System.Linq;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoreContext context;

        public HomeController(StoreContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Games.ToList());
        }

        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.GameId = id;
            return View();
        }

        [HttpPost]
        public IActionResult Buy(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();

            return Redirect($"~/Home/Completed?user={order.User}");
        }

        public IActionResult Completed(string user)
        {
            ViewBag.User = user;
            return View();
        }
    }
}
