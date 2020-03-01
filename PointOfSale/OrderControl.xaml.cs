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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        private OrderSummaryControl orderSummaryControl = new OrderSummaryControl();
        public OrderControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds angry chicken to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            OrderSummaryControl orderSummaryControl = new OrderSummaryControl();
            orderSummaryControl.OrderList.Items.Add(new AngryChicken());
        }
        /// <summary>
        /// adds pecos pulled pork to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new PecosPulledPork());
        }
        /// <summary>
        /// adds cowpoke chilli to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChilliButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new CowpokeChili());
        }
        /// <summary>
        /// adds dakota double burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBugrerButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new DakotaDoubleBurger());
        }
        /// <summary>
        /// adds baked beans to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new BakedBeans());
        }
        /// <summary>
        /// adds chili cheese fries to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChilliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new ChiliCheeseFries());
        }
        /// <summary>
        /// adds cord doddgers to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new CornDodgers());
        }
        /// <summary>
        /// adds pan de campo to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new PanDeCampo());
        }
        /// <summary>
        /// adds cowboy coffee to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new CowboyCoffee());
        }
        /// <summary>
        /// adds jerked soda to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new JerkedSoda());
        }
        /// <summary>
        /// adds texas tea to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new TexasTea());
        }
        /// <summary>
        /// adds water to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new Water());
        }
        /// <summary>
        /// adds rustlers ribs to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new RustlersRibs());
        }
        /// <summary>
        /// adds texas triple burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new TexasTripleBurger());
        }
        /// <summary>
        /// adds trail burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgeButton_Click(object sender, RoutedEventArgs e)
        {
            orderSummaryControl.OrderList.Items.Add(new TrailBurger());
        }
    }
}
