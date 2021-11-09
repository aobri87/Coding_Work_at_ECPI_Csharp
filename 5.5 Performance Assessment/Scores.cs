// Name: Andrew O'Brien
// Date: 16 June 2021
// 5.5 Performance Assessment: Array Manipulations

using System;

namespace _5._5_Performance_Assessment
{
    class Scores
    {
        static void Main(string[] args)
        {
            // initializer list specifies the value for each element
            int[] bestScores = { 80, 85, 90, 95, 60 };

            Console.WriteLine("{0}{1,8}", "Index", "Value"); // headings

            // output each array element's value
            for (int counter = 0; counter < bestScores.Length; ++counter)
                Console.WriteLine("{0,5}{1,8}", counter, bestScores[counter]);
        } // end Main
    } // end class Scores
} // end namespace
