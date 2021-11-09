// Andrew O'Brien
// 28 Oct 2020
// Midterm Exam Part 2

using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermPt2
{
    public class Game
    {
        private int quantityOfGame;
        private decimal pricePerGame;
        // auto implemented GameID, GameDescription, QuantityOfGame, and PricePerGame
        public string GameID { get; set; }
        public string GameDescritpion { get; set; }
        public int QuantityOfGame
        {
            get{return quantityOfGame;}
            // if statment to prevent negative numbers
            set{if (value >= 0)
                { quantityOfGame = value; }
            } // end set
        } // end QuantityOfGame
        public decimal PricePerGame
        {
            get{return pricePerGame;}
            // if statment to prevent negative numbers
            set{if (value >= 0)
                { pricePerGame = value; }
            }// end set
        }// end PricePerGame

        // initializes constructor
        public Game(string id, string description, int quantity, decimal price)
        {
            GameID = id;
            GameDescritpion = description;
            QuantityOfGame = quantity;
            PricePerGame = price;

        } // end constructor

        public void GameTotalAmount()
        {
            decimal total = QuantityOfGame * PricePerGame;
            Console.WriteLine("Game Total Amount: ${0}\n", total);// total amount of purchaced games
        } // end GameTotalAmount

        // Display recipt message
        public void DisplayMessage()
        {
            // use auto implemented properties for message information
            Console.WriteLine("Original game information\n");
            Console.WriteLine("Game ID: {0} ", GameID); // id of game
            Console.WriteLine("Game Description: {0} ", GameDescritpion);// string of description of name
            Console.WriteLine("Game Quantitity: {0}", QuantityOfGame);// number of games
            Console.WriteLine("Game Price: ${0}", PricePerGame);// price per a game
            GameTotalAmount(); // displays the GameTotalAmount method
        }// end DisplayMessage
    }// end class Game
} // end namespace MidtermPt2
