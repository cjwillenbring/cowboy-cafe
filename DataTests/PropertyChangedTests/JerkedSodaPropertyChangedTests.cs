/*
* Author: Cole Willenbring
* Class: JerkedSodaPropertyChangedTests
* Purpose: Holds the class logic for the Jerked Soda property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        // Test1: Jerked Soda should implement INotifyPropertyChangedInterface
        [Fact]
        public void JerkedSodaImplementsINotifyPropertyChanged()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(jerkedSoda);
        }

        // Test2: Changing "Size" should invoke "Size, Calories, and Price" Change
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Size", () => {
                jerkedSoda.Size = Size.Small;
            });
            Assert.PropertyChanged(jerkedSoda, "Calories", () => {
                jerkedSoda.Size = Size.Small;
            });
            Assert.PropertyChanged(jerkedSoda, "Price", () => {
                jerkedSoda.Size = Size.Small;
            });
        }

        // Test3: Changing "Flavor" should invoke "Flavor" Change
        [Fact]
        public void ChangingFlavorPropertyShouldInvokePropertyChangedForFlavor()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Flavor", () => {
                jerkedSoda.Flavor = SodaFlavor.BirchBeer;
            });
        }

        // Test4: Changing "Ice" should invoke "Ice" Change
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Ice", () => {
                jerkedSoda.Ice = false;
            });
        }

        // Test5: Changing "Ice" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "SpecialInstructions", () => {
                jerkedSoda.Ice = false;
            });
        }
    }
}

