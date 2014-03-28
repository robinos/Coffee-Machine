using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineProject
{
    /**
     * The Coffee class - a subclass of Drink, used for all coffee subclass drinks.  This wouldn't
     * normally need to be a subclass (Drink could handle it), but I need to train a little with
     * inheritance.
     * Used in the class CoffeeMachine.
     */
    public class Coffee:Drink
    {
        private int coffeeCount;

        /*
         * Constructor for Coffee
         * 
         * int id, string name, string desc, float price, int type, bool hot_water,
         *    int sugar, int milk_count : see base class
         * int coffee_count: how many measures (1 unit) of coffee to add  
         */
        public Coffee(int id, string name, string desc, int type, decimal price, int usesWater,
            bool isCarbonated, int sugarCount, int milkCount, int coffeeCount)
            : base(id, name, desc, type, price, usesWater, isCarbonated, sugarCount, milkCount)
        {
            this.coffeeCount = coffeeCount;       
        }

        //Get and Set for coffee amount
        public int CoffeeCount
        {
            get
            {
                return coffeeCount;
            }
            set
            {
                coffeeCount = value;
            }
        }

    }
}
