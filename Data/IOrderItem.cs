/*
* Author: Cole Willenbring
* Class: N/A
* Purpose: Holds the logic for the IOrderItem interface
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Interface encompassing order items.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Getter for the price of the item.
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Getter for the instructions for preparation.
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }
    }
}
