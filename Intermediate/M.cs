/**
 *  Author: ZainJr.
 *  Created: 2025-11-17
 **/
global using static System.Console;

namespace MyDraft
{
    class Program
    {
        public static Int32 Main()
        {
#if DEBUG
            SetIn(new StreamReader("#input.txt"));
            SetOut(new StreamWriter("#output.txt") { AutoFlush = true });
#endif 

            /*CF*/
            int TC = 1;
            //TC = int.Parse(ReadLine());
            while (TC-- > 0)
            {
                var input = ReadLine().Split().Select(int.Parse).ToList();
                int n = input[0], s = input[1];
                var lst = ReadLine().Split().Select(int.Parse).ToList();
                int L = 0, R = n, ans = 0;
                long totalCost = 0;
                while (L <= R)
                {
                    int mid_k = (L + R) >> 1;
                    long currentCost = 0;

                    if (valid(mid_k, n, s, lst, ref currentCost))
                    {
                        ans = mid_k;
                        totalCost = currentCost;
                        L = mid_k + 1;
                    }
                    else
                        R = mid_k - 1;
                }
                WriteLine($"{ans} {totalCost}");
            }
            return 0;
        }
        public static bool valid(int k, int n, int s, List<int> a, ref long costForK)
        {
            if (k == 0)
            {
                costForK = 0;
                return true;
            }
            var b = new List<long>();
            for (int i = 0; i < n; i++)
                b.Add(a[i] + (long)(i + 1) * k);

            b.Sort();

            long currentCost = 0;
            for (int i = 0; i < k; i++)
            {
                currentCost += b[i];
                if (currentCost > s)
                    return false;
            }

            costForK = currentCost;
            return true;
        }

    }
}
/*


*/
