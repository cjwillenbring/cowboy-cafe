/*
* Author: Cole Willenbring
* Class: Cowboy Coffee
* Purpose: Holds the class logic for the Cowboy Coffee drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Whether or not the coffee should be decaf
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Whether or not to leave room for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// Whether or not the coffee has ice or not
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// Gets the price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Override the ToString() method for POS use
        /// </summary>
        /// <returns>The string name of the cowboy coffee drink with the size and if it is caffeinated or not.</returns>
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
            string c = "";
            if (Decaf) c = " Decaf";
            return s + c + " Cowboy Coffee";
        }
    }
}
