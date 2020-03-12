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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
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
            var ordercontrol = this.FindAncestor<OrderControl>();
            AngryChicken tempChicken = new AngryChicken();
            if (DataContext is Order data)
            {
                data.Add(tempChicken);
                var screen = new angryChickenCustomization();
                screen.DataContext = tempChicken;
                ordercontrol.SwapScreen(screen);
            }

        }
        /// <summary>
        /// adds pecos pulled pork to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            PecosPulledPork tempPork = new PecosPulledPork();
            if (DataContext is Order data)
            {
                data.Add(tempPork);
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = tempPork;
                ordercontrol.SwapScreen(screen);
            }
        }
        /// <summary>
        /// adds cowpoke chilli to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChilliButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            CowpokeChili tempChili = new CowpokeChili();
            if (DataContext is Order data)
            {
                data.Add(tempChili);
                var screen = new CowpokechiliCustomization();
                screen.DataContext = tempChili;
                ordercontrol.SwapScreen(screen);
            }
        }
        /// <summary>
        /// adds dakota double burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBugrerButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            DakotaDoubleBurger tempDouble = new DakotaDoubleBurger();
            if (DataContext is Order data)
            {
                data.Add(tempDouble);
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = tempDouble;
                ordercontrol.SwapScreen(screen);
            }
        }
        /// <summary>
        /// adds baked beans to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }
        /// <summary>
        /// adds chili cheese fries to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChilliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }
        /// <summary>
        /// adds cord doddgers to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }
        /// <summary>
        /// adds pan de campo to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }
        /// <summary>
        /// adds cowboy coffee to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            CowboyCoffee tempCoffee = new CowboyCoffee();
            if (DataContext is Order data)
            {
                data.Add(tempCoffee);
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = tempCoffee;
                ordercontrol.SwapScreen(screen);
            }
        }
        /// <summary>
        /// adds jerked soda to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            JerkedSoda tempSoda = new JerkedSoda();
            if (DataContext is Order data)
            {
                data.Add(tempSoda);
                var screen = new JerkedSodaCustomization();
                screen.DataContext = tempSoda;
                ordercontrol.SwapScreen(screen);
            }
        }
        /// <summary>
        /// adds texas tea to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            TexasTea tempTea = new TexasTea();
            if (DataContext is Order data)
            {
                data.Add(tempTea);
                var screen = new TexasTeaCustomization();
                screen.DataContext = tempTea;
                ordercontrol.SwapScreen(screen);
            }
        }
        /// <summary>
        /// adds water to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            Water tempWater = new Water();
            if (DataContext is Order data)
            {
                data.Add(tempWater);
                var screen = new WaterCustomization();
                screen.DataContext = tempWater;
                ordercontrol.SwapScreen(screen);
            }
        }
        /// <summary>
        /// adds rustlers ribs to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }
        /// <summary>
        /// adds texas triple burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            TexasTripleBurger tempTriple = new TexasTripleBurger();
            if (DataContext is Order data)
            {
                data.Add(tempTriple);
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = tempTriple;
                ordercontrol.SwapScreen(screen);
            }
        }
        /// <summary>
        /// adds trail burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgeButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            TrailBurger tempTrail = new TrailBurger();
            if (DataContext is Order data)
            {
                data.Add(tempTrail);
                var screen = new TrailBurgerCustomization();
                screen.DataContext = tempTrail;
                ordercontrol.SwapScreen(screen);
            }
        }
    }
}
