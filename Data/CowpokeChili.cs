﻿/*
* Author: Nathan Bean
* Edited By: Cole Willenbring
* Class: Cowpoke Chili
* Purpose: Holds the class logic for the Cowpoke Chili entree
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili : Entree
    { 
        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese
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

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set
            {
                sourCream = value;
                PropertyChangedHelper("SourCream");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set
            {
                greenOnions = value;
                PropertyChangedHelper("GreenOnions");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set
            {
                tortillaStrips = value;
                PropertyChangedHelper("TortillaStrips");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /// <summary>
        /// Override the ToString() method for POS use
        /// </summary>
        /// <returns>The string name of the Cowpoke Chili entree.</returns>
        public override string ToString()
        {
            return "Cowpoke Chili";
        }
    }
}

