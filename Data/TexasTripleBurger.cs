﻿/*
* Author: Cole Willenbring
* Class: Texas Triple Burger
* Purpose: Holds the class logic for the Texas Triple Burger entree
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple entree
    /// </summary>
    public class TexasTripleBurger : Entree
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

        private bool tomato = true;
        /// <summary>
        /// If the burger is topped with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                PropertyChangedHelper("Tomato");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the burger is topped with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                PropertyChangedHelper("Lettuce");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger is topped with mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                PropertyChangedHelper("Mayo");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool bacon = true;
        /// <summary>
        /// If the burger is topped with bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                PropertyChangedHelper("Bacon");
                PropertyChangedHelper("SpecialInstructions");
            }
        }

        private bool egg = true;
        /// <summary>
        /// If the burger is topped with egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChangedHelper("Egg");
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
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
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
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Override the ToString() method for POS use
        /// </summary>
        /// <returns>The string name of the texas triple burger entree.</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
