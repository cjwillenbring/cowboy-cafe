﻿/*
* Author: Cole Willenbring
* Class: Angry Chicken
* Purpose: Holds the class logic for the Angry Chicken entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken Sandwich entree
    /// </summary>
    public class AngryChicken : Entree
    { 
        private bool bread = true;
        /// <summary>
        /// If the pulled pork is accompanied with bread (sandwich)
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
                PropertyChangedHelper("Bread");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool pickle = true;

        /// <summary>
        /// If the sandwich comes with a pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChangedHelper("Pickle");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        /// <summary>
        /// The price of the sandwich
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the sandwich
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Override the ToString() method for POS use
        /// </summary>
        /// <returns>The string name of the angry chicken entree.</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
