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

namespace PointOfSale
{
    
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public CashDrawer cashDrawer = new CashDrawer();
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
    }
}
