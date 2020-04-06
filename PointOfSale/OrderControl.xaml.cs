/*

* Author: Alex Moffet

* Class name: OrderControl

* Purpose: The User's Interface

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
using CashRegister;
using System.ComponentModel;

namespace PointOfSale
{
    
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CashDrawer drawer = new CashDrawer();
        public double drawerExcess = 0.0;
        

        public OrderControl()
        {

            InitializeComponent();

            var data = new Order();
            this.DataContext = data;
            
        }
        

        
        /// <summary>
        /// item selection mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
        /// <summary>
        /// cancels the last order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();
        }
        /// <summary>
        /// completes the last order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new TransactionControl();
        }
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// The total currency in the drawer
        /// </summary>
        public double totalValue => drawer.TotalValue;

        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    drawerExcess += .01;
                    
                }
                else
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    drawerExcess -= .01;
                }
                InvokePropertyChanged("Pennies");
            }
        }

        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                {

                    drawer.AddCoin(Coins.Nickel, quantity);
                    drawerExcess += .05;
                    
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    drawerExcess -= .05;
                }
                InvokePropertyChanged("Nickels");
            }
        }

        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                {

                    drawer.AddCoin(Coins.Dime, quantity);
                    drawerExcess += .1;
                   
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                    drawerExcess -= .1;
                }
                InvokePropertyChanged("Dimes");
            }
        }

        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                {

                    drawer.AddCoin(Coins.Quarter, quantity);
                    drawerExcess += .25;
                    
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                    drawerExcess -= .25;
                }
                InvokePropertyChanged("Quarters");
            }
        }

        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                {

                    drawer.AddCoin(Coins.HalfDollar, quantity);
                    drawerExcess += .5;
                   
                }
                else
                {
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                    drawerExcess -= .5;
                }
                InvokePropertyChanged("HalfDollars");
            }
        }

        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0)
                {

                    drawer.AddCoin(Coins.Dollar, quantity);
                    drawerExcess += 1.0;
                   
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                    drawerExcess -= 1.0;
                }
                InvokePropertyChanged("Dollars");
            }
        }

        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                {

                    drawer.AddBill(Bills.One, quantity);
                    drawerExcess += 1.0;
                    
                }
                else
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                    drawerExcess -= 1.0;
                }
                InvokePropertyChanged("Ones");
            }
        }

        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                {

                    drawer.AddBill(Bills.Two, quantity);
                    drawerExcess += 2.0;
                    
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                    drawerExcess -= 2.0;
                }
                InvokePropertyChanged("Twos");
            }
        }

        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {

                    drawer.AddBill(Bills.Five, quantity);
                    drawerExcess += 5.0;
                    
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                    drawerExcess -= 5.0;
                }
                InvokePropertyChanged("Fives");
            }
        }

        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                {

                    drawer.AddBill(Bills.Ten, quantity);
                    drawerExcess += 10.0;
                    
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                    drawerExcess -= 10.0;
                }
                InvokePropertyChanged("Tens");
            }
        }

        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {

                    drawer.AddBill(Bills.Twenty, quantity);
                    drawerExcess += 20.0;
                   
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                    drawerExcess -= 20.0;
                }
                InvokePropertyChanged("Twenties");
            }
        }

        public int Fifties
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                {

                    drawer.AddBill(Bills.Fifty, quantity);
                    drawerExcess += 50.0;
                    
                }
                else
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                    drawerExcess -= 50.0;
                }
                InvokePropertyChanged("Fifties");
            }
        }

        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {

                    drawer.AddBill(Bills.Hundred, quantity);
                    drawerExcess += 100.0;
                    
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                    drawerExcess -= 100.0;
                }
                InvokePropertyChanged("Hundreds");
            }
        }

        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
