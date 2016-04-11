using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Beverage
    {
        beveragetkeranenEntities BeverageEntities = new beveragetkeranenEntities();

        public void PrintList()
        {
            foreach (Beverage beverage in BeverageEntities.Beverages)
            {
                // Console.WriteLine(beverage.id + beverage.name + beverage.pack + beverage.price + beverage.active);
            }
        }

        public void AddBeverage()
        {

        }
    }
}
