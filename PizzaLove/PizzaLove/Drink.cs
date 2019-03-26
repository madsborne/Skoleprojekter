using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLove
{
    class Drink
    {
        private int drinkId;
        private int price;
        private string name;
        private string size;


        #region makeitpublic


        public int DrinkId
        {
            get
            {

                return drinkId;

            }
            set
            {

                drinkId = value;

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

        public string Name
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
        #endregion


    }
}
