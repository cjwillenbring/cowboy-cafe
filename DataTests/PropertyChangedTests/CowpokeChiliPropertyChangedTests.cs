/*
* Author: Cole Willenbring
* Class: CowpokeChiliPropertyChangedTests
* Purpose: Holds the class logic for the Cowpoke Chili property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        // Test1: Cowpoke Chili should implement INotifyPropertyChangedInterface
        [Fact]
        public void CowpokeChiliImplementsINotifyPropertyChanged()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cowpokeChili);
        }

        // Test2: Changing "Cheese" should invoke "Cheese" Change
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "Cheese", () => {
                cowpokeChili.Cheese = false;
            });
        }

        // Test3: Changing "Cheese" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.Cheese = false;
            });
        }

        // Test4: Changing "SourCream" should invoke "SourCream" Change
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SourCream", () => {
                cowpokeChili.SourCream = false;
            });
        }

        // Test5: Changing "SourCream" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.SourCream = false;
            });
        }

        // Test6: Changing "GreenOnions" should invoke "GreenOnions" Change
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "GreenOnions", () => {
                cowpokeChili.GreenOnions = false;
            });
        }

        // Test7: Changing "GreenOnions" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.GreenOnions = false;
            });
        }

        // Test8: Changing "TortillaStrips" should invoke "TortillaStrips" Change
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "TortillaStrips", () => {
                cowpokeChili.TortillaStrips = false;
            });
        }

        // Test9: Changing "TortillaStrips" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.GreenOnions = false;
            });
        }
    }
}
