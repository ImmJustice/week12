using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace week12classLib
{
    public class Class1
    {
        public static long FindPrimeNumberSync(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;

                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }

        public async static Task<long> FindPrime(int n)
        {
            var task = await Task.Run(() => Class1.FindPrimeNumberSync(n));
            return task;
        }

        /*
        int count = 0>
        long a = 2;
        
        while (count < n)
        {
            long b = 2;
            int prime = 1;// to check if found a
            
        while (b * b <= a)
            {
                if (a % b == 0)
                {
                    prime = 0;
                    break;
                }
                b++;
            }
            if (prime > 0)
            {
                count++;
            }
            a++;
        }
        return (--a);
        */
    }
}
