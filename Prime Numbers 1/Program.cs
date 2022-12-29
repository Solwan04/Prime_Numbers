// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
namespace Prime
{
    class console
    {
        static void Main(string[] args)
        {

            Console.WriteLine("first number");
            int firstnumber = int.Parse(Console.ReadLine());


            Console.WriteLine("second number");
            int secondnumber = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = firstnumber; i <= secondnumber; i++)
            {
                for (int start = 1; start <= i; start++)
                {
                    if (i % start == 0) { sum++; }
                }

                if (sum == 2)
                { 
                    Console.WriteLine(i);
                    
                    sum = 0;
                }

                else 
                {
                    sum = 0;
                }
            }
        }
    }
}