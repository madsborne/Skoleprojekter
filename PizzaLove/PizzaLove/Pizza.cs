using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PizzaLove
{
    class Pizza
    {
        

        private int pizzaId;
        private int price;
        private string pizzaName;
        private string size;
        private string pizzaContent;


        #region makeitpublic
        public int PizzaId
        {
            get
            {
                return pizzaId;
            }
            set
            {
                pizzaId = value;
            }
        }
        public int Price
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
        public string PizzaName
        {
            get
            {
                return pizzaName;
            }
            set
            {
                pizzaName = value;
            }
        }
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public string PizzaContent
        {
            get
            {
                return pizzaContent;
            }
            set
            {
                pizzaContent = value;
            }
        }
        #endregion

        

    }
}
