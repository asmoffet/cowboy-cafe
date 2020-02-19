/*

* Author: Alex Moffet

* Class name: RustlersRibs

* Purpose: store and access prperties for Rustlers Ribs

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs: Entree
    {
        /// <summary>
        /// returns the price of th Rustler's Ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// returns the calories for the Rustler' Ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the Rustler's Ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Rustler's Ribs"</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
