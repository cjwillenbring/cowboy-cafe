﻿using System;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeChiliCheeseFries.xaml
    /// </summary>
    public partial class CustomizeChiliCheeseFries : UserControl
    {
        /// <summary>
        /// Constructor for the CustomizeChiliCheeseFries Control
        /// </summary>
        public CustomizeChiliCheeseFries()
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
