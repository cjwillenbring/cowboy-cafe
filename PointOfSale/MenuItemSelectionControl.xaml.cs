/*
* Author: Cole Willenbring
* Class: MenuItemSelectionControl
* Purpose: Holds the logic for the menu item selection control ui
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderControl orderControl;

        /// <summary>
        /// Constructor for the menu item selection ui component
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPandeCampoButton.Click += OnAddPandeCampoButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
        }

        /// <summary>
        /// Event handler for adding the cowpoke chili entree to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                var newChili = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                screen.DataContext = newChili;
                data.Add(newChili);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the rustler's ribs entree to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newRustlersRibs = new RustlersRibs();
                var screen = new CustomizeRustlersRibs();
                screen.DataContext = newRustlersRibs;
                data.Add(newRustlersRibs);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the pulled pork entree to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newPulledPork = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();
                screen.DataContext = newPulledPork;
                data.Add(newPulledPork);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the trail burger entree to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newTrailBurger = new TrailBurger();
                var screen = new CustomizeTrailBurger();
                screen.DataContext = newTrailBurger;
                data.Add(newTrailBurger);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the dakota double burger entree to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newDakotaDouble = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDoubleBurger();
                screen.DataContext = newDakotaDouble;
                data.Add(newDakotaDouble);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the texas triple burger entree to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newTexasTripleBurger = new TexasTripleBurger();
                var screen = new CustomizeTexasTripleBurger();
                screen.DataContext = newTexasTripleBurger;
                data.Add(newTexasTripleBurger);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the angry chicken entree to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newChicken = new AngryChicken();
                var screen = new CustomizeAngryChicken();
                screen.DataContext = newChicken;
                data.Add(newChicken);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the chili cheese fries side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newChiliCheeseFries = new ChiliCheeseFries();
                var screen = new CustomizeChiliCheeseFries();
                screen.DataContext = newChiliCheeseFries;
                data.Add(newChiliCheeseFries);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the corn dodgers side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newCornDodgers = new CornDodgers();
                var screen = new CustomizeCornDodgers();
                screen.DataContext = newCornDodgers;
                data.Add(newCornDodgers);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the pan de campo side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPandeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newPanDeCampo = new PanDeCampo();
                var screen = new CustomizePanDeCampo();
                screen.DataContext = newPanDeCampo;
                data.Add(newPanDeCampo);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the baked beans side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newBakedBeans = new BakedBeans();
                var screen = new CustomizeBakedBeans();
                screen.DataContext = newBakedBeans;
                data.Add(newBakedBeans);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the jerked soda drink to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newJerkedSoda = new JerkedSoda();
                var screen = new CustomizeJerkedSoda();
                screen.DataContext = newJerkedSoda;
                data.Add(newJerkedSoda);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the Texas Tea drink to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newTexasTea = new TexasTea();
                var screen = new CustomizeTexasTea();
                screen.DataContext = newTexasTea;
                data.Add(newTexasTea);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the cowboy coffee drink to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newCowboyCoffee = new CowboyCoffee();
                var screen = new CustomizeCowboyCoffee();
                screen.DataContext = newCowboyCoffee;
                data.Add(newCowboyCoffee);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler for adding the water drink to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                var newWater = new Water();
                var screen = new CustomizeWater();
                screen.DataContext = newWater;
                data.Add(newWater);
                orderControl = this.FindAncestor<OrderControl>();
                orderControl.SwapScreen(screen);
            }
        }
    }
}
