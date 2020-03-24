/*
* Author: Nathan Bean
* Edited By: Cole Willenbring
* Class: Side
* Purpose: Abstract base class for the diner's side dishes
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event handler
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size 
        { 
            get { return size; }
            set
            {
                size = value;
                PropertyChangedHelper("Size");
                PropertyChangedHelper("Calories");
                PropertyChangedHelper("Price");
            }
        }

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
