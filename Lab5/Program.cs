using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Factorials! \nEveryone loves factorials! Give me a number between 1 and 20, and I will calculate the factorial of that number. \nInput anything not an integer and I will close the program :) \n");
            
            // while loop so the program keeps repeating
            while (true)
            {
                Console.WriteLine("What's your number?");

                // attempt to parse input as an int
                try
                {

                    // store input as an int named "yourNum"
                    int yourNum = int.Parse(Console.ReadLine());

                    // send yourNum through the Factorial method for an answer, then spit it to the console
                    Console.WriteLine("{0}! = {1}", yourNum, Factorial(yourNum));
                    Console.WriteLine();
                }
                catch
                {
                    // if parsing fails we break the loop and end the program, as specified in the intro
                    break;
                }
            }
        }

        // calculate factorial of yourNum using recursion
        static long Factorial(int yourNum)
        {
            // when yourNum reaches 1 we stop recursion
            if (yourNum == 1)
            {
                return 1;
            }
            // use recursion to multiply yourNum by the next number down
            return yourNum * Factorial(yourNum - 1);
        }

        // calculate factorial of yourNum using a for loop (not used in the main method but it still works)
        static long FactorialForLoop(int yourNum)
        {
            long loudNum = 1;
            for (int i = 1; i <= yourNum; i++)
            {
                // multiply loudNum by i until i surpasses yourNum
                loudNum = loudNum * i;
            }
            return loudNum;
        }
    }
}
