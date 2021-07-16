using System;

namespace LoopTasks
{
    public static class LoopTasks
    {
        public static int SumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                if (n % 2 != 0)
                {
                    sum += n % 10;
                    n -= n % 10;
                    n /= 10;
                }
                else
                {
                    n -= n % 10;
                    n /= 10;
                }
            }
            return sum;
        }

        public static int NumberOfUnitsInBinaryRecord(int n)
        {
            int sum = 0;
            string bin_n = Convert.ToString(n, 2);
            for (int i = 0; i < bin_n.Length; i++)
            {
                if (bin_n[i] == '1')
                {
                    ++sum;
                }
                else continue;
            }
            return sum;
        }

        public static int SumOfFirstNFibonacciNumbers(int n)
        {
            if (n <= 1)
                return 0;
            int Fn = 0, F1 = 0;
            int F2 = 1;
            int sum = F1 + F2;
            int Fa = F1;
            int Fb = F2;
            for (int i = 0; i < n - 2; i++)
            {
                Fn = Fa + Fb;
                sum += Fn;
                Fa = Fb;
                Fb = Fn;
            }
            return sum;
        }
    }
}