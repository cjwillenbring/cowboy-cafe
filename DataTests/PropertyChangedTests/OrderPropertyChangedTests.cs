/*
* Author: Cole Willenbring
* Class: OrderPropertyChangedTests
* Purpose: Holds the class logic for the Order property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class OrderPropertyChangedTests
    {
        // Test1: Order should implement INotifyPropertyChangedInterface
        [Fact]
        public void OrderImplementsINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        // Test2: Adding an item to the order should invoke "Subtotal and Items" change
        [Fact]
        public void AddingItemShouldInvokePropertyChangedForSubtotalAndItems()
        {
            var order = new Order();
            var data1 = new CowboyCoffee();
            var data2 = new CowpokeChili();
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.Add(data1);
            });
            Assert.PropertyChanged(order, "Items", () => {
                order.Add(data2);
            });
        }

        // Test3: Removing an item from the order should invoke "Subtotal and Items" change
        [Fact]
        public void RemovingItemShouldInvokePropertyChangedForSubtotalAndItems()
        {
            var order = new Order();
            var data1 = new CowboyCoffee();
            var data2 = new CowpokeChili();
            order.Add(data1);
            order.Add(data2);
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.Remove(data1);
            });
            Assert.PropertyChanged(order, "Items", () => {
                order.Remove(data2);
            });
        }

        // Test3: Updating items in the order should invoke "Subtotal and Items" change
        [Fact]
        public void UpdatingItemsShouldInvokePropertyChangedForSubtotalAndItems()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Subtotal", () => {
                order.UpdateItems();
            });
            Assert.PropertyChanged(order, "Items", () => {
                order.UpdateItems();
            });
        }
    }
}
