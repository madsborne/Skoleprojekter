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

        List<Pizza> newPizza = new List<Pizza>();

        public DbControl()
        {

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

                int name = dataTable.Rows[2].Field<int>(0);

                Console.WriteLine(name);

                


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
