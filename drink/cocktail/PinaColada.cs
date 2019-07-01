using System;
using System.Collections.Generic;
using el_chupitos_pattern.Drink.ingredient;
using el_chupitos_pattern.drink.simpleDrink;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern.Drink.cocktail
{
    public class PinaColada:ICocktail
    {
        public string Name { get; }
        public double Price { get; set; }
        public Dictionary<string, int> Ingredients { get; }
        public Stock Stock { get; set; }

        public PinaColada(Stock stock)
        {
            Name = "Piña Colada";
            Price = 6.0;
            Ingredients = new Dictionary<string, int> {{Pineapple.NAME, 2}, {CoconutMilk.NAME, 4}, {Rum.NAME, 2}};
            Stock = stock;
            stock.RemoveItem(Pineapple.NAME, 2);
            stock.RemoveItem(CoconutMilk.NAME, 4);
            stock.RemoveItem(Rum.NAME, 2);
        }
        public void Display()
        {
            Console.WriteLine(Name + " " + Price + " €");
        }
        public double GetPrice()
        {
            return Price;
        }
    }
}