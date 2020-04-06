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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// a version of the MVVMDadaBinding assignment
    /// </summary>
    public partial class BillControl : UserControl
    {
        /// <summary>
        /// The DependencyProperty for the DenominationProperty
        /// </summary>
        public static readonly DependencyProperty DenominationProperty = DependencyProperty.Register(
                "Denominations",
                typeof(Bills),
                typeof(BillControl),
                new PropertyMetadata(Bills.One)
            );
        /// <summary>
        /// The Denomination this control displays and modifies
        /// </summary>
        public Bills Denominations
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        public static readonly DependencyProperty QuantityProperty = DependencyProperty.Register(
            "Quantities",
            typeof(int),
            typeof(BillControl),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
        );

        public int Quantities
        {
            get => (int)GetValue(QuantityProperty);
            set => SetValue(QuantityProperty, value);
        }

        public BillControl()
        {
            InitializeComponent();
        }
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantities++;
        }

        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantities--;
        }
    }
}
