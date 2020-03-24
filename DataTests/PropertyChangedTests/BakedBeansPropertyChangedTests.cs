/*
* Author: Cole Willenbring
* Class: BakedBeansPropertyChangedTests
* Purpose: Holds the class logic for the Baked Beans property changed tests
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        // Test1: Baked Beans should implement INotifyPropertyChangedInterface
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var bakedBeans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bakedBeans);
        }

        // Test2: Changing "Size" should invoke "Size, Calories, and Price" Change
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var bakedBeans = new BakedBeans();
            Assert.PropertyChanged(bakedBeans, "Size", () => {
                bakedBeans.Size = Size.Small;
            });
            Assert.PropertyChanged(bakedBeans, "Calories", () => {
                bakedBeans.Size = Size.Small;
            });
            Assert.PropertyChanged(bakedBeans, "Price", () => {
                bakedBeans.Size = Size.Small;
            });
        }
    }
}

