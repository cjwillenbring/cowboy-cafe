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
        /// Function to toggle screen to go back to customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ToggleScreen(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                if (sender is ListBox li)
                {
                    if (li.SelectedItem is IOrderItem ioi)
                    { 
                        {
                            if (ioi is CowpokeChili cc)
                            {
                                var screen = new CustomizeCowpokeChili();
                                screen.DataContext = cc;
                                orderControl = this.FindAncestor<OrderControl>();
                                orderControl.SwapScreen(screen);
                            }
                        }
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
