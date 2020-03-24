/*
* Author: Cole Willenbring
* Class: TrailBurgerPropertyChangedTests
* Purpose: Holds the class logic for the Trail Burger property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        // Test1: Trail Burger should implement INotifyPropertyChangedInterface
        [Fact]
        public void TrailBurgerImplementsINotifyPropertyChanged()
        {
            var trailBurger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trailBurger);
        }

        // Test2: Changing "Bun" should invoke "Bun" Change
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Bun", () => {
                trailBurger.Bun = false;
            });
        }

        // Test3: Changing "Bun" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Bun = false;
            });
        }

        // Test4: Changing "Ketchup" should invoke "Ketchup" Change
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Ketchup", () => {
                trailBurger.Ketchup = false;
            });
        }

        // Test5: Changing "Ketchup" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Ketchup = false;
            });
        }

        // Test6: Changing "Mustard" should invoke "Mustard" Change
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Mustard", () => {
                trailBurger.Mustard = false;
            });
        }

        // Test7: Changing "Mustard" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Mustard = false;
            });
        }

        // Test8: Changing "Pickle" should invoke "Pickle" Change
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Pickle", () => {
                trailBurger.Pickle = false;
            });
        }

        // Test9: Changing "Pickle" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Pickle = false;
            });
        }

        // Test10: Changing "Cheese" should invoke "Cheese" Change
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Cheese", () => {
                trailBurger.Cheese = false;
            });
        }

        // Test11: Changing "Cheese" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Cheese = false;
            });
        }
    }
}

