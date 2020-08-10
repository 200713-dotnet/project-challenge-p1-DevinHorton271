using System.Collections.Generic;

namespace Project_1.Domain.Models
{
    public class PizzaModel : AModel
    {
        public CrustModel Crust {get; set;}
        public SizeModel Size {get; set;}
        public List<ToppingModel> Topping {get; set;}
    }
}