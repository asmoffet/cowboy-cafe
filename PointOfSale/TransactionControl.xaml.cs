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
using PointOfSale.Customization;
using PointOfSale.ExtensionMethods;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        
        public TransactionControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            ordercontrol.SwapScreen(new MenuItemSelectionControl());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            var ordercontrol = this.FindAncestor<OrderControl>();
            ordercontrol.SwapScreen(new MainWindow());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CardTerminal readCard = new CardTerminal();

            double totalPrice = Convert.ToDouble(Sum.Text.ToString());
            
            
            string read = readCard.ProcessTransaction(totalPrice).ToString();
            if (read == "Success")
            {                
                var ordercontrol = this.FindAncestor<OrderControl>();
                string[] orderItems = new string[ordercontrol.OrderControlOrderSummaryControl.ListBoxSummary.Items.Count];
                for(int i = 0; i < ordercontrol.OrderControlOrderSummaryControl.ListBoxSummary.Items.Count; i++)
                {
                    orderItems[i] = ordercontrol.OrderControlOrderSummaryControl.ListBoxSummary.Items[i].ToString();
                }
                int ordernumber = Convert.ToInt32(ordercontrol.OrderControlOrderSummaryControl.OrderNumber.ToString());
                double subtotal = Convert.ToDouble(Sub.Text.ToString());

                ReceiptPrinter rp = new ReceiptPrinter();
                rp.Print(PrintCredit(totalPrice, subtotal, ordernumber, orderItems));

                ordercontrol.SwapScreen(new MenuItemSelectionControl());
                ordercontrol.DataContext = new Order();
            }
            if(read == "InsufficientFunds")
            {
                MessageBox.Show("Insufficient Funds");
            }
            if(read == "CancelledCard")
            {
                MessageBox.Show("Cancelled Card");
            }
            if(read == "ReadError")
            {
                MessageBox.Show("Read Error");
            }
            if(read == "UnkownError")
            {
                MessageBox.Show("Unkown Error");
            }

        }

        private string PrintCredit(double total, double subtotal, int orderNumber, string[] order)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Order Number: {0} \n",orderNumber));
            sb.Append(String.Format("Date: {0}\n", DateTime.Now));
            sb.Append("Items:\n");
            foreach(string s in order)
            {
                sb.Append(s);
                sb.Append("\n");
            }
            sb.Append(String.Format("Order Subtotal: {0} \nOrder Total: {1}", subtotal, total));
            return sb.ToString();
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
            sb.Append(String.Format("Order Subtotal: {0} \nOrder Total: {1} \nChange: {2}", subtotal, total, change));
            return sb.ToString();
        }
    }
}
