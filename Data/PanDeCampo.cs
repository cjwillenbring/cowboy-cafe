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
        public override Size Size
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
                else if (value == Size.Large)
                {
                    price = 1.99;
                    calories = 367;
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
        /// Gets the price of the Pan De Campos
        /// </summary>
        public override double Price
        {
            get { return price; }
            set { price = value; }
        }

        public uint calories = 227;
        /// <summary>
        /// Gets the calories of Pan De Campos
        /// </summary>
        public override uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }
    }
}
