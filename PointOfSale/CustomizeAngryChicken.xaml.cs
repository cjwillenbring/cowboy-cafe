/*
* Author: Cole Willenbring
* Class: CustomizeAngryChicken
* Purpose: Holds the class logic for the angry chicken customization screen control
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeAngryChicken.xaml
    /// </summary>
    public partial class CustomizeAngryChicken : UserControl
    {
        /// <summary>
        /// Constructor for the Angry Chicken Customization Component
        /// </summary>
        public CustomizeAngryChicken()
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
