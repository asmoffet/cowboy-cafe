/*

* Author: Alex Moffet

* Class name: BakedBeans

* Purpose: store and access prperties for Baked Beans

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class BakedBeans: Side, INotifyPropertyChanged
    {
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// allows the override for the calories in baked beans dependant on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
 

                        return 410;
                    case Size.Medium:


                        return 378;
                    case Size.Small:


                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }
        /// <summary>
        /// allows for the override of price for baked beans dependant on size
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
        /// <returns>The String "Rustler's Ribs"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Baked Beans";
           
        }
    }
}
