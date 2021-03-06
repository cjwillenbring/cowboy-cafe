﻿/*
* Author: Cole Willenbring
* Class: Entree
* Purpose: Abstract base class representing an entree that the diner serves
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    { 
        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for the preparation of a certain entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Implement the IOrderItem interface with the current List<string> implementation
        /// </summary>
        IEnumerable<string> IOrderItem.SpecialInstructions => SpecialInstructions;

        /// <summary>
        /// Helper method for property change event
        /// </summary>
        /// <param name="prop">The property being changed</param>
        protected void PropertyChangedHelper(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
