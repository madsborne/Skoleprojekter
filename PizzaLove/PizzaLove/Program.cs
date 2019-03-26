using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PizzaLove
{
    class Program
    {
        static void Main(string[] args)
        {
            // instances the connection
            DbControl db = new DbControl();
            string userInput = "";

            while (true)
            {
                Console.WriteLine("1: insert customer into db");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Type in your name");
                        string userName = Console.ReadLine();

                        Console.WriteLine("Type in your last name");
                        string userLastName = Console.ReadLine();

                        Console.WriteLine("Type in your phone number");
                        string userPhoneNumber = Console.ReadLine();

                        Console.WriteLine("Type in your adress");
                        string userAdress = Console.ReadLine();

                        Console.WriteLine("Type in your zip number");
                        string userZipNumber = Console.ReadLine();

                        db.InsertIntoDb(userName, userLastName, userPhoneNumber, userAdress, userZipNumber);
                        break;

                    case "2":
                        db.DisplayAllDriknk();
                        break;
                    case "3":
                        db.DisplayAllPizza();
                        break;
                    default:
                        break;
                } 
            }

        }
    }
}
