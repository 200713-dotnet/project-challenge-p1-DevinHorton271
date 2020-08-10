using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project_1.Domain.Models;

namespace Project_1.Client.ViewModels
{
    public class PizzaViewModel
    {
        //sent out to the client
        public List<CrustModel> Crusts { get; set; }
        public List<SizeModel> Sizes { get; set; }
        public List<ToppingModel> Toppings { get; set; }
        public List<CheckBoxTopping> Toppings2 { get; set; }

        //sent back by client
        [Required]
        public string Crust { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        [Range(2, 5)]
        public List<string> SelectedToppings { get; set; }
        public List<CheckBoxTopping> SelectedToppings2 { get; set; }

        public PizzaViewModel()
        {
            Crusts = new List<CrustModel>() { new CrustModel() { Name = "Stuffed" }, new CrustModel() {Name = "Handtossed"}, new CrustModel() {Name = "Flatbread"}};
            Sizes = new List<SizeModel>() { new SizeModel() {Name = "Small"}, new SizeModel() {Name = "Medium"}, new SizeModel() {Name = "Large"}};
            Toppings = new List<ToppingModel>() {new ToppingModel() { Name = "Pepperoni"}, new ToppingModel() {Name = "Pineapple"}, new ToppingModel() {Name = "Canadian Bacon"}, new ToppingModel() {Name = "Onion"}, new ToppingModel() {Name = "Anchovies"}};
            SelectedToppings2 = new List<CheckBoxTopping>(){};
        }
    }
}


public class CheckBoxTopping : ToppingModel
{
    public string Text { get; set; }
    public bool IsSelected { get; set; }
}