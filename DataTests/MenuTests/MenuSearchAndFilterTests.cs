/*
* Author: Cole Willenbring
* Class: MenuSearchAndFilterTests
* Purpose: Holds the class logic for the menu search and filter tests
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests.MenuTests
{
    public class MenuSearchAndFilterTests
    {
        // Test search
        // Null should return all
        [Fact]
        public void TestSearchNullReturnsAll()
        {
            IEnumerable<IOrderItem> res = Menu.Search("");
            IEnumerable<IOrderItem> all = Menu.All;
            Assert.Equal<int>(all.Count(), res.Count());
        }

        // Test search
        // Rustler should return  only Rustler's Ribs
        [Fact]
        public void TestSearchRustlerReturnsRustlersRibs()
        {
            IEnumerable<IOrderItem> res = Menu.Search("Rustler");
            bool containsRustlersRibs = false;
            foreach (IOrderItem i in res) if (i is RustlersRibs) containsRustlersRibs = true;
            Assert.True(containsRustlersRibs);
            Assert.Single(res);
        }

        // Test search
        // Burger should return all 3 trailburgers
        [Fact]
        public void TestSearchBurgerShouldReturnThreeBurgers()
        {
            IEnumerable<IOrderItem> res = Menu.Search("Burger");
            bool containsTTB = false;
            bool containsTB = false;
            bool containsDB = false;
            foreach (IOrderItem i in res)
            {
                if (i is TexasTripleBurger) containsTTB = true;
                if (i is DakotaDoubleBurger) containsDB = true;
                if (i is TrailBurger) containsTB = true;

            }
            Assert.True(containsTTB);
            Assert.True(containsDB);
            Assert.True(containsTB);
            Assert.Equal(3,res.Count());
        }

        // Test filter by category
        [Fact]
        public void TestFilterByEntreeShouldReturnAllEntrees()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByCategory(items,new List<string>() { "Entree" });
            bool containsNotEntree = false;
            foreach (IOrderItem i in res)
            {
                if (i is Drink || i is Side) containsNotEntree = true;
            }
            Assert.False(containsNotEntree);
            Assert.Equal(Menu.Entrees().Count(), res.Count());
        }

        // Test filter by category
        [Fact]
        public void TestNullShouldReturnAll()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByCategory(items, new List<string>());
            Assert.Equal(items.Count(), res.Count());
        }

        // Test filter by category
        [Fact]
        public void TestSideAndDrinkReturnSidesAndDrinks()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByCategory(items, new List<string>() { "Side","Drink" });
            bool containsEntree = false;
            foreach (IOrderItem i in res)
            {
                if (i is Entree) containsEntree = true;
            }
            Assert.False(containsEntree);
            Assert.Equal(Menu.Sides().Count()+Menu.Drinks().Count(), res.Count());
        }

        // Test filter by calories
        [Fact]
        public void TestFilterCaloriesNullReturnsAll()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByCalories(items, null, null);
            Assert.Equal(items.Count(), res.Count());
        }

        // Test filter by calories
        [Fact]
        public void TestFilterCaloriesMinZeroReturnsAll()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByCalories(items, 0, null);
            Assert.Equal(items.Count(), res.Count());
        }

        // Test filter by calories
        [Fact]
        public void TestFilterCaloriesMaxZeroReturnsOnlyWater()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByCalories(items, null, 0);
            bool containsWater = false;
            foreach (IOrderItem i in res) if (i is Water) containsWater = true;
            Assert.True(containsWater);
            Assert.Single(res);
        }

        // Test filter by calories
        [Fact]
        public void TestFilterCaloriesAllInRangeReturnsAll()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByCalories(items, 0, 2000);
            Assert.Equal(items.Count(), res.Count());
        }

        // Test filter by price
        [Fact]
        public void TestFilterPriceNullReturnsAll()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByPrice(items, null, null);
            Assert.Equal(items.Count(), res.Count());
        }

        // Test filter by price
        [Fact]
        public void TestFilterPriceMinZeroReturnsAll()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByPrice(items, 0, null);
            Assert.Equal(items.Count(), res.Count());
        }

        // Test filter by price
        [Fact]
        public void TestFilterPriceMaxZeroReturnsNone()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByPrice(items, null, 0);
            Assert.Empty(res);
        }

        // Test filter by price
        [Fact]
        public void TestFilterPriceAllWithinRangeReturnsAll()
        {
            IEnumerable<IOrderItem> items = Menu.All;
            IEnumerable<IOrderItem> res = Menu.FilterByPrice(items, 0, 2000);
            Assert.Equal(items.Count(), res.Count());
        }
    }
}
