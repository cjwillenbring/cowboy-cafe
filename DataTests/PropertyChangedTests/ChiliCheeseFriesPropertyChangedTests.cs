/*
* Author: Cole Willenbring
* Class: ChiliCheeseFriesPropertyChangedTests
* Purpose: Holds the class logic for the Chili Cheese Fries property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        // Test1: Chili Cheese Fries should implement INotifyPropertyChangedInterface
        [Fact]
        public void ChiliCheeseFriesImplementsINotifyPropertyChanged()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chiliCheeseFries);
        }

        // Test2: Changing "Size" should invoke "Size" Change
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheeseFries, "Size", () => {
                chiliCheeseFries.Size = Size.Small;
            });
        }
    }
}


