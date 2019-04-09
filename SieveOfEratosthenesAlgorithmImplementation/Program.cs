using System;
using static System.Net.Mime.MediaTypeNames;

namespace SieveOfEratosthenesAlgorithmImplementation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Beep();
           
            Console.ForegroundColor = ConsoleColor.Green;

          
                Console.WindowHeight = 30;
                Console.WindowWidth = 122;
                Console.Title = "Prime Number Finder";
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("=================================== S i e v e   O f   E r a t o s t h e n e s ==========================================");
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("");

                bool isInteger = false;
                int limit;
            do
            {
                do
                {
                    Console.Write("Please Enter The Upper Bound Limit :  ");
                    string input = Console.ReadLine();
                    Console.Beep();
                    
                    isInteger = int.TryParse(input, out limit);

                    if (!isInteger)
                    {
                        Console.WriteLine("Please Enter An Integer Value For Limit");
                    }
                }

                while (!isInteger);
                Console.WriteLine("");

                Console.WriteLine("...Processing");

                Console.WriteLine("");

                FindPrime(limit);
                Console.Beep();
                Console.WriteLine();

                Console.WriteLine();

                Console.WriteLine("Press E to Exit");
                Console.WriteLine("Press Any Digit To Try Another Limit");

                string promptInput =  Console.ReadLine();
                Console.Beep();

                if (string.Equals(promptInput, "e", StringComparison.InvariantCultureIgnoreCase))
                {
                    Environment.Exit(0);
                }
                Console.WriteLine();

            }
            while (true);

        }

        public static void FindPrime(int limit)
        {
            bool[] isPrimeBooleanArray = new bool[limit + 1];
            for (int i = 0; i < limit; i++)
            {
                if (i == 0 || i == 1)
                {
                    isPrimeBooleanArray[i] = false;

                }
                else
                {
                    isPrimeBooleanArray[i] = true;

                }
            }

            for (int i = 2; i <= limit; ++i)
            {

                if (isPrimeBooleanArray[i])
                {
                    for (int j = i + 1; j <= limit; ++j)
                    {
                        if (isPrimeBooleanArray[j])
                        {
                            int remainder = j % i;
                            if (remainder == 0)
                                isPrimeBooleanArray[j] = false;
                        }
                    }
                }

            }

            Console.WriteLine("Prime Numbers Are");
            for (int i = 0; i < isPrimeBooleanArray.Length; i++)
            {
                if (isPrimeBooleanArray[i])
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}
