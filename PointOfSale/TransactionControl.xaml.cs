/*
* Author: Cole Willenbring
* Class: TransactionControl
* Purpose: Holds the ui logic for the transaction control
*/
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// Public constructor for the transaction control window control object class
        /// </summary>
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
            if(orderControl is OrderControl orderControl1) orderControl1.NewOrder();
        }

        /// <summary>
        /// Handles the click event for the pay with cash button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPayWithCardClick(object sender, RoutedEventArgs e)
        {
            PopupText.Visibility = Visibility.Collapsed;
            if (DataContext is Order order)
            {
                var cardTerminal = new CardTerminal();
                ResultCode result = cardTerminal.ProcessTransaction(order.Total);
                if(result == ResultCode.Success) 
                {
                    PrintReciept(true);
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl is OrderControl orderControl1) orderControl1.NewOrder();
                }
                else 
                {
                    DisplayPopup(result.ToString());
                }
            }
        }

        /// <summary>
        /// Handles the click event for the pay with card button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPayWithCashClick(object sender, RoutedEventArgs e)
        {
            PopupText.Visibility = Visibility.Collapsed;
            OneBillButton.IsEnabled = true;
            TwoBillButton.IsEnabled = true;
            FiveBillButton.IsEnabled = true;
            TenBillButton.IsEnabled = true;
            TwentyBillButton.IsEnabled = true;
            FiftyBillButton.IsEnabled = true;
            HundredBillButton.IsEnabled = true;
            PennyButton.IsEnabled = true;
            NickelButton.IsEnabled = true;
            DimeButton.IsEnabled = true;
            QuarterButton.IsEnabled = true;
            HalfDollarButton.IsEnabled = true;
            DollarCoinButton.IsEnabled = true;
            CashButton.IsEnabled = false;
            CardButton.IsEnabled = false;
        }

        /// <summary>
        /// Prints the receipt for the current order
        /// </summary>
        /// <param name="credit">Whether or not a card was used</param>
        /// <param name="paid">The amount paid in cash if applicable</param>
        /// <param name="change">The change received if applicable</param>
        public void PrintReciept(bool credit, double paid=0.00, double change=0.00)
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
                sb.Append("Subtotal: " + order.Subtotal.ToString("C2") + "\n");
                sb.Append("Total: " + order.Total.ToString("C2") + "\n");
                if(credit) sb.Append("CREDIT" + "\n\n");
                else
                {
                    sb.Append("CASH" + "\n");
                    sb.Append("Paid: " + paid.ToString("C2") + "\n");
                    sb.Append("Change: " + (change/100.00).ToString("C2") + "\n\n");
                }
            }
            string toPrint = sb.ToString();
            var receiptPrinter = new ReceiptPrinter();
            receiptPrinter.Print(sb.ToString());
            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl is OrderControl orderControl1) orderControl1.NewOrder();
        }

        /// <summary>
        /// Displays a failure popup
        /// </summary>
        /// <param name="result">The error being displayed</param>
        public void DisplayPopup(string result)
        {
            PopupText.Text = result + "\nTry a different payment method\nChoose cash or card again to close this alert";
            PopupText.Visibility = Visibility.Visible;
        }

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
                    int total = (int)(Convert.ToDouble(order.Total.ToString("C2").Substring(1)) * 100);
                    if ((runningTotal*100) >= total)
                    {
                        HandleTransactionComplete((int) (runningTotal * 100) - total);
                    }

                }
            }
        }

        private int[] currencyUsed = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        /// <summary>
        /// Handles finished cash transaction
        /// </summary>
        void HandleTransactionComplete(int change)
        {
            var oc = this.FindAncestor<OrderControl>();
            if (oc is OrderControl orderControl)
            {
                orderControl.cashDrawer.AddBill(CashRegister.Bills.Fifty, currencyUsed[1]);
                orderControl.cashDrawer.AddBill(CashRegister.Bills.Twenty, currencyUsed[2]);
                orderControl.cashDrawer.AddBill(CashRegister.Bills.Ten, currencyUsed[3]);
                orderControl.cashDrawer.AddBill(CashRegister.Bills.Five, currencyUsed[4]);
                orderControl.cashDrawer.AddBill(CashRegister.Bills.Two, currencyUsed[5]);
                orderControl.cashDrawer.AddBill(CashRegister.Bills.One, currencyUsed[6]);
                orderControl.cashDrawer.AddCoin(CashRegister.Coins.HalfDollar, currencyUsed[7]);
                orderControl.cashDrawer.AddCoin(CashRegister.Coins.Quarter, currencyUsed[8]);
                orderControl.cashDrawer.AddCoin(CashRegister.Coins.Dime, currencyUsed[9]);
                orderControl.cashDrawer.AddCoin(CashRegister.Coins.Nickel, currencyUsed[10]);
                orderControl.cashDrawer.AddCoin(CashRegister.Coins.Penny, currencyUsed[11]);
                int[] minChange = MinChange(change, orderControl);
                if (minChange[0] == -1)
                {
                    TransactionControl transactionControl = new TransactionControl();
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Hundred, currencyUsed[0]);
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Fifty, currencyUsed[1]);
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Twenty, currencyUsed[2]);
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Ten, currencyUsed[3]);
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Five, currencyUsed[4]);
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Two, currencyUsed[5]);
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.One, currencyUsed[6]);
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.HalfDollar, currencyUsed[7]);
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.Quarter, currencyUsed[8]);
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.Dime, currencyUsed[9]);
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.Nickel, currencyUsed[10]);
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.Penny, currencyUsed[11]);
                    orderControl.SwapScreen(transactionControl);
                    transactionControl.DisplayPopup("Not enough change in drawer for this transaction.\nReturning coins and bills used in this transaction\nConsider using more precise denominations");
                    RunningTotal = 0;
                    return;
                }
                StringBuilder sb = new StringBuilder();
                if (minChange[11] != 0)
                {
                    sb.Append("Pennies: " + minChange[11] + " ");
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.Penny, minChange[11]);
                }
                if (minChange[10] != 0)
                {
                    sb.Append("Nickels: " + minChange[10] + " ");
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.Nickel, minChange[10]);
                }
                if (minChange[9] != 0)
                {
                    sb.Append("Dimes: " + minChange[9] + " ");
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.Dime, minChange[9]);
                }
                if (minChange[8] != 0)
                {
                    sb.Append("Quarters: " + minChange[8] + " ");
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.Quarter, minChange[8]);
                }
                if (minChange[7] != 0)
                {
                    sb.Append("Half Dollars: " + minChange[7] + " ");
                    orderControl.cashDrawer.RemoveCoin(CashRegister.Coins.HalfDollar, minChange[7]);
                }
                if (minChange[6] != 0)
                {
                    sb.Append("Dollars: " + minChange[6] + " ");
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.One, minChange[6]);
                }
                if (minChange[5] != 0)
                {
                    sb.Append("Twos: " + minChange[5] + " ");
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Two, minChange[5]);
                }
                if (minChange[4] != 0)
                {
                    sb.Append("Fives: " + minChange[4] + " ");
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Five, minChange[4]);
                }
                if (minChange[3] != 0)
                {
                    sb.Append("Tens: " + minChange[3] + " ");
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Ten, minChange[3]);
                }
                if (minChange[2] != 0)
                {
                    sb.Append("Twenties: " + minChange[2] + " ");
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Twenty, minChange[2]);
                }
                if (minChange[1] != 0)
                {
                    sb.Append("Fifties: " + minChange[1] + " ");
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Fifty, minChange[1]);
                }
                if (minChange[0] != 0)
                {
                    sb.Append("Hundreds: " + minChange[0] + " ");
                    orderControl.cashDrawer.RemoveBill(CashRegister.Bills.Hundred, minChange[0]);
                }
                ChangeDisplay.Text = "Change: " + sb.ToString();
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
                CancelButton.IsEnabled = false;
                ReceiptButton.IsEnabled = true;
                changeDue = change;
            }
        }

        /// <summary>
        /// Get minimum change required
        /// </summary>
        /// <param name="change">The total change needed</param>
        /// <returns>The denominations of the change</returns>
        int[] MinChange(int change, OrderControl orderControl)
        {
            int[] coins = new int[12] { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };
            int[] current = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            if (change <= 0) return current;
            int i = 0;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Hundreds > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Fifties > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Twenties > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Tens > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Fives > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Twos > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Ones > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.HalfDollars > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Quarters > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Dimes > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Nickels > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            i += 1;
            // add while register has more than 0 coins/bills of the certain denomination
            while (change - coins[i] >= 0 && orderControl.cashDrawer.Pennies > current[i])
            {
                change -= coins[i];
                current[i] += 1;
            }
            if (change == 0) return current;
            return new int[] { -1 };
        }

        /// <summary>
        /// Handles the click event for the print receipt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPrintClick(object sender, RoutedEventArgs e)
        {
            PrintReciept(false, runningTotal, changeDue);
        }

        /// <summary>
        /// Handles the click event for the penny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPennyClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .01;
            currencyUsed[11] += 1;
        }

        /// <summary>
        /// Handles the click event for the nickel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnNickelClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .05;
            currencyUsed[10] += 1;
        }

        /// <summary>
        /// Handles the click event for the dime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDimeClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .1;
            currencyUsed[9] += 1;
        }

        /// <summary>
        /// Handles the click event for the quarter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnQuarterClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .25;
            currencyUsed[8] += 1;
        }

        /// <summary>
        /// Handles the click event for the half dollar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnHalfDollarClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += .5;
            currencyUsed[7] += 1;
        }

        /// <summary>
        /// Handles the click event for the dollar and dollar coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDollarClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 1;
            currencyUsed[6] += 1;
        }

        /// <summary>
        /// Handles the click event for the 2 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTwoClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 2;
            currencyUsed[5] += 1;
        }

        /// <summary>
        /// Handles the click event for the five dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnFiveClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 5;
            currencyUsed[4] += 1;
        }

        /// <summary>
        /// Handles the click event for the 10 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTenClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 10;
            currencyUsed[3] += 1;
        }

        /// <summary>
        /// Handles the click event for the 20 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTwentyClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 20;
            currencyUsed[2] += 1;
        }

        /// <summary>
        /// Handles the click event for the 50 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnFiftyClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 50;
            currencyUsed[1] += 1;
        }

        /// <summary>
        /// Handles the click event for the 100 dollar bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnHundredClick(object sender, RoutedEventArgs e)
        {
            RunningTotal += 100;
            currencyUsed[0] += 1;
        }
    }
}
