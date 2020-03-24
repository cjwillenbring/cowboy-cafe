/*
* Author: Cole Willenbring
* Class: CowboyCoffeePropertyChangedTests
* Purpose: Holds the class logic for the Cowboy Coffee property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        // Test1: Cowboy Coffee should implement INotifyPropertyChangedInterface
        [Fact]
        public void CowboyCoffeeImplementsINotifyPropertyChanged()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cowboyCoffee);
        }

        // Test2: Changing "Size" should invoke "Size" Change
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Size", () => {
                cowboyCoffee.Size = Size.Small;
            });
        }

        // Test2: Changing "Decaf" should invoke "Decaf" Change
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Decaf", () => {
                cowboyCoffee.Decaf = false;
            });
        }

        // Test3: Changing "Decaf" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () => {
                cowboyCoffee.Decaf = false;
            });
        }

        // Test4: Changing "Ice" should invoke "Ice" Change
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Ice", () => {
                cowboyCoffee.Ice = false;
            });
        }

        // Test5: Changing "Ice" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () => {
                cowboyCoffee.Ice = false;
            });
        }

        // Test6: Changing "RoomForCream" should invoke "RoomForCream" Change
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForRoomForCream()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "RoomForCream", () => {
                cowboyCoffee.RoomForCream = false;
            });
        }

        // Test7: Changing "RoomForCream" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () => {
                cowboyCoffee.RoomForCream = false;
            });
        }
    }
}

