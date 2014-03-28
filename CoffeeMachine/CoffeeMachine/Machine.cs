using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineProject
{
    /*
     * The Machine class simulates machine attributes and actions, while only pretending to
     * hold code to actually control the brewing, change counting, and change release mechanisms.
     * 
     * Though such a machine might actually sense the amount of ingredients contained afted a refill,
     * in this case it is simply refilled to 10 units.
     * 
     * Used in the class CoffeeMachine.
     */
    public class Machine
    {
        private bool waterConnected = false;
        private int currentSugar = 10;
        private int currentMilk = 10;
        private int currentCoffee = 10;
        private decimal paymentReceived = 00.00m;
        private decimal machineTotal = 00.00m;

        /*
         * Constructor for Machine
         */
        public Machine()
        {
            //Imaginary machine initialisation code
        }

        //Get and Set for the water connection
        public bool WaterConnected
        {
            get
            {
                return waterConnected;
            }
            set
            {
                waterConnected = value;
            }
        }

        //Get and Set for the current sugar level
        public int SugarLevel
        {
            get
            {
                return currentSugar;
            }
            set
            {
                currentSugar = value;
            }
        }

        //Get and Set for the current milk level
        public int MilkLevel
        {
            get
            {
                return currentMilk;
            }
            set
            {
                currentMilk = value;
            }
        }

        //Get and Set for the current coffee level
        public int CoffeeLevel
        {
            get
            {
                return currentCoffee;
            }
            set
            {
                currentCoffee = value;
            }
        }

        /*
         * Adds payment to paymentReceived, theoretically only if the machine
         * successfully receives payment (by coin or transfer).
         */
        public bool checkPaymentSuccessfullyReceived(decimal payment)
        {
            //Imaginary machine code for counting the coins received
            //and holding them in a temporary receptacle (payment is
            //not added to the machine total until a drink is successfully
            //brewed).

            paymentReceived += payment;
            return true;
        }

        /*
         * The checkPayment method checks that enough payment has been received by the
         * machine for the current drink.
         * 
         * Drink newDrink: is the drink to be made, defined by the Drink class
         * Returns: a display string for customer feedback 
         */
        public bool isPaidFor(Drink newDrink)
        {
            if (paymentReceived >= newDrink.DrinkPrice) return true;
            else return false;
        }

        /*
         * The brewDrink method handles the logic-side details of ingredients and calls
         * brew if the ingredients exist to create the drink.
         * 
         * Drink newDrink: is the drink to be made, defined by the Drink class
         * Returns: a display string for customer feedback
         */
        public string brewDrink(Drink newDrink)
        {
            //Checks first that water is connected to the machine
            if (waterConnected)
            {
                //Checks the sugar and milk levels, if the drink requires them
                if(newDrink.SugarCount >= 1)
                {
                    if (checkSugar(newDrink.SugarCount)) { }
                    else return "Not enough sugar.  Please contact administration to refill this ingredient.";
                }
                if (newDrink.MilkCount >= 1)
                {
                    if (checkMilk(newDrink.MilkCount)) { }
                    else return "Not enough milk. Please contact administration to refill this ingredient.";
                }
                //Coffee only needs to be checked for coffee drinks, which are given the type 1 to distinguish
                //them from other drinks
                if (newDrink.DrinkType == 1)
                {
                    //In case a non-Coffee class drink is wrongly defined as coffee, we have
                    //a try-catch
                    try
                    {
                        Coffee coffee = (Coffee)newDrink;

                        if (coffee.CoffeeCount >= 1)
                        {
                            if (checkCoffee(coffee.CoffeeCount)) { }
                            else return "Not enough coffee. Please contact administration to refill this ingredient.";
                        }
                    }
                    catch (Exception e)
                    {
                        return "Error in drink definition.  Please contact the service helpdesk.";
                    }
                }

                //Upon reaching this point, all ingredients can be assured
                if (newDrink.SugarCount >= 1) currentSugar -= 1;
                if (newDrink.MilkCount >= 1) currentMilk -= newDrink.MilkCount;
                if (newDrink.DrinkType == 1)
                {
                    Coffee coffee = (Coffee)newDrink;
                    currentCoffee -= coffee.CoffeeCount;
                }

                //The payment goes through, or the coins are moved to main storage
                machineTotal = paymentReceived - newDrink.DrinkPrice;
                paymentReceived = 00.00m;
                
                //Imaginary code to return excess customer funds
                
                //Calls brew, to actually brew the drink
                brew(newDrink);
                return "Success!";
            }
            else return "Water not connected. Please contact the service helpdesk.";
        }

        /*
         * The checkSugar method checks if there is enough sugar to create the drink
         * 
         * returns: true if there is enough sugar, or false is there is not
         */
        public bool checkSugar(int sugarAmount)
        {
            if (currentSugar >= sugarAmount) return true;
            else return false;
        }

        /*
         * The checkMilk method checks if there is enough milk to create the drink
         * 
         * returns: true if there is enough milk, or false is there is not
         */
        public bool checkMilk(int milkAmount)
        {
            if (currentMilk >= milkAmount) return true;
            else return false;
        }

        /*
         * The checkCoffee method checks if there is enough coffee to create the drink
         * 
         * returns: true if there is enough coffee, or false is there is not
         */
        public bool checkCoffee(int coffeeAmount)
        {
            if (currentCoffee >= coffeeAmount) return true;
            else return false;
        }

        /*
         * Brews the drink
         */
        private bool brew(Drink newDrink)
        {
            //Imaginary machine code for actually brewing the drink

            return true;
        }

        //Sets sugar refilled to 10 units
        public void refillSugar()
        {
            currentSugar = 10;
        }

        //Sets milk refilled to 10 units
        public void refillMilk()
        {
            currentMilk = 10;
        }

        //Sets coffee refilled to 10 units
        public void refillCoffee()
        {
            currentCoffee = 10;
        }

        /*
         * Aborts the current drink purchase
         */
        public void abort()
        {
            paymentReceived = 00.00m;
            
            //Imaginary machine code for returning customer funds
        }
    }
}
