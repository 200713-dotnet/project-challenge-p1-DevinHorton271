using System;
using System.Collections.Generic;

namespace Project_1.Domain.Models
{
    public class OrderModel : AModel 
    {
        public List<PizzaModel> Pizzas {get; set;}
    }
}