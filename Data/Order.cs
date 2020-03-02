using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static uint lastOrderNumber;
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

        public IEnumerable<IOrderItem> Items => items.ToArray();

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<double> Prices => prices.ToArray();

        private List<double> prices = new List<double>();

        

        public void Add(IOrderItem Item) 
        {
            items.Add(Item);
            prices.Add(Item.Price);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem Item) 
        {
            items.Remove(Item);
            prices.Add(Item.Price);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }



    }
}
