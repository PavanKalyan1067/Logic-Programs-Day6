using System;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int result = Check_prime(number);
            if (result == 0)
            {
                Console.WriteLine("it is not a prime number ");
            }
            else
            {
                Console.WriteLine("it is a prime number");
            }
            Console.ReadLine();


        }
        public static int Check_prime(int number)
        {
            int i;
            for (i = 2; i <= number-1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }

            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }

    }
}
