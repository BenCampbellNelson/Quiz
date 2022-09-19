using System;
using System.Threading;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int score = 0;

            do
            {
                Console.WriteLine("Welcome to this true or false quiz");
                Thread.Sleep(2000);

                //Question 1
                Console.WriteLine("Albert Einstein failed most of his subjects except for math and physics?");
                temp = Console.ReadLine();
                temp = temp.ToUpper();

                if (temp == "T")
                {
                    Console.WriteLine("Correct");
                    Console.ReadLine();
                    score++;

                }
                else
                {
                    Console.WriteLine("incorrect");
                    Console.ReadLine();
                }

                //Question 2
                Console.WriteLine("The first ever song sung in space was Happy Birthday?");
                temp = Console.ReadLine();
                temp = temp.ToUpper();

                if (temp == "T")
                {
                    Console.WriteLine("Correct");
                    Console.ReadLine();
                    score++;

                }
                else
                {
                    Console.WriteLine("incorrect");
                    Console.ReadLine();
                }

                //question 3













                Console.WriteLine("Would you like to give the quiz another go? Y/N");
                temp = Console.ReadLine();
                temp = temp.ToUpper();

            } while (temp == "Y");

        }
    }
}
