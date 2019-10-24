using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console001_SquareWithStars
{
    
//  “Let the first act of every morning be to make the following resolve for the day:
//      - I shall not fear anyone on Earth.
//      - I shall fear only God.
//      - I shall not bear ill will toward anyone.
//      - I shall not submit to injustice from anyone.
//      - I shall conquer untruth by truth. And in resisting untruth, I shall put up with all suffering.”
//          ― Mahatma Gandhi
    class Program
    {
        static void Main(string[] args)
        {
            // Draw a square of stars according to user input
            Console.WriteLine("----------------------------------------");
            
            Console.Write("Enter side lenfgt of the square  : ");
            int lengthSide = Convert.ToInt32(Console.ReadLine());// get the user input

            Console.WriteLine();
            Console.WriteLine("Here comes the full square!!!");
            for (int i = 0; i < lengthSide; i++) // outer for loop is for the Columns
            {
                for (int j = 0; j < lengthSide; j++) // inner for loop is for the lines 
                {
                    Console.Write("*" + " "); // as it draws each star next to each other + s space for good visibility
                }
                Console.WriteLine(); // print the next line 
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            // now let's draw an empty square...
            Console.WriteLine();
            Console.WriteLine("Here comes the empty square!!!");
            for (int i = 0; i < lengthSide; i++) 
            {
                    Console.Write("*" + " "); // draw the top side of the square
            }
            Console.WriteLine();

            for (int i = 0; i < lengthSide-2; i++)
            {
                Console.Write("*" + " "); // leftmost star in the second,third,,,, line
                for (int j = 0; j < lengthSide-2; j++)
                {
                    Console.Write(" " + " ");// space character in the line
                }
                Console.Write("*" + " "); // the rightmost star in the same line..
                Console.WriteLine();// goto the beginnig of the next line
            }

            for (int i = 0; i < lengthSide; i++)
            {
                Console.Write("*" + " "); // draw the bottom side of the square
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.ReadLine();
        }
    }
}
