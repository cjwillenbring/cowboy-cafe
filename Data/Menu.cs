/*
* Author: Cole Willenbring
* Class: Menu
* Purpose: Holds the class logic for the Menu class to help abstract some of the web rendering
*/
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Holds the logic for the static menu class
    /// </summary>
    public static class Menu
    {
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
