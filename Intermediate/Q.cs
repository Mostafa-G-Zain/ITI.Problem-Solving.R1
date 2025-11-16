/**
 *  Author: ZainJr.
 *  Created: 2025-11-16
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
                var lst = ReadLine().Split().Select(ulong.Parse).ToList();
                ulong n = lst[0];
                WriteLine(BitOperations.PopCount(n));
            }
            return 0;
        }
    }
}
/*


*/
