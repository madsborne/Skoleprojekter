using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 

namespace PizzaLove
{
    class DbControl
    {
        private string dbConString = @"Data Source=192.168.1.55;Initial Catalog=pizzalove;User ID=sa;Password=Mike1234M";
        //private string dbLocalConString = @"Data Source=ZBC-MADS648I\MYSQL;Initial Catalog=pizzalovetest;Integrated Security=true";

        public string DbConString
        {
            get
            {
                return dbConString;
            }
        }

        public DbControl()
        {

        }


        /// <summary>
        /// Inserts the user input into local vars that are used later in the method
        /// </summary>
        /// <param name="userFirstName"></param>
        /// <param name="userLastName"></param> 
        /// <param name="userPhoneNumber"></param>
        /// <param name="userAdress"></param>
        /// <param name="userPostNumber"></param>
        public void InsertIntoDb(string userFirstName, string userLastName, string userPhoneNumber, string userAdress, string userPostNumber)
        {
            // local vars
            string firstName = userFirstName;
            string lastName = userLastName;
            Int32.TryParse(userPhoneNumber, out int phoneNumber);
            string adress = userAdress;
            string postNumber = userPostNumber;

            // creates the connection 
            SqlConnection connection = new SqlConnection(DbConString);
            // adds the local vars into query
            string queryAddCustomer = $"INSERT INTO Kunde(Fornavn,Efternavn,Telefon_nr,Adresse,Postnr) VALUES('{firstName}', '{lastName}', '{phoneNumber}', '{adress}', '{postNumber}')";

            SqlCommand cmd = new SqlCommand(queryAddCustomer, connection);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Done");
                Console.ReadKey();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Closed");
                Console.ReadKey();
            }
        }

        public void DisplayAllPizza()
        {
            SqlConnection sqlCon = new SqlConnection(dbConString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pizza", sqlCon);

            try
            {
                sqlCon.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = reader.GetSchemaTable();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine(reader.GetValue(i));
                    }

                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            
            
            
        }
        public void DisplayAllDriknk()
        {
            SqlConnection con = new SqlConnection(dbConString); // Making our sql connection 
            SqlCommand cmd = new SqlCommand("Select * From Drikkevare", con); // Command we want to excecute in our method 


            try
            {
                con.Open(); // open connection 
                SqlDataReader reader = cmd.ExecuteReader(); //command execute reader 

                while(reader.Read()) // while reader has somthing to read 
                {
                    for (int i = 0; i < reader.FieldCount; i++) // fieldcount is how many fields we have in our db 
                    {
                        Console.WriteLine(reader.GetValue(i)); // gets the value of field one two three and so on 
                    }
                   
                }

            }

            catch (SqlException e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }




    }
}
