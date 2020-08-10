using System.Collections.Generic;
using Project_1.Domain.Models;

namespace Project_1.Domain.Factories
{
    public class PizzaFactory : AFactory
    {
        public AModel Create()
        {
            var p = new PizzaModel();
            
            p.Crust = new CrustModel();
            p.Size = new SizeModel();
            p.Topping = new List<ToppingModel>{new ToppingModel()};

            return p;
        }
    }
}