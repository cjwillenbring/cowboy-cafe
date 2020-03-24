﻿/*
* Author: Cole Willenbring
* Class: PanDeCampoPropertyChangedTests
* Purpose: Holds the class logic for the Pan De Campo property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        // Test1: Pan De Campo should implement INotifyPropertyChangedInterface
        [Fact]
        public void PanDeCampoImplementsINotifyPropertyChanged()
        {
            var panDeCampo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(panDeCampo);
        }

        // Test2: Changing "Size" should invoke "Size" Change
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Size", () => {
                panDeCampo.Size = Size.Small;
            });
        }
    }
}
