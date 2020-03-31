/*
* Author: Cole Willenbring
* Class: CashControl
* Purpose: Holds the ui logic for the cash control
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
using System.ComponentModel;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl
    {
        /// <summary>
        /// Holds the current due change
        /// </summary>
        private double changeDue;

        private double runningTotal;
        /// <summary>
        /// Holds the current running total of inputted cash/coins
        /// </summary>
        public double RunningTotal
        {
            get => runningTotal;
            set
            {
                runningTotal = value;
                RunningTotalText.Text = "Running Total: " + runningTotal.ToString("C2");
                if (DataContext is Order order)
                {
                    if (runningTotal >= order.Total)
                    {
                        HandleTransactionComplete(runningTotal - Convert.ToDouble(order.Total.ToString("C2").Substring(1)));
                    }

                }
            }
        }

        /// <summary>
        /// Constructor for the cash control window control object class
        /// </summary>
        public CashControl()
        {
            InitializeComponent();
            runningTotal = 0;
            RunningTotalText.Text = "Running Total: " + runningTotal.ToString("C2");
        }

        /// <summary>
        /// Handles finished cash transaction
        /// </summary>
        void HandleTransactionComplete(double change)
        {

            int[] minChange = MinChange(change);
            StringBuilder sb = new StringBuilder();
            if (minChange[11] != 0) sb.Append("Pennies: " + minChange[11] + " ");
            if (minChange[10] != 0) sb.Append("Nickels: " + minChange[10] + " ");
            if (minChange[9] != 0) sb.Append("Dimes: " + minChange[9] + " ");
            if (minChange[8] != 0) sb.Append("Quarters: " + minChange[8] + " ");
            if (minChange[7] != 0) sb.Append("Half Dollars: " + minChange[7] + " ");
            if (minChange[6] != 0) sb.Append("Dollars: " + minChange[6] + " ");
            if (minChange[5] != 0) sb.Append("Two's: " + minChange[5] + " ");
            if (minChange[4] != 0) sb.Append("Five's: " + minChange[4] + " ");
            if (minChange[3] != 0) sb.Append("Ten's: " + minChange[3] + " ");
            if (minChange[2] != 0) sb.Append("Twenty's: " + minChange[2] + " ");
            if (minChange[1] != 0) sb.Append("Fifty's: " + minChange[1] + " ");
            if (minChange[0] != 0) sb.Append("Hundred's: " + minChange[0] + " ");
            ChangeDisplay.Text = "Change " + sb.ToString();
            //check register here
            //if valid, print receipt
            PennyButton.IsEnabled = false;
            NickelButton.IsEnabled = false;
            DimeButton.IsEnabled = false;
            QuarterButton.IsEnabled = false;
            HalfDollarButton.IsEnabled = false;
            DollarCoinButton.IsEnabled = false;
            OneBillButton.IsEnabled = false;
            TwoBillButton.IsEnabled = false;
            FiveBillButton.IsEnabled = false;
            TenBillButton.IsEnabled = false;
            TwentyBillButton.IsEnabled = false;
            FiftyBillButton.IsEnabled = false;
            HundredBillButton.IsEnabled = false;
            ReceiptButton.IsEnabled = true;
            changeDue = change;
        }

        /// <summary>
        /// Get minimum change required
        /// </summary>
        /// <param name="change">The total change needed</param>
        /// <returns>The denominations of the change</returns>
        int[] MinChange(double change)
        {
            double[] coins = new double[12] { 100, 50, 20, 10, 5, 2, 1, .5, .25, .1, .05, .01 };
            int[] current = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            if (change <= 0) return current;
            for (int i = 0; i <= 11; i++)
            {
                if(coins[i] <= change)
                {
                    // add while register has more than 0 coins/bills of the certain denomination
                    while(change - coins[i] >= 0)
                    {
                        change -= coins[i];
                        current[i] += 1;
                    }
                    if (change == 0) return current;
                }
            }
            return current;
        }

        /// <summary>
        /// Handles the click event for the print receipt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPrintClick(object sender, RoutedEventArgs e)
        {
            TransactionControl transactionControl = this.FindAncestor<TransactionControl>();
            transactionControl.PrintReciept(false, runningTotal, changeDue);
        }

        /// <summary>
        /// Handles the click event for the penny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPennyClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .01;
        }

        /// <summary>
        /// Handles the click event for the nickel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnNickelClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .05;
        }

        /// <summary>
        /// Handles the click event for the dime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDimeClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .1;
        }

        /// <summary>
        /// Handles the click event for the quarter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnQuarterClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .25;
        }

        /// <summary>
        /// Handles the click event for the half dollar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnHalfDollarClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .5;
        }

        /// <summary>
        /// Handles the click event for the dollar and dollar coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDollarClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 1;
        }

        /// <summary>
        /// Handles the click event for the 2 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTwoClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 2;
        }

        /// <summary>
        /// Handles the click event for the five dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnFiveClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 5;
        }

        /// <summary>
        /// Handles the click event for the 10 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTenClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 10;
        }

        /// <summary>
        /// Handles the click event for the 20 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTwentyClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 20;
        }

        /// <summary>
        /// Handles the click event for the 50 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnFiftyClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 50;
        }

        /// <summary>
        /// Handles the click event for the 100 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnHundredClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 100;
        }
    }
}
