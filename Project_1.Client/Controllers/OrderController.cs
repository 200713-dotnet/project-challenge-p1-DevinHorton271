using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Project_1.Client.ViewModels;
using Project_1.Domain.Factories;
using Project_1.Domain.Models;
using Project_1.Storing;
//please work

namespace Project_1.Client.Controllers
{
    public class OrderController : Controller
    {
        private readonly Project_1DbContext _db;

        public OrderController(Project_1DbContext dbContext)
        {
            _db = dbContext;
        }



        public IActionResult Start()
        {
            return View("Order", new PizzaViewModel());
        }
        public IActionResult PlaceOrder(PizzaViewModel pvm)
        {
            CrustModel c = new CrustModel() { Name = pvm.Crust };
            SizeModel s = new SizeModel() { Name = pvm.Size };
            ToppingModel t = new ToppingModel() { Name = pvm.Toppings[0].Name };
            PizzaModel p = new PizzaModel() { Crust = c, Size = s, Topping = new List<ToppingModel>() { t } };
            OrderModel o = new OrderModel() { Pizzas = new List<PizzaModel>() { p } };
            _db.Orders.Add(o);
            return RedirectToPage("/Home Page");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(PizzaViewModel pizzaViewModel)
        {
            if (ModelState.IsValid)
            {
                var p = new PizzaFactory(); //sends pizza data to be built
                return View("User");
            }
            return View("Order", pizzaViewModel); // shows order page again
        }
    }
}