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
