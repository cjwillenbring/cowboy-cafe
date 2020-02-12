/*
* Author: Cole Willenbring
* Class: Texas Tea
* Purpose: Holds the class logic for the Texas Tea drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    class TexasTea : Drink
    {
        /// <summary>
        /// Whether or not the tea should have a lemon
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Whether or not the tea is sweet
        /// </summary>
        public bool Sweet { get; set; }

        /// <summary>
        /// Gets the price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 10;
                    case Size.Medium:
                        return 22;
                    case Size.Large:
                        return 36;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions for the tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");

                return instructions;
            }
        }
    }
}
