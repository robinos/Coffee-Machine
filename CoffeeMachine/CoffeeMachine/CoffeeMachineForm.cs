using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeMachineProject;

namespace CoffeeMachineProject
{
    /**
     * This CoffeeMachineForm partial class contains the action code for pushing buttons
     * and entering amounts.
     * 
     * It uses and is used by CoffeeMachine.
     */
    public partial class CoffeeMachineForm : Form
    {
        private static CoffeeMachine myCoffeeMachine;
        private Dictionary<int, Drink>.ValueCollection drinkCollection;
        private Drink selectedDrink = null;
        private string selectedDrinkName = "";
        private decimal selectedDrinkPrice = 00.00m;
        private decimal paymentAmount = 00.00m;
        private decimal paymentTotal = 00.00m;
        private System.Windows.Forms.ToolTip paymentToolTip;

        /*
         * The constructor for CoffeeMachineForm
         * 
         * myCoffeeMachine: a reference to the main program for calling
         *  logic methods
         */
        public CoffeeMachineForm(CoffeeMachine myCoffeeMachine)
        {
            InitializeComponent();
            CoffeeMachineForm.myCoffeeMachine = myCoffeeMachine;

            // To get the values alone, the Drinks
            drinkCollection = myCoffeeMachine.DrinkList.Values;

            //Run through all the drinks and add their names to the combo box
            foreach (Drink drink in drinkCollection)
            {
                comboBoxDrinkList.Items.Add(drink.DrinkName);
            }

            //Set the default drink (on startup) to index 0 (Water in this case)
            comboBoxDrinkList.SelectedIndex = 0;

            //Sets up a ToolTip so I could test out how they work
            paymentToolTip = new System.Windows.Forms.ToolTip();
        }

        /*
         * This is called when a user clicks on the Brew! button.  If the machine (through CoffeeMachine)
         * successfully brews the brink, success is true, payment is made, change in returned, and the GUI
         * is reset.  Otherwise an error message (via code in CoffeeMachine) will be given to the customer.
         */
        private void buttonBrew_Click(object sender, EventArgs e)
        {
            bool success = false;

            if(selectedDrink != null) {
                //A call is sent for the machine to attempt to brew the drink
                success = myCoffeeMachine.brewDrink(selectedDrink);
            }

            //If successful, change is returned, and the GUI is reset
            if (success == true)
            {
                decimal returnAmount = paymentTotal - selectedDrinkPrice;
                labelReturnAmount.Text = returnAmount.ToString();
                paymentAmount = 00.00m;
                paymentTotal = 00.00m;
                labelTotalPaymentAmount.Text = "00.00";
                maskedTextBoxPaymentAmount.Text = "0000";
            }
        }

        /*
         * On selecting an item in the combo box, the price is displayed for the customer, and
         * a description appears on the info label.
         */
        private void comboBoxDrinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDrinkName = comboBoxDrinkList.Items[comboBoxDrinkList.SelectedIndex].ToString();

            //Searching for a matching drink name from the list - requiring names to be unique.
            foreach (Drink drink in drinkCollection)
            {
                if(drink.DrinkName.Equals(selectedDrinkName))
                {
                    labelPriceAmount.Text = drink.DrinkPrice.ToString();
                    selectedDrinkPrice = drink.DrinkPrice;
                    labelInfo.Text = drink.DrinkDesc;
                    selectedDrink = drink;
                }
            }
        }

        //Gives a way for Sugar to be refilled (simulating actually refilling the machine)
        private void buttonRefillSugar_Click(object sender, EventArgs e)
        {
            myCoffeeMachine.refillSugar();
        }

        //Gives a way for Milk to be refilled (simulating actually refilling the machine)
        private void buttonRefillMilk_Click(object sender, EventArgs e)
        {
            myCoffeeMachine.refillMilk();
        }

        //Gives a way for Coffee to be refilled (simulating actually refilling the machine)
        private void buttonRefillCoffee_Click(object sender, EventArgs e)
        {
            myCoffeeMachine.refillCoffee();
        }

        //Gives a way for the water to be connected (simulating actually connecting the machine)
        private void radioButtonWaterOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWaterOn.Checked) myCoffeeMachine.connectWater();
        }

        //Gives a way for the water to be disconnected (simulating actually disconnecting the machine)
        private void radioButtonWaterOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWaterOff.Checked) myCoffeeMachine.disconnectWater();
        }

        /*
         * Pushing the Pay button makes a payment towards a drink (not bound to the currently
         * selected drink).  The machine will never accept a total amount of 100 or more towards
         * one drink.  If for some reason payment to the machine fails (a stuck coin, or a failed
         * bank transfer) a message is displayed and the transaction is aborted.
         */
        private void buttonPay_Click(object sender, EventArgs e)
        {
            paymentAmount = Decimal.Parse(maskedTextBoxPaymentAmount.Text);

            //No total payment exceeding 99.99 towards one drink
            if ((paymentTotal + paymentAmount) <= 99.99m)
            {
                //Otherwise, add it to the payment total
                if (myCoffeeMachine.addPayment(paymentAmount))
                {
                    paymentTotal += paymentAmount;
                    paymentAmount = 00.00m;
                    labelTotalPaymentAmount.Text = paymentTotal.ToString();
                    maskedTextBoxPaymentAmount.Text = "0000";
                }
                else
                {
                    displayMessage("Payment failed. If funds are not returned contact administration.", "Important", true);
                    abort();
                }
            }
            else displayMessage("This machine will not accept 100 or more credits for a payment.", "Important", true);
        }

        /*
         * When a user attempts to enter a non-number, non-decimal in this field, it is rejected with
         * a tooltip, and an info message.
         */
        private void maskedTextBoxPaymentAmount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            paymentToolTip.ToolTipTitle = "Invalid Input";
            paymentToolTip.Show("Only digits (0-9) are allowed.", maskedTextBoxPaymentAmount, maskedTextBoxPaymentAmount.Location, 5000);
            displayMessage("Only digits (0-9) are allowed.", "Message", false);
        }

        /*
         * When a user attempts to enter a non-number, non-decimal in this field, it is rejected with
         * a tooltip, and an info message.
         * Otherwise paymentAmount is set (but this doesn't seem to fire)
         */
        public void maskedTextBoxPaymentAmount_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                paymentToolTip.ToolTipTitle = "Invalid Decimal Value";
                paymentToolTip.Show("Invalid decimal value.", maskedTextBoxPaymentAmount, 5000);
                displayMessage("Only digits (0-9) are allowed.", "Message", false);
                e.Cancel = true;
            }
            else
            {
                paymentAmount = Decimal.Parse(maskedTextBoxPaymentAmount.Text);
            }
        }

        //Activates the abort code
        private void buttonAbort_Click(object sender, EventArgs e)
        {
            abort();
        }

        //Displays a message.  If urgent, it pops on in a message box and in the info label,
        //otherwise it is only displayed in the info label.
        public void displayMessage(string message, string title, bool urgent)
        {
            if (urgent)
            {
                MessageBox.Show(message, title);
            }

            //labelInfo.Text = labelInfo.Text + "\n" + title + ": " + message;
            labelInfo.Text = title + ": " + message;
        }

        //Aborts the transaction, calling of the CoffeeMachine to see that
        //funds are returned.
        public void abort()
        {
            myCoffeeMachine.abort();
            paymentAmount = 00.00m;
            labelReturnAmount.Text = paymentTotal.ToString();
            labelTotalPaymentAmount.Text = "00.00";
            paymentTotal = 00.00m;
        }
    }
}
