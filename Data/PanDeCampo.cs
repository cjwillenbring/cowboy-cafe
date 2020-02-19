/*
* Author: Cole Willenbring
* Class: Pan De Campo
* Purpose: Holds the class logic for the Pan de Campos side
*/
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
        /// <summary>
        /// Gets the price of the Pan de Campos
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
        /// Gets the calories of Pan de Campos
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Override the ToString() method for POS use
        /// </summary>
        /// <returns>The string name of the Pan de Campo side with the size.</returns>
        public override string ToString()
        {
            string s = "";
            switch (Size)
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
            return s + " Pan de Campo";
        }
    }
}
