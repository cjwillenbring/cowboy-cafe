using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Cheese Fries Side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        public Size size = Size.Small;
        /// <summary>
        /// Gets the size of the Chili Cheese Fries
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                if (value == Size.Small)
                {
                    price = 1.99;
                    calories = 433;
                }
                else if (value == Size.Medium)
                {
                    price = 2.99;
                    calories = 524;
                }
                else
                {
                    price = 3.99;
                    calories = 610;
                }
                size = value;
            }
        }

        public double price = 1.99;
        /// <summary>
        /// Gets the price of the Chili Cheese Fries
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public uint calories = 433;
        /// <summary>
        /// Gets the calories of Chili Cheese Fries
        /// </summary>
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }
    }
}
