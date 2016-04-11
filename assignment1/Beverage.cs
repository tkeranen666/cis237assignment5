using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace assignment1
{
    class Beverage
    {
        beveragetkeranenEntities BeverageEntities = new beveragetkeranenEntities();

        public void PrintList()
        {
            // Print list of beverages
            foreach (Beverage beverage in BeverageEntities.Beverages)
            {
                Console.WriteLine(beverage.id + beverage.name + beverage.pack + beverage.price);
            }
        }

        public string Search(string searchQuery)
        {
            // Search for a specific item
            Beverage bevToFind = BeverageEntities.Beverages.Find(searchQuery);
            return searchQuery;
        }

        public void AddBeverage(string id, string name, string pack, string price, string active)
        {
            // Add a new Item to the list
            Beverage addBeverage = new Beverage();

            addBeverage.id = id;
            addBeverage.name = name;
            addBeverage.pack = pack;
            addBeverage.price = Convert.ToDecimal(price);
            addBeverage.active = active;

            try
            {
                BeverageEntities.Beverages.Add(addBeverage);
                BeverageEntities.SaveChanges();
            }
            catch (Exception e)
            {
                BeverageEntities.Beverages.Remove(addBeverage);
                Console.WriteLine("Beverage already listed.");
            }
        }
    }
}
