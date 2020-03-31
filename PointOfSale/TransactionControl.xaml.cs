using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// Order control property used for persisting changes in child elements 
        /// up to the parent window control elements
        /// </summary>
        private OrderControl orderControl;

        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for the cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.NewOrder();
        }

        /// <summary>
        /// Handles the click event for the complete order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderClick(object sender, RoutedEventArgs e)
        {
            

        }

        /// <summary>
        /// Handles the click event for the pay with cash button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPayWithCardClick(object sender, RoutedEventArgs e)
        {
            /* 
                if (DataContext is Order order)
                {
                    var cardTerminal = new CardTerminal();
                    ResultCode result = cardTerminal.ProcessTransaction(order.Total());
                    if(result == ResultCode.Success) 
                    {
                        PrintReciept(true);
                        orderControl.NewOrder();
                    } else 
                    {
                        DisplayPopup(result);
                    }
                }
            */
        }

        /// <summary>
        /// Handles the click event for the pay with card button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPayWithCashClick(object sender, RoutedEventArgs e)
        {
            /* var orderControl = this.FindAncestor<OrderControl>();
               orderControl.NewOrder();
               orderControl.cashDrawer;
             */
        }

        /// <summary>
        /// Prints the receipt for the current order
        /// </summary>
        /// <param name="credit">Whether or not a card was used</param>
        /// <param name="paid">The amount paid in cash if applicable</param>
        /// <param name="change">The change received if applicable</param>
        void PrintReciept(bool credit, double paid=0.00, double change=0.00)
        {
            StringBuilder sb = new StringBuilder();
            if (DataContext is Order order)
            {
                sb.Append("Order Number: " + order.OrderNumber + "\n");
                sb.Append(DateTime.Now + "\n");
                foreach (IOrderItem io in order.Items)
                {
                    sb.Append(io.ToString() + "\n");
                    foreach (string s in io.SpecialInstructions)
                    {
                        sb.Append("\t" + s + "\n");
                    }
                }
                sb.Append(order.Subtotal + "\n");
                sb.Append(order.Total + "\n");
                if(credit) sb.Append("CREDIT");
                else
                {
                    sb.Append("CASH" + "\n");
                    sb.Append("Paid: " + paid + "\n");
                    sb.Append("Change: " + change + "\n");
                }
            }
            string toPrint = sb.ToString();
            //Print(sb.ToString());
        }

        /// <summary>
        /// Displays a failure popup
        /// </summary>
        /// <param name="result">The error being displayed</param>
        void DisplayPopup(string result)
        {
            Popup codePopup = new Popup();
            codePopup.Height = 100;
            codePopup.Width = 700;
            codePopup.Margin = new Thickness(10);
            TextBlock popupText = new TextBlock();
            popupText.FontSize = 20;
            popupText.Text = result + "\nTry a different payment method\nClick anywhere to close this alert";
            popupText.Background = Brushes.White;
            popupText.Foreground = Brushes.Black;
            codePopup.Child = popupText;
            codePopup.PlacementTarget = CardButton;
            codePopup.IsOpen = true;
            codePopup.StaysOpen = false;
        }
    }
}
