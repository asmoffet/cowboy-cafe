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
using CashRegister;
using CowboyCafe.Data;
using PointOfSale.Customization;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();
        }

        private void end_Click(object sender, RoutedEventArgs e)
        {
            double price = Convert.ToDouble(Tot.Text.ToString());
            double payment = Convert.ToDouble(Owed.Text.ToString());
            var oc = this.FindAncestor<OrderControl>();
            CashDrawer cd = oc.drawer;
            int hundreds = 0;
            int fifties = 0;
            int twenties = 0;
            int tens = 0;
            int fives = 0;
            int twos = 0;
            int ones = 0;
            int dollars = 0;
            int halfs = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            StringBuilder sb = new StringBuilder();
            if(price > payment)
            {
                MessageBox.Show("You need to pay more money.");
                return;
            }
            double change = payment - price;
            while(change > 100 && cd.Hundreds > 0)
            {
                hundreds++;
                change -= 100;
            }
            while(change > 50 && cd.Fifties > 0)
            {
                fifties++;
                change -= 50;
            }
            while(change > 20 && cd.Twenties > 0)
            {
                twenties++;
                change -= 20;
            }
            while(change > 10 && cd.Tens > 0)
            {
                tens++;
                change -= 20;
            }
            while(change > 5 && cd.Fives > 0)
            {
                fives++;
                change -= 5;
            }
            while(change > 2 && cd.Twos > 0)
            {
                twos++;
                change -= 2;
            }
            while(change > 1 && cd.Ones > 0)
            {
                ones++;
                change -= 1;
            }
            while(change > 1 && cd.Dollars > 0)
            {
                dollars++;
                change -= 1;
            }
            while(change > .5 && cd.HalfDollars > 0)
            {
                halfs++;
                change -= .5;
            }
            while (change > .25 && cd.Quarters > 0)
            {
                quarters++;
                change -= .25;
            }
            while(change > .1 && cd.Dimes > 0)
            {
                dimes++;
                change -= .1;
            }
            while(change > .05 && cd.Nickels > 0)
            {
                nickels++;
                change -= .05;
            }
            while(change > .01 && cd.Pennies > 0)
            {
                pennies++;
                change -= .01;
            }
            if(change != 0)
            {
                MessageBox.Show("Not enought currency in the drawer, as management for more, then update the drawer using the + buttons");
            }
            sb.Append("Please give the customer:\n");
            sb.Append(WhatToPay(hundreds, "Hundreds"));
            sb.Append(WhatToPay(fifties, "Fifties"));
            sb.Append(WhatToPay(twenties, "Twenties"));
            sb.Append(WhatToPay(tens, "Tens"));
            sb.Append(WhatToPay(fives, "Fives"));
            sb.Append(WhatToPay(twos, "Twos"));
            sb.Append(WhatToPay(ones, "Ones"));
            sb.Append(WhatToPay(dollars, "Dollars"));
            sb.Append(WhatToPay(halfs, "Half DOllars"));
            sb.Append(WhatToPay(quarters, "Quarters"));
            sb.Append(WhatToPay(dimes, "Dimes"));
            sb.Append(WhatToPay(nickels, "Nickels"));
            sb.Append(WhatToPay(pennies, "Pennies"));
            MessageBox.Show(sb.ToString());

            string[] orderItems = new string[oc.OrderControlOrderSummaryControl.ListBoxSummary.Items.Count];
            for (int i = 0; i < oc.OrderControlOrderSummaryControl.ListBoxSummary.Items.Count; i++)
            {
                orderItems[i] = oc.OrderControlOrderSummaryControl.ListBoxSummary.Items[i].ToString();
            }
            int ordernumber = Convert.ToInt32(oc.OrderControlOrderSummaryControl.OrderNumber.ToString());
            double subtotal = Convert.ToDouble(Sub.Text.ToString());

            ReceiptPrinter rp = new ReceiptPrinter();
            rp.Print(PrintCash(payment, subtotal, ordernumber, orderItems, payment));
            oc.SwapScreen(new MainWindow());
        }
        private string WhatToPay(int amount, string type)
        {
            if(amount != 0)
            {
                return (String.Format("{0} {1}\n", amount, type));
            }
            return "";
        }
        private string PrintCash(double total, double subtotal, int orderNumber, string[] order, double cash)
        {
            StringBuilder sb = new StringBuilder();
            double change = cash - total;
            sb.Append(String.Format("Order Number: {0} \n", orderNumber));
            sb.Append(String.Format("Date: {0}\n", DateTime.Now));
            sb.Append("Items:\n");
            foreach (string s in order)
            {
                sb.Append(s);
                sb.Append("\n");
            }
            sb.Append(String.Format("Order Subtotal: {0} \nOrder Total: {1} \nCash Payed: {2} \nChange: {3}", subtotal, total, cash, change));
            return sb.ToString();
        }
    }
}
