using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CoffeeMachineProject
{
    /*
     * A class for accessing the database of selectable drinks.
     * With some help from Etienne Rached's code on http://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
     * 
     * Used by the CoffeeMachine class.
     */
    public class DrinkDatabase
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private Dictionary<int, Drink> myDrinkList;

        /*
         * Constuctor for DrinkDatabase
         */
        public DrinkDatabase()
        {
            initialise();
        }

        /*
         * The initialise method sets up the connection information for the database.
         */
        private void initialise()
        {
            server = "localhost";
            database = "test";
            uid = "username here";
            password = "password here";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Get for the dictionary of drinks
        public Dictionary<int, Drink> DrinkList
        {
            get
            {
                return myDrinkList;
            }
        }

        //Opens a connection to the database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Closes the connection to the database
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string query)
        {
            //Format:
            //string query = "INSERT INTO drinks (idDrinks, DrinksName, DrinksDesc, DrinksType,
                //DrinksPrice, UsesWater, IsCarbonated, CountSugar, CountMilk, CountCoffee)
                //VALUES('000', 'Water', 'A nice cold glass of water.', '0', '01.00', '1', '0', '0', '0', '0')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string query)
        {
            //Example:
            //string query = "UPDATE drinks SET DrinksPrice='10.00' WHERE idDrinks='000'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {
            //Example:
            //string query = "DELETE FROM drinks WHERE idDrinks='000'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        
        /*
         * The fillDictionary method fills the Dictionary myDrinkList with data from the
         * database.
         */
        public bool fillDictionary()
        {
            string query = "SELECT * FROM drinks";

            //Open connection
            if (this.OpenConnection() == true)
            {
                myDrinkList = new Dictionary<int, Drink>();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                DataTable tableDrinks = new DataTable();
                tableDrinks.Load(dataReader);

                foreach (DataRow row in tableDrinks.Rows)
                {
                    int id = (int)row["idDrinks"];
                    string name = (string)row["DrinksName"];
                    string desc = (string)row["DrinksDesc"];
                    int type = (int)row["DrinksType"];
                    decimal price = (decimal)row["DrinksPrice"];
                    int water = (int)row["UsesWater"];
                    int carbo = (int)row["IsCarbonated"];
                    int sugar = (int)row["CountSugar"];
                    int milk = (int)row["CountMilk"];
                    int coffee = (int)row["CountCoffee"];

                    bool bCarbo = false;
                    Drink tempDrink = null;
                    Coffee tempCoffee = null;
                    if (carbo > 0) bCarbo = true;

                    if (type == 0)
                    {
                        tempDrink = new Drink(id, name, desc, type, price, water, bCarbo, sugar, milk);
                        myDrinkList.Add(id, tempDrink);
                    }
                    else
                    {
                        tempCoffee = new Coffee(id, name, desc, type, price, water, bCarbo, sugar, milk, coffee);
                        myDrinkList.Add(id, tempCoffee);
                    }
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return true;
            }

            return false;
        }
    }
}
