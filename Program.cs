using System;

namespace HarmonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value of N ");
            double N = Convert.ToDouble(Console.ReadLine());

            HarmonicNumber.HarmonicNum(N);
        }
    }
}
