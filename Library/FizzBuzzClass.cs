using System;

namespace Library
{
    public class FizzBuzzClass
    {
        public int number;

        public void fizzBuzz()
        {
            System.Console.WriteLine("Please enter a number");
            number = Int32.Parse(Console.ReadLine());

            if (number % 3 == 0 || number % 5 == 0)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                if (number % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else
                {
                    System.Console.WriteLine("Buzz");
                }

            }
            else
            {
                System.Console.WriteLine("That number is not divisible by 3 or 5");
            }
        }
    }
}