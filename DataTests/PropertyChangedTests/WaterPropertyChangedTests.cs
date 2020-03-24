/*
* Author: Cole Willenbring
* Class: WaterPropertyChangedTests
* Purpose: Holds the class logic for the Water property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        // Test1: Water should implement INotifyPropertyChangedInterface
        [Fact]
        public void WaterImplementsINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        // Test2: Changing "Size" should invoke "Size, Calories, and Price" Change
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () => {
                water.Size = Size.Small;
            });
            Assert.PropertyChanged(water, "Calories", () => {
                water.Size = Size.Small;
            });
            Assert.PropertyChanged(water, "Price", () => {
                water.Size = Size.Small;
            });
        }

        // Test3: Changing "Ice" should invoke "Ice" Change
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () => {
                water.Ice = false;
            });
        }

        // Test5: Changing "Ice" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => {
                water.Ice = false;
            });
        }

        // Test5: Changing "Lemon" should invoke "Lemon" Change
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () => {
                water.Lemon = false;
            });
        }

        // Test6: Changing "Lemon" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => {
                water.Lemon = false;
            });
        }
    }
}

