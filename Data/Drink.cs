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
    abstract class Drink
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the ingredients of for the drink
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets whether or not the drink contains ice;
        /// </summary>
        public abstract bool Ice { get; set; }
    }
}
