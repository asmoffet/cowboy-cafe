using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// and event handler for when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// a uint to store the last order number
        /// </summary>
        private static uint lastOrderNumber;
        /// <summary>
        /// calculates and gets a randomly generated order number
        /// </summary>
        public uint OrderNumber { 
            get
            {
                Random random = new Random();
                int number = random.Next(99) + 1;
                while (number == lastOrderNumber)
                {
                    number = random.Next(99);
                }
                lastOrderNumber = (uint)number;
                return (uint)number;
            }
        }
        /// <summary>
        /// calculates the subtotal of the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach(IOrderItem order in items)
                {
                    total += order.Price;
                }
                return total;
            }

        }
        /// <summary>
        /// sends the list of items to an array
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();
        /// <summary>
        /// stores a list of user inputed items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// sends the list of prices to an array
        /// </summary>
        public IEnumerable<double> Prices => prices.ToArray();
        /// <summary>
        /// stores the prices of the users order
        /// </summary>
        private List<double> prices = new List<double>();

        
        /// <summary>
        /// adds an item to the order
        /// </summary>
        /// <param name="Item">the item you want to add</param>
        public void Add(IOrderItem Item) 
        {
            items.Add(Item);
            prices.Add(Item.Price);
            if (Item is INotifyPropertyChanged)
            {
                Item.PropertyChanged += onItemChanged;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
        /// <summary>
        /// removes an item from the order
        /// </summary>
        /// <param name="Item"></param>
        public void Remove(IOrderItem Item) 
        {
            items.Remove(Item);
            prices.Remove(Item.Price);
            if (Item is INotifyPropertyChanged)
            {
                Item.PropertyChanged -= onItemChanged;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void onItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Prices")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }



    }
}
