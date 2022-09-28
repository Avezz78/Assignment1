using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            Console.WriteLine("Prime numbers between 1 and 100 are: ");
           
            for (int i = 1; i < 100; i++)
            {
                temp = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            temp = 1;
                            break;
                        }
                    }
                    if (temp == 0)
                    {
                        Console.Write(i + "  ");
                    }
                }
            }
        }
    }
}
            
        
    

