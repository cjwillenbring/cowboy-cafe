/*
* Author: Cole Willenbring
* Class: RustlersRibsPropertyChangedTests
* Purpose: Holds the class logic for the Rustlers Ribs property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class RustlersRibsPropertyChangedTests
    {
        // Test1: Rustlers Ribs should implement INotifyPropertyChangedInterface
        [Fact]
        public void RustlersRibsImplementsINotifyPropertyChanged()
        {
            var rustlersRibs = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(rustlersRibs);
        }
    }
}
