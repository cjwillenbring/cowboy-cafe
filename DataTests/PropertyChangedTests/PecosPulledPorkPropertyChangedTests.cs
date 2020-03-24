/*
* Author: Cole Willenbring
* Class: PecosPulledPorkPropertyChangedTests
* Purpose: Holds the class logic for the Pecos Pulled Pork property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        // Test1: Pecos Pulled Pork should implement INotifyPropertyChangedInterface
        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pecosPulledPork);
        }

        // Test2: Changing "Pickle" should invoke "Pickle" Change
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pecosPulledPork, "Pickle", () => {
                pecosPulledPork.Pickle = false;
            });
        }

        // Test3: Changing "Pickle" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pecosPulledPork, "SpecialInstructions", () => {
                pecosPulledPork.Pickle = false;
            });
        }

        // Test4: Changing "Bread" should invoke "Bread" Change
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pecosPulledPork, "Bread", () => {
                pecosPulledPork.Bread = false;
            });
        }

        // Test5: Changing "Bread" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecosPulledPork = new PecosPulledPork();
            Assert.PropertyChanged(pecosPulledPork, "SpecialInstructions", () => {
                pecosPulledPork.Bread = false;
            });
        }
    }
}
