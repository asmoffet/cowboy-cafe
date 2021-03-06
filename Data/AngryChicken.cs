﻿/*

* Author: Alex Moffet

* Class name: AngryChicken

* Purpose: store and access prperties for Angry Chicken

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class AngryChicken: Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool bread = true;
        /// <summary>
        /// If the chicken has bread with it
        /// </summary>
        public bool Bread
        {
            get
            {
                return bread;
            }
            set
            {
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool pickle = true;
        /// <summary>
        /// If the chicken will come with a pickle
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// the calories of the chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }
        /// <summary>
        /// the price of the chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the Angry Chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!pickle)
                    instructions.Add("hold pickle");
                if (!bread)
                    instructions.Add("hold bread");

                return instructions;
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Angry Chicken"</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
