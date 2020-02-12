/*
* Author: Cole Willenbring
* Class: Drink
* Purpose: Holds the abstract class logic for the cowboy cafe drink menu items
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions of for the preparation of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Gets whether or not the drink contains ice;
        /// </summary>
        public virtual bool Ice { get; set; } = true;
    }
}
