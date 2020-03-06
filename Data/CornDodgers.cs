/*

* Author: Alex Moffet

* Class name: CornDodgers

* Purpose: store and access prperties for Corn Dodgers

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class CornDodgers: Side, INotifyPropertyChanged
    {
        public override event PropertyChangedEventHandler PropertyChanged;
        public override uint Calories
        {
            /// <summary>
            /// allows the override for the calories in Corn Dodgers dependant on size
            /// </summary>
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }
        /// <summary>
        /// allows the override for the price in Corn DOdgers dependant on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        
                        return 1.99;
                    case Size.Medium:
                        
                        return 1.79;
                    case Size.Small:
                       
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Corn Dodgers"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Corn Dodgers";

        }
    }
}
