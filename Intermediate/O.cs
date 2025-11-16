/**
 *  Author: ZainJr.
 *  Created: 2025-11-16
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
                var lst = ReadLine().Split().Select(long.Parse).ToList();
                long n = lst[0], L = lst[1], R = lst[2];
                while (L <= R)
                {
                    long idx = L;
                    n ^= (1L << (int)idx);
                    L++;
                }
                WriteLine(n);
            }
            return 0;
        }
    }
}
/*
1010
0101

 */
