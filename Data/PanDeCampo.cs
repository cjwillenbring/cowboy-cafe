using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan De Campos Side
    /// </summary>
    public class PanDeCampo : Side
    {
        public Size size = Size.Small;
        /// <summary>
        /// Gets the size of the Pan De Campos
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                if (value == Size.Small)
                {
                    price = 1.59;
                    calories = 227;
                }
                else if (value == Size.Medium)
                {
                    price = 1.79;
                    calories = 269;
                }
                else
                {
                    price = 1.99;
                    calories = 367;
                }
                size = value;
            }
        }

        public double price = 1.59;
        /// <summary>
        /// Gets the price of the Pan De Campos
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public uint calories = 227;
        /// <summary>
        /// Gets the calories of Pan De Campos
        /// </summary>
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }
    }
}
