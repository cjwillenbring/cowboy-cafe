/*
* Author: Cole Willenbring
* Class: Baked Beans
* Purpose: Holds the class logic for the Baked Beans side
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Baked Beans Side
    /// </summary>
    public class BakedBeans : Side
    { 
        /// <summary>
        /// Gets the price of the Baked Beans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of Baked Beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Override the ToString() method for POS use
        /// </summary>
        /// <returns>The string name of the baked beans side with the size.</returns>
        public override string ToString()
        {
            string s = "";
            switch(Size)
            {
                case Size.Small:
                    s = "Small";
                    break;
                case Size.Medium:
                    s = "Medium";
                    break;
                case Size.Large:
                    s = "Large";
                    break;
                default:
                    throw new NotImplementedException();
            }
            return s + " Baked Beans";
        }
    }
}
