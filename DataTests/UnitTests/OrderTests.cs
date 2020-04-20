using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    /// <summary>
    /// Class to hold mock order items for test;
    /// </summary>
    class MockOrderItem : IOrderItem
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public IEnumerable<string> SpecialInstructions { get; set; }
    }

    public class OrderTests
    {
        [Fact]
        public void AddedIOrderItemsAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void RemovedIOrderItemsDoesNotAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Theory]
        [InlineData(new double[] {  })]
        [InlineData(new double[] { 0 })]
        [InlineData(new double[] { 1.00, 2.00, 3.00 })]
        [InlineData(new double[] { 10, 15, 18 })]
        [InlineData(new double[] { 20, -4, 3.6, 8 })]
        [InlineData(new double[] { -100, -5 })]
        public void ShouldHaveCorrectPriceForItemsInOrder(double[] prices)
        {
            double total = 0;
            var order = new Order();
            foreach(var price in prices)
            {
                order.Add(new MockOrderItem() { Price = price });
                total += price;
            }
            Assert.Equal(total, order.Subtotal);
        }
        
        [Fact]
        public void ItemsSHouldContainOnlyAddedItems()
        {
            IEnumerable<MockOrderItem> items = new List<MockOrderItem>()
            {
                new MockOrderItem() { Price = 3 },
                new MockOrderItem() { Price = 4 },
                new MockOrderItem() { Price = 7 }
            };

            var order = new Order();
            foreach(var item in items)
            {
                order.Add(item);
            }
            Assert.Equal(items.Count(), order.Items.Count());
            foreach(var item in items)
            {
                Assert.Contains(item, order.Items);
            }
        }
    }
}
