/**
 *  Author: ZainJr.
 *  Created: 2025-11-09 02:30:10
 **/
global using static System.Console;

namespace MyDraft
{
    class Program
    {
        public static int Main()
        {
#if DEBUG
            SetIn(new StreamReader("#input.txt"));
            SetOut(new StreamWriter("#output.txt") { AutoFlush = true });
#endif
            /*LC*/
            //var input = ReadLine().Split().Select(int.Parse).ToArray();
            //WriteLine(Solution.MySqrt(input[0]));

            /*CF*/
            int n = int.Parse(ReadLine());
            var A = ReadLine().Split().Select(int.Parse).ToList();
            var B = ReadLine().Split().Select(int.Parse).ToList();

            int[] prefix = new int[A.Count];
            int[] suffix = new int[B.Count];

            prefix[0] = A[0];
            for (int i = 1; i < n; i++)
                prefix[i] = GCD(prefix[i - 1], A[i]);

            suffix[n - 1] = A[n - 1];
            for (int i = n - 2; i >= 0; --i)
                suffix[i] = GCD(suffix[i + 1], A[i]);

            int max = suffix[0];
            for (int i = 0; i < n; i++)
            {
                int gcd, res;
                if (n == 1)
                    gcd = 0;
                else if (i == 0)
                    gcd = suffix[i + 1];
                else if (i == n - 1)
                    gcd = prefix[n - 1];
                else
                    gcd = GCD(prefix[i - 1], suffix[i + 1]);

                res = GCD(gcd, B[i]);
                max = int.Max(max, res);
            }
            WriteLine(max);
            return 0;
        }
        public static int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }
    }
}
