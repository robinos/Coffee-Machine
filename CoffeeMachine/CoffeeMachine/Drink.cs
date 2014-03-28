using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineProject
{
    /**
     * The Drink class - a base class for all drinks available for the coffee machine.
     * Used in the class CoffeeMachine.
     */
    public class Drink
    {
        private int id;
        private string name;
        private string desc;
        private int type;
        private decimal price;
        //since all drinks for this machine use either hot or cold water, it is a simple boolean
        private int sugarCount;
        private int milkCount;
        private int usesWater;
        private bool isCarbonated = false;

        /*
         * Constructor for Drink
         * 
         * int id: a unique drink id as a 3 digit integer
         * string name: a name for the drink (15 characters or less) 
         * string desc: a description of the drink (45 characters or less)
         * float price: the price of the drink
         * int type: an integer for the type of drink (0=normal, 1=coffee)
         * bool hot_water: true for hot water, false for cold
         * bool sugar: true if the drink requires sugar, otherwise false
         * int milk_count: how many measures (1 unit) of milk to add 
         */
        public Drink(int id, string name, string desc, int type, decimal price, int usesWater,
            bool isCarbonated, int sugarCount, int milkCount)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.type = type;
            this.price = price;
            this.usesWater = usesWater;
            this.isCarbonated = isCarbonated;
            this.sugarCount = sugarCount;
            this.milkCount = milkCount;
        }

        //Get and Set for the unique drink id
        public int DrinkID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        //Get and Set for the drink name
        public string DrinkName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Get and Set for the drink description
        public string DrinkDesc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }

        //Get and Set for the drink type (0=normal, 1=coffee)
        public int DrinkType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        //Get and Set for the drink price
        public decimal DrinkPrice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        //Get and Set for the hot/cold water use (0=none, 1=cold, 2=hot)
        public int WaterUse
        {
            get
            {
                return usesWater;
            }
            set
            {
                usesWater = value;
            }
        }

        //Get and Set for drink carbonation
        public bool IsCarbonated
        {
            get
            {
                return isCarbonated;
            }
            set
            {
                isCarbonated = value;
            }
        }

        //Get and Set for sugar amount
        public int SugarCount
        {
            get
            {
                return sugarCount;
            }
            set
            {
                sugarCount = value;
            }
        }

        //Get and Set for milk amount
        public int MilkCount
        {
            get
            {
                return milkCount;
            }
            set
            {
                milkCount = value;
            }
        }

    }
}
