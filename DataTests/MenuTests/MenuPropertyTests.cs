/*
* Author: Cole Willenbring
* Class: MenuPropertyTests
* Purpose: Holds the class logic for the menu property tests
*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.MenuTests
{
    public class MenuPropertyTests
    {
        // Check all entrees
        [Fact]
        public void CheckEntreesIncludesAllEntrees()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            bool containsAngryChicken = false;
            bool containsCowpokeChili = false;
            bool containsDakotaDoubleBurger = false;
            bool containsRustlersRibs = false;
            bool containsTexasTripleBurger = false;
            bool containsTrailBurger = false;
            bool containsPecosPulledPork = false;
            foreach (IOrderItem i in entrees)
            {
                if (i is AngryChicken) containsAngryChicken = true;
                if (i is CowpokeChili) containsCowpokeChili = true;
                if (i is DakotaDoubleBurger) containsDakotaDoubleBurger = true;
                if (i is RustlersRibs) containsRustlersRibs = true;
                if (i is TexasTripleBurger) containsTexasTripleBurger = true;
                if (i is TrailBurger) containsTrailBurger = true;
                if (i is PecosPulledPork) containsPecosPulledPork = true;
            }
            Assert.True(containsAngryChicken);
            Assert.True(containsCowpokeChili);
            Assert.True(containsDakotaDoubleBurger);
            Assert.True(containsRustlersRibs);
            Assert.True(containsTexasTripleBurger);
            Assert.True(containsTrailBurger);
            Assert.True(containsPecosPulledPork);
        }

        // Check all drinks
        [Fact]
        public void CheckDrinksIncludesAllDrinks()
        {
            IEnumerable<IOrderItem> drinks = Menu.Drinks();
            bool containsTea = false;
            bool containsWater = false;
            bool containsCoffee = false;
            bool containsSoda = false;
            foreach(IOrderItem i in drinks)
            {
                if (i is TexasTea) containsTea = true;
                if (i is Water) containsWater = true;
                if (i is CowboyCoffee) containsCoffee = true;
                if (i is JerkedSoda) containsSoda = true;
            }
            Assert.True(containsTea);
            Assert.True(containsWater);
            Assert.True(containsCoffee);
            Assert.True(containsSoda);
        }

        // Check all sides
        [Fact]
        public void CheckSidesIncludesAllSides()
        {
            IEnumerable<IOrderItem> sides = Menu.Sides();
            bool containsBakedBeans = false;
            bool containsChiliCheeseFries = false;
            bool containsDodgers = false;
            bool containsPan = false;
            foreach (IOrderItem i in sides)
            {
                if (i is BakedBeans) containsBakedBeans = true;
                if (i is CornDodgers) containsDodgers = true;
                if (i is ChiliCheeseFries) containsChiliCheeseFries = true;
                if (i is PanDeCampo) containsPan = true;
            }
            Assert.True(containsBakedBeans);
            Assert.True(containsDodgers);
            Assert.True(containsChiliCheeseFries);
            Assert.True(containsPan);
        }

        // Check all
        [Fact]
        public void CheckAllIncludesAllItems()
        {
            IEnumerable<IOrderItem> all = Menu.All;
            bool containsTea = false;
            bool containsWater = false;
            bool containsCoffee = false;
            bool containsSoda = false;
            bool containsBakedBeans = false;
            bool containsChiliCheeseFries = false;
            bool containsDodgers = false;
            bool containsPan = false;
            bool containsAngryChicken = false;
            bool containsCowpokeChili = false;
            bool containsDakotaDoubleBurger = false;
            bool containsRustlersRibs = false;
            bool containsTexasTripleBurger = false;
            bool containsTrailBurger = false;
            bool containsPecosPulledPork = false;
            foreach (IOrderItem i in all)
            {
                if (i is AngryChicken) containsAngryChicken = true;
                if (i is CowpokeChili) containsCowpokeChili = true;
                if (i is DakotaDoubleBurger) containsDakotaDoubleBurger = true;
                if (i is RustlersRibs) containsRustlersRibs = true;
                if (i is TexasTripleBurger) containsTexasTripleBurger = true;
                if (i is TrailBurger) containsTrailBurger = true;
                if (i is PecosPulledPork) containsPecosPulledPork = true;
                if (i is TexasTea) containsTea = true;
                if (i is Water) containsWater = true;
                if (i is CowboyCoffee) containsCoffee = true;
                if (i is JerkedSoda) containsSoda = true;
                if (i is BakedBeans) containsBakedBeans = true;
                if (i is CornDodgers) containsDodgers = true;
                if (i is ChiliCheeseFries) containsChiliCheeseFries = true;
                if (i is PanDeCampo) containsPan = true;
            }
            Assert.True(containsTea);
            Assert.True(containsWater);
            Assert.True(containsCoffee);
            Assert.True(containsSoda);
            Assert.True(containsBakedBeans);
            Assert.True(containsDodgers);
            Assert.True(containsChiliCheeseFries);
            Assert.True(containsPan);
            Assert.True(containsAngryChicken);
            Assert.True(containsCowpokeChili);
            Assert.True(containsDakotaDoubleBurger);
            Assert.True(containsRustlersRibs);
            Assert.True(containsTexasTripleBurger);
            Assert.True(containsTrailBurger);
            Assert.True(containsPecosPulledPork);
        }
    }
}
