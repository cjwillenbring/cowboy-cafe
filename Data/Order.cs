/*
* Author: Cole Willenbring
* Class: Order
* Purpose: Holds the logic for the diner's order class
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class for holding order information.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// The order number of the previous order.
        /// </summary>
        private static uint lastOrderNumber = 1;

        /// <summary>
        /// List of Order Items in the current order.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Getter for the private items property.
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// The subtotal of the current order.
        /// </summary>
        public double Subtotal
        {
            get
            {
                double p = 0;
                foreach(IOrderItem item in Items)
                {
                    p += item.Price;
                }
                return p;
            }
        }

        /// <summary>
        /// The OrderNumber of the current order.
        /// </summary>
        public uint OrderNumber { get; } = lastOrderNumber++;

        /// <summary>
        /// The eventhandler type for handling the property change events.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Add an item to the items list.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        /// <summary>
        /// Remove an item from the items list.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        /// <summary>
        /// Updates the items and the totals in the summary box
        /// </summary>
        public void UpdateItems()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
