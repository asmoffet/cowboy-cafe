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
                //print receipt
                
                var ordercontrol = this.FindAncestor<OrderControl>();
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
    }
}
