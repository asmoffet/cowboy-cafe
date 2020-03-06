/*

* Author: Nathan Bean

* Edited by: Alex Moffet

* Class name: Side

* Purpose: store and access common prperties for sides

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// returns an empty string
        /// </summary>
        public virtual List<string> SpecialInstructions { get; }
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }
    }
}
