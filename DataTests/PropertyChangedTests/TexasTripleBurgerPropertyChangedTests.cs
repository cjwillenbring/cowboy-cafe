/*
* Author: Cole Willenbring
* Class: TexasTripleBurgerPropertyChangedTests
* Purpose: Holds the class logic for the Texas Triple Burger property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        // Test1: Texas Triple Burger should implement INotifyPropertyChangedInterface
        [Fact]
        public void TexasTripleBurgerImplementsINotifyPropertyChanged()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTripleBurger);
        }

        // Test2: Changing "Bun" should invoke "Bun" Change
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Bun", () => {
                texasTripleBurger.Bun = false;
            });
        }

        // Test3: Changing "Bun" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Bun = false;
            });
        }

        // Test4: Changing "Ketchup" should invoke "Ketchup" Change
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Ketchup", () => {
                texasTripleBurger.Ketchup = false;
            });
        }

        // Test5: Changing "Ketchup" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Ketchup = false;
            });
        }

        // Test6: Changing "Mustard" should invoke "Mustard" Change
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Mustard", () => {
                texasTripleBurger.Mustard = false;
            });
        }

        // Test7: Changing "Mustard" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Mustard = false;
            });
        }

        // Test8: Changing "Pickle" should invoke "Pickle" Change
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Pickle", () => {
                texasTripleBurger.Pickle = false;
            });
        }

        // Test9: Changing "Pickle" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Pickle = false;
            });
        }

        // Test10: Changing "Cheese" should invoke "Cheese" Change
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Cheese", () => {
                texasTripleBurger.Cheese = false;
            });
        }

        // Test11: Changing "Cheese" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Cheese = false;
            });
        }

        // Test12: Changing "Tomato" should invoke "Tomato" Change
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Tomato", () => {
                texasTripleBurger.Tomato = false;
            });
        }

        // Test13: Changing "Tomato" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Tomato = false;
            });
        }

        // Test14: Changing "Lettuce" should invoke "Lettuce" Change
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Lettuce", () => {
                texasTripleBurger.Lettuce = false;
            });
        }

        // Test15: Changing "Lettuce" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Lettuce = false;
            });
        }

        // Test16: Changing "Mayo" should invoke "Mayo" Change
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Mayo", () => {
                texasTripleBurger.Mayo = false;
            });
        }

        // Test17: Changing "Mayo" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Mayo = false;
            });
        }

        // Test18: Changing "Bacon" should invoke "Bacon" Change
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForBacon()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Bacon", () => {
                texasTripleBurger.Bacon = false;
            });
        }

        // Test19: Changing "Bacon" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Bacon = false;
            });
        }

        // Test20: Changing "Egg" should invoke "Egg" Change
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForEgg()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "Egg", () => {
                texasTripleBurger.Egg = false;
            });
        }

        // Test21: Changing "Egg" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTripleBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasTripleBurger, "SpecialInstructions", () => {
                texasTripleBurger.Egg = false;
            });
        }
    }
}

