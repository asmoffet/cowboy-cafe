using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        private bool bread = true;
        /// <summary>
        /// if the Pecos Pulled Pork will have bread
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
            }
        }
        private bool pickle = true;
        /// <summary>
        /// if the Pecos Pulled Pork will have a pickle
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
            }
        }
        /// <summary>
        /// how may calories the Pecos Pulled Pork will have
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }
        /// <summary>
        /// the price og the Picos Pulled Pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the Pecos Pulled Pork
        /// </summary>
        public List<string> SpecialInstructions
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
    }
}
