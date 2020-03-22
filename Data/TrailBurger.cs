﻿/*
* Author: Cole Willenbring
* Class: Trail Burger
* Purpose: Holds the class logic for the Trail Burger entree
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trail Burger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        private bool bun = true;
        /// <summary>
        /// If the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                PropertyChangedHelper("Bun");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the burger is topped with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                PropertyChangedHelper("Ketchup");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the burger is topped with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                PropertyChangedHelper("Mustard");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the burger is topped with a pickle
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

        private bool cheese = true;
        /// <summary>
        /// If the burger is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                PropertyChangedHelper("Cheese");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }

        /// <summary>
        /// Override the ToString() method for POS use
        /// </summary>
        /// <returns>The string name of the Trail Burger entree.</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
