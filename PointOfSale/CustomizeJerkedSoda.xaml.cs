﻿/*
* Author: Cole Willenbring
* Class: CustomizeJerkedSoda
* Purpose: Holds the class logic for the jerked soda customization screen control
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
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        /// <summary>
        /// Constructor for the CustomizeJerkedSoda Class
        /// </summary>
        public CustomizeJerkedSoda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bubble up changes to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnEventChange(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl is OrderControl oC)
            {
                oC.OnItemChanged();
            }
        }
    }
}
