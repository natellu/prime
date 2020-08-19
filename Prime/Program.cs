using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {        
            for(int x = 1; x<= 100; x++)
            {
                bool isPrime = true;
                for (int y = 2; y < (x / 2) + 1; y++)
                {
                    if(x%y == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
