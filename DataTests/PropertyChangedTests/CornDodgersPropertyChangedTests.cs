/*
* Author: Cole Willenbring
* Class: CornDodgersPropertyChangedTests
* Purpose: Holds the class logic for the Corn Dodgers property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        // Test1: Corn Dodgers should implement INotifyPropertyChangedInterface
        [Fact]
        public void CornDodgersImplementsINotifyPropertyChanged()
        {
            var cornDodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cornDodgers);
        }

        // Test2: Changing "Size" should invoke "Size" Change
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Size", () => {
                cornDodgers.Size = Size.Small;
            });
        }
    }
}
