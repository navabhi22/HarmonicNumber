using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber
{
    public class HarmonicNumber
    {
        public static void HarmonicNum(double N)
        {
            double HarmonicSum = 0;
            if (N > 0)
            {
                for (double i = 1; i <= N; i++)
                {
                    HarmonicSum = HarmonicSum + 1 / i;
                    
                }

                Console.WriteLine("the Nth harmonic value is " +HarmonicSum);

            }
            else
            {
                Console.WriteLine(" N should be greter than 0 ");
            }
        }
    }
}
