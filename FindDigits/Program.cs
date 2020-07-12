using System;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1012;
            
            int count = 0, digits = 0;
            int temp = n;
            do
            {
                digits = n % 10;
                n = n / 10;
                if (digits != 0 && temp % digits == 0)
                {
                    count++;
                }
            } while (n != 0);
            Console.WriteLine(count);
        }
    }
}
