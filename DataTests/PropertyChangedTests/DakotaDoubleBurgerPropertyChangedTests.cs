/*
* Author: Cole Willenbring
* Class: DakotaDoubleBurgerPropertyChangedTests
* Purpose: Holds the class logic for the Dakota Double Burger property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        // Test1: Dakota Double Burger should implement INotifyPropertyChangedInterface
        [Fact]
        public void DakotaDoubleBurgerImplementsINotifyPropertyChanged()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakotaDoubleBurger);
        }

        // Test2: Changing "Bun" should invoke "Bun" Change
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Bun", () => {
                dakotaDoubleBurger.Bun = false;
            });
        }

        // Test3: Changing "Bun" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Bun = false;
            });
        }

        // Test4: Changing "Ketchup" should invoke "Ketchup" Change
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Ketchup", () => {
                dakotaDoubleBurger.Ketchup = false;
            });
        }

        // Test5: Changing "Ketchup" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Ketchup = false;
            });
        }

        // Test6: Changing "Mustard" should invoke "Mustard" Change
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Mustard", () => {
                dakotaDoubleBurger.Mustard = false;
            });
        }

        // Test7: Changing "Mustard" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Mustard = false;
            });
        }

        // Test8: Changing "Pickle" should invoke "Pickle" Change
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Pickle", () => {
                dakotaDoubleBurger.Pickle = false;
            });
        }

        // Test9: Changing "Pickle" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Pickle = false;
            });
        }

        // Test10: Changing "Cheese" should invoke "Cheese" Change
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Cheese", () => {
                dakotaDoubleBurger.Cheese = false;
            });
        }

        // Test11: Changing "Cheese" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Cheese = false;
            });
        }

        // Test12: Changing "Tomato" should invoke "Tomato" Change
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Tomato", () => {
                dakotaDoubleBurger.Tomato = false;
            });
        }

        // Test13: Changing "Tomato" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Tomato = false;
            });
        }

        // Test14: Changing "Lettuce" should invoke "Lettuce" Change
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Lettuce", () => {
                dakotaDoubleBurger.Lettuce = false;
            });
        }

        // Test15: Changing "Lettuce" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Lettuce = false;
            });
        }

        // Test16: Changing "Mayo" should invoke "Mayo" Change
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "Mayo", () => {
                dakotaDoubleBurger.Mayo = false;
            });
        }

        // Test17: Changing "Mayo" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDoubleBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDoubleBurger, "SpecialInstructions", () => {
                dakotaDoubleBurger.Mayo = false;
            });
        }
    }
}

