/**
 *  Author: ZainJr.
 *  Created: 2025-11-17
 **/
global using static System.Console;
using System.Numerics;

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
                long n = lst[0], k = lst[1];
                WriteLine(((n & (1L << (int)k)) != 0) ? "YES" : "NO");  //Mask
                //WriteLine(((n >> (int)k) & 1) == 1 ? "YES" : "NO");       //isolate the bit
            }
            return 0;
        }
    }
}
/*


*/
