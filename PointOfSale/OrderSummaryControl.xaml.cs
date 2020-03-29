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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IOrderItem lbi = ((sender as ListBox).SelectedItem as IOrderItem);
            var ordercontrol = this.FindAncestor<OrderControl>();
            if(lbi is AngryChicken)
            { 
                var screen = new angryChickenCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
            if (lbi is CowboyCoffee)
            {
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
            if (lbi is CowpokeChili)
            {
                var screen = new CowpokechiliCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
            if (lbi is DakotaDoubleBurger)
            {
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
            if (lbi is JerkedSoda)
            {
                var screen = new JerkedSodaCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
            if (lbi is PecosPulledPork)
            {
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
            if (lbi is TexasTea)
            {
                var screen = new TexasTeaCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
            if (lbi is TexasTripleBurger)
            {
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
            if (lbi is TrailBurger)
            {
                var screen = new TrailBurgerCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
            if (lbi is Water)
            {
                var screen = new WaterCustomization();
                screen.DataContext = lbi;
                ordercontrol.SwapScreen(screen);
            }
        }
        public void DeleteItemClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    order.Remove((IOrderItem)button.DataContext);
                }
            }
        }
    }
}
