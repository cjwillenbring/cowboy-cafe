using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Baked Beans Side
    /// </summary>
    public class BakedBeans : Side
    {
        public Size size = Size.Small;
        /// <summary>
        /// Gets the size of the Baked Beans
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                if (value == Size.Small)
                {
                    price = 1.59;
                    calories = 312;
                }
                else if (value == Size.Medium)
                {
                    price = 1.79;
                    calories = 378;
                }
                else if (value == Size.Large)
                {
                    price = 1.99;
                    calories = 410;
                }
                else
                {
                    throw new NotImplementedException();
                }
                size = value;
            }
        }

        public double price = 1.59;
        /// <summary>
        /// Gets the price of the Baked Beans
        /// </summary>
        public override double Price
        {
            get { return price; }
            set { price = value; }
        }

        public uint calories = 312;
        /// <summary>
        /// Gets the calories of Baked Beans
        /// </summary>
        public override uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }
    }
}
