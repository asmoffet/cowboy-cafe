/*

* Author: Alex Moffet

* Class name: PanDeCampo

* Purpose: store and access prperties for Pan de Campo

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class PanDeCampo: Side, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns the calories for Pand de Campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }
        /// <summary>
        /// returns the price for Pand de Campo
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.99;
                    case Size.Medium:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.79;
                    case Size.Small:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Pan De Campo"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Pan de Campo";
        }
    }
}
