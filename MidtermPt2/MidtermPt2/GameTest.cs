// Andrew O'Brien
// 28 Oct 2020
// Midterm Exam Part 2

using System;

namespace MidtermPt2
{
    public class GameTest
    {
        // main method begins program execution
        public static void Main(string[] args)
        {
            Game game1 = new Game("1234", "Mario", 2, (decimal)55.95);

            game1.DisplayMessage(); // displays game1 information using DisplayMessage
                                    // changes info for game1 to new information
            Console.WriteLine("\nNew game information \n");
            Console.Write("Game ID: "); // prompt user input game id
            game1.GameID = Console.ReadLine();// new GameID
            Console.Write("Game Description: ");// prompt user input for description
            game1.GameDescritpion = Console.ReadLine();// new GameDescription
            Console.Write("Game Quantity: "); // prompt user input for quantity
            game1.QuantityOfGame = Convert.ToInt32(Console.ReadLine());// new GameQuantity
            Console.Write("Game Price: $");// prompt user input for price
            game1.PricePerGame = Convert.ToDecimal(Console.ReadLine());// new GamePrice
            game1.GameTotalAmount(); // displays the GameTotal for the changed information
        }// end main
    }// end class GameTest
}// end namespace MidtermPt2