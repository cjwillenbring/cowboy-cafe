/*
* Author: Cole Willenbring
* Class: Jerked Soda
* Purpose: Holds the class logic for the Jerked Soda drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The flavor of the soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Gets the price of the Jerked Soda
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of Jerked Soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions for the jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Override the ToString() method for POS use
        /// </summary>
        /// <returns>The string name of the jerked soda with the size and flavor.</returns>
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
            string f = "";
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    f = "Birch Beer";
                    break;
                case SodaFlavor.Sarsparilla:
                    f = "Sarsparilla";
                    break;
                case SodaFlavor.RootBeer:
                    f = "Root Beer";
                    break;
                case SodaFlavor.CreamSoda:
                    f = "Cream Soda";
                    break;
                case SodaFlavor.OrangeSoda:
                    f = "Orange Soda";
                    break;
                default:
                    throw new NotImplementedException();
            }
            return s + " " + f + " Jerked Soda";
        }
    }
}
