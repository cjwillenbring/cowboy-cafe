﻿/*
* Author: Nathan Bean
* Edited By: Cole Willenbring
* Class: Side
* Purpose: Abstract base class for the diner's side dishes
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Implementing as null to implement the IOrderItem interface
        /// </summary>
        public IEnumerable<string> SpecialInstructions => new List<string>();
    }
}
