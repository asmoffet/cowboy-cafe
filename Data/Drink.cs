/*

* Author: Nathan Bean

* Edited by: Alex Moffet

* Class name: Drink

* Purpose: store and access common prperties for drinks

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        /// <summary>
        /// gets any special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        public virtual Size Size { get; set; }
        
        /// <summary>
        /// gets whether the drink has ice or not
        /// </summary>
        public abstract bool Ice {get; set;}

    }
}
