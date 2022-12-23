using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here is the program explanation

            Console.WriteLine("Welcome to the Prime Number Printer!");
            Console.WriteLine("This program prints the prime numbers between a given range.");
            Console.WriteLine("Please enter the starting and ending numbers of the range of prime numbers you want to get.");
            Console.WriteLine("===========================================================================================");

            //Here receive values from the user

            int n1, n2;
            Console.Write("Enter the starting number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("Error: The starting number cannot be greater than the ending number.");
                return;
            }


            Console.WriteLine("These are the prime numbers between " + n1 + " and " + n2 + " : ");


            //Nested loop

            for (int i = n1; i <= n2; i++)
            {
                int isPrime = 1;
                for (int j = 2; j <= i / j; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                }

                if (isPrime == 1)
                {
                    Console.Write(i + " | ");
                }
            } 
        }
    }
}

