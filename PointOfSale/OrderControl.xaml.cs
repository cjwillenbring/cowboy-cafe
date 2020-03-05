/*
* Author: Cole Willenbring
* Class: OrderControl
* Purpose: Holds the ui logic for the order control
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Initialize the Order Control class and add event handlers
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            
            var data = new Order();
            DataContext = data;
        }

        /// <summary>
        /// Bubble up changes to the order
        /// </summary>
        public void OnItemChanged()
        {
            if(DataContext is Order data) 
            {
                data.UpdateItems();
            }
        }

        /// <summary>
        /// Handles the click event for the item selection button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnItemSelectionClick(object sender, RoutedEventArgs e)
        {
            var selectScreen = new MenuItemSelectionControl();
            SwapScreen(selectScreen);
            return;
        }

        /// <summary>
        /// Handles the click event for the cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Handles the click event for the complete order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
    }
}
