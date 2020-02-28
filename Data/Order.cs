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
                double temp = 0;
                foreach(IOrderItem Item in items)
                {
                    temp += Item.Price;
                }
                return temp;
            }
        }

        public IEnumerable<IOrderItem> Items => items.ToArray();

        private List<IOrderItem> items = new List<IOrderItem>();

        

        public void Add(IOrderItem Item) 
        {
            items.Add(Item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        public void Remove(IOrderItem Item) 
        {
            items.Remove(Item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }



    }
}
