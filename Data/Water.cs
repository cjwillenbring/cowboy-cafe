﻿/*
* Author: Cole Willenbring
* Class: Water
* Purpose: Holds the class logic for the water drink item
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Water drink
    /// </summary>
    public class Water : Drink
    {
        private bool lemon = false;
        /// <summary>
        /// Whether or not the water should have a lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChangedHelper("Lemon");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets the price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Override the ToString() method for POS use
        /// </summary>
        /// <returns>The string name of the water drink with the size.</returns>
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
            return s + " Water";
        }
    }
}
