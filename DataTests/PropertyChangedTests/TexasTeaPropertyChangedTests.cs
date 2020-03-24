/*
* Author: Cole Willenbring
* Class: TexasTeaPropertyChangedTests
* Purpose: Holds the class logic for the Texas Tea property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        // Test1: Texas Tea should implement INotifyPropertyChangedInterface
        [Fact]
        public void TexasTeaImplementsINotifyPropertyChanged()
        {
            var texasTea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTea);
        }

        // Test2: Changing "Size" should invoke "Size" Change
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Size", () => {
                texasTea.Size = Size.Small;
            });
        }

        // Test3: Changing "Sweet" should invoke "Sweet" Change
        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSweet()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Sweet", () => {
                texasTea.Sweet = false;
            });
        }

        // Test4: Changing "Ice" should invoke "Ice" Change
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Ice", () => {
                texasTea.Ice = false;
            });
        }

        // Test5: Changing "Ice" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Ice = false;
            });
        }

        // Test6: Changing "Lemon" should invoke "Lemon" Change
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Lemon", () => {
                texasTea.Lemon = false;
            });
        }

        // Test7: Changing "Lemon" should invoke "SpecialInstructions" Change
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Lemon = false;
            });
        }
    }
}

