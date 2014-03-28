using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CoffeeMachineProject
{
    /*
     * The CoffeeMachine class runs the coffee machine simulation, and facilitates communication
     * between the UI in CoffeeMachineForms, with the logic in the Machine class, and the Drink
     * and Coffee data objects.
     */
    public class CoffeeMachine
    {
        private Machine myMachine;
        private Dictionary<int, Drink> myDrinkList;
        private static CoffeeMachine myCoffeeMachine;
        private static CoffeeMachineForm myCoffeeMachineForm;
        private DrinkDatabase drinkDatabase = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            myCoffeeMachine = new CoffeeMachine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myCoffeeMachineForm = new CoffeeMachineForm(myCoffeeMachine);
            Application.Run(myCoffeeMachineForm);
        }

        //Constructor for CoffeeMachine
        public CoffeeMachine()
        {
            drinkDatabase = new DrinkDatabase();
            myMachine = new Machine();
            initialise();
        }

        //Get and Set for the drink list
        public Dictionary<int, Drink> DrinkList
        {
            get
            {
                return myDrinkList;
            }

            set
            {
                myDrinkList = value;
            }
        }

        /*
         * The initialise method fills the drink list with drinks.  It first attempts to do this
         * using a database, but failing that, uses hardcoded default drinks
         */
        private void initialise()
        {
            bool success = false;

            //Test code for entering values into the database:
            //string query = "INSERT INTO drinks (idDrinks, DrinksName, DrinksDesc, DrinksType,DrinksPrice, UsesWater, IsCarbonated, CountSugar, CountMilk, CountCoffee) VALUES('001', 'Carbonated Water', 'A nice cold glass of carbonated water.', '0', '02.00', '1', '1', '0', '0', '0')";
            //drinkDatabase.Insert(query);

            //Fill the drink list from the database
            if (drinkDatabase.fillDictionary())
            {
                myDrinkList = drinkDatabase.DrinkList;
            }

            //If the drink list contains values, the read from database is assumed to have been a success
            if (myDrinkList != null) success = true;

            //If initialising from the database failed, this fills myDrinkList with default values
            if (!success)
            {
                myDrinkList = new Dictionary<int, Drink>();                

                //Drink: id, name, desc, type, price, water use, carbonation, sugar amount, milk amount
                Drink coldWater = new Drink
                    (000, "Cold Water", "A nice cold glass of water.", 0, 01.00m, 1, false, 0, 0);
                myDrinkList.Add(000, coldWater);
                Drink carbonatedWater = new Drink
                    (001, "Carbonated Water", "A nice cold glass of carbonated water.", 0, 02.00m, 1, true, 0, 0);
                myDrinkList.Add(001, carbonatedWater);
                Drink hotWater = new Drink
                    (002, "Tea", "A nice hot cup of tea water.", 0, 05.00m, 2, false, 0, 0);
                myDrinkList.Add(002, hotWater);
                Drink milk = new Drink
                    (003, "Milk", "A nice cold glass of milk.", 0, 05.00m, 0, false, 0, 1);
                myDrinkList.Add(003, milk);

                //Coffee: id, name, desc, type, price, water use, carbonation, sugar amount, milk amount, coffee amount
                Coffee blackCoffee = new Coffee
                    (010, "Black Coffee", "A steaming cup of black coffee.", 1, 10.00m, 2, false, 0, 0, 1);
                myDrinkList.Add(010, blackCoffee);
                Coffee sugarCoffee = new Coffee
                    (011, "Coffee with Sugar", "A steaming cup of coffee with added sugar.", 1, 15.00m, 2, false, 1, 0, 1);
                myDrinkList.Add(011, sugarCoffee);
                Coffee milkCoffee = new Coffee
                    (012, "Coffee with Milk", "A steaming cup of coffee with added milk.", 1, 15.00m, 2, false, 0, 1, 1);
                myDrinkList.Add(012, milkCoffee);
                Coffee milkSugarCoffee = new Coffee
                    (013, "House Coffee", "A steaming cup of coffee with added sugar and milk.", 1, 20.00m, 2, false, 1, 1, 1);
                myDrinkList.Add(013, milkSugarCoffee);
            }
        }

        //Connects the water to the machine (called from the GUI since there is no actual machine)
        public void connectWater()
        {
            myMachine.WaterConnected = true;
        }

        //Disconnected the water from the machine (called from the GUI since there is no actual machine)
        public void disconnectWater()
        {
            myMachine.WaterConnected = false;
        }

        //Refills the Sugar (called from the GUI since there is no actual machine)
        public void refillSugar()
        {
            myMachine.refillSugar();
        }

        //Refills the Milk (called from the GUI since there is no actual machine)
        public void refillMilk()
        {
            myMachine.refillMilk();
        }

        //Refills the Coffee (called from the GUI since there is no actual machine)
        public void refillCoffee()
        {
            myMachine.refillCoffee();
        }
        
        //Checks that the machine successfully received payment (such as a physical coin
        //or bank transfer)
        public bool addPayment(decimal customerPayment)
        {
            if (myMachine.checkPaymentSuccessfullyReceived(customerPayment))
                return true;
            else return false;
        }

        /*
         * brewDrink checks if the drink is paid for (according to payment received successfully
         * by the machine) and then call upon the machine to brew the drink.  On failure an error
         * message is returned, other the message "Success!" is returned.
         */
        public bool brewDrink(Drink newDrink)
        {
            string message = "";

            if (myMachine.isPaidFor(newDrink))
            {
                message = myMachine.brewDrink(newDrink);

                if (message.Equals("Success!"))
                {
                    myCoffeeMachineForm.displayMessage("Your " + newDrink.DrinkName + " is ready. Enjoy!", "Message", false);
                    return true;
                }
                else
                {
                    myCoffeeMachineForm.displayMessage(message, "Important", true);
                }  
            }
            else myCoffeeMachineForm.displayMessage("Additional payment is required.", "Message", false);

            return false;
        }

        //Calls the abort on the machine, to simulate a fund return
        public void abort()
        {
            myMachine.abort();
        }

    }
}
