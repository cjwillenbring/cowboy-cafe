/*
* Author: Cole Willenbring
* Class: OrderSummaryControl
* Purpose: Holds the logic for the order summary control ui
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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Order control property used for persisting changes in child elements 
        /// up to the parent window control elements
        /// </summary>
        private OrderControl orderControl;

        /// <summary>
        /// Constructor for the OrderSummaryControl
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to toggle screen to go back to customization later on in the order process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ToggleScreen(object sender, RoutedEventArgs e)
        {
            if (sender is ListBox li)
            {
                if (li.SelectedItem is IOrderItem ioi)
                { 
                    if (ioi is AngryChicken angryChicken)
                    {
                        var screen = new CustomizeAngryChicken();
                        screen.DataContext = angryChicken;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    } else if (ioi is BakedBeans bakedBeans)
                    {
                        var screen = new CustomizeBakedBeans();
                        screen.DataContext = bakedBeans;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is ChiliCheeseFries chiliCheeseFries)
                    {
                        var screen = new CustomizeChiliCheeseFries();
                        screen.DataContext = chiliCheeseFries;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is CornDodgers cornDodgers)
                    {
                        var screen = new CustomizeCornDodgers();
                        screen.DataContext = cornDodgers;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is CowboyCoffee cowboyCoffee)
                    {
                        var screen = new CustomizeCowboyCoffee();
                        screen.DataContext = cowboyCoffee;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is CowpokeChili cowpokeChili)
                    {
                        var screen = new CustomizeCowpokeChili();
                        screen.DataContext = cowpokeChili;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is DakotaDoubleBurger dakotaDoubleBurger)
                    {
                        var screen = new CustomizeDakotaDoubleBurger();
                        screen.DataContext = dakotaDoubleBurger;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is JerkedSoda jerkedSoda)
                    {
                        var screen = new CustomizeJerkedSoda();
                        screen.DataContext = jerkedSoda;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is PanDeCampo panDeCampo)
                    {
                        var screen = new CustomizePanDeCampo();
                        screen.DataContext = panDeCampo;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is PecosPulledPork pecosPulledPork)
                    {
                        var screen = new CustomizePecosPulledPork();
                        screen.DataContext = pecosPulledPork;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is RustlersRibs rustlersRibs)
                    {
                        var screen = new CustomizeRustlersRibs();
                        screen.DataContext = rustlersRibs;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is TexasTea texasTea)
                    {
                        var screen = new CustomizeTexasTea();
                        screen.DataContext = texasTea;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is TexasTripleBurger texasTripleBurger)
                    {
                        var screen = new CustomizeTexasTripleBurger();
                        screen.DataContext = texasTripleBurger;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is TrailBurger trailBurger)
                    {
                        var screen = new CustomizeTrailBurger();
                        screen.DataContext = trailBurger;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (ioi is Water water)
                    {
                        var screen = new CustomizeWater();
                        screen.DataContext = water;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    } 
                    else
                    {
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Function to remove an item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                if(sender is Button s)
                {
                    if(s.DataContext is IOrderItem item)
                    {
                        data.Remove(item);
                    }
                }
            }
        }
    }
}
