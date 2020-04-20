/*
* Author: Cole Willenbring
* Class: Menu
* Purpose: Holds the class logic for the Menu class to help abstract some of the web rendering
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Holds the logic for the static menu class
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets the possible Order Items
        /// </summary>
        public static string[] ItemCategories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// Gets all the items on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return CompleteMenu(); } }

        /// <summary>
        /// Searches the for matching order items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of items</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return CompleteMenu();
            foreach (IOrderItem item in All)
            {
                if (item!= null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// </summary>
        /// <param name="items">The collection of order items to filter</param>
        /// <param name="categories">The categories to include</param>
        /// <returns>A collection containing only items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in All)
            {
                if(item != null)
                {
                    if (item is Drink && categories.Contains("Drink")) results.Add(item);
                    if (item is Entree && categories.Contains("Entree")) results.Add(item);
                    if (item is Side && categories.Contains("Side")) results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by calories
        /// </summary>
        /// <param name="items">List of items</param>
        /// <param name="min">Minimum calories</param>
        /// <param name="max">Maximum calories</param>
        /// <returns>List of filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in All)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in All)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in All)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by price
        /// </summary>
        /// <param name="items">List of items</param>
        /// <param name="min">Minimum price</param>
        /// <param name="max">Maximum price</param>
        /// <returns>List of filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in All)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in All)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in All)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Gets an enumerable of entrees
        /// </summary>
        /// <returns>An enumerable of entree order items</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());
            entrees.Add(new PecosPulledPork());

            IEnumerable<IOrderItem> entreesIE = entrees;
            return entreesIE;
        }

        /// <summary>
        /// Gets an enumerable of sides
        /// </summary>
        /// <returns>An enumerable of side order items</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());

            IEnumerable<IOrderItem> sidesIE = sides;
            return sidesIE;
        }

        /// <summary>
        /// Gets an enumerable of drinks
        /// </summary>
        /// <returns>An enumerable of drink order items</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new JerkedSoda());
            drinks.Add(new Water());
            drinks.Add(new CowboyCoffee());
            drinks.Add(new TexasTea());

            IEnumerable<IOrderItem> drinksIE = drinks;
            return drinksIE;
        }

        /// <summary>
        /// Gets an enumerable of the complete menu
        /// </summary>
        /// <returns>An enumerable of drink order items</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add(new AngryChicken());
            menu.Add(new CowpokeChili());
            menu.Add(new DakotaDoubleBurger());
            menu.Add(new RustlersRibs());
            menu.Add(new TexasTripleBurger());
            menu.Add(new TrailBurger());
            menu.Add(new PecosPulledPork());

            menu.Add(new JerkedSoda());
            menu.Add(new Water());
            menu.Add(new CowboyCoffee());
            menu.Add(new TexasTea());

            menu.Add(new BakedBeans());
            menu.Add(new ChiliCheeseFries());
            menu.Add(new CornDodgers());
            menu.Add(new PanDeCampo());

            IEnumerable<IOrderItem> menuIE = menu;
            return menuIE;
        }

        /// <summary>
        /// Updates the size state of the passed in side object
        /// </summary>
        /// <param name="side">The side object passed in</param>
        /// <param name="s">The desired size</param>
        public static void ChangeSideSize(Side side, Size s)
        {
            side.Size = s;
        }

        /// <summary>
        /// Updates the size state of the passed in drink object
        /// </summary>
        /// <param name="drink">The drink object passed in</param>
        /// <param name="s">The desired size</param>
        public static void ChangeDrinkSize(Drink drink, Size s)
        {
            drink.Size = s;
        }
    }
}
