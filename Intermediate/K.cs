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
                var lst = ReadLine().Split().Select(int.Parse).ToList();
                int n = lst[0], q = lst[1];
                var A = ReadLine().Split().Select(int.Parse).ToList();
                A.Sort();
                for (int i = 0; i < q; i++)
                    WriteLine((A.BinarySearch(int.Parse(ReadLine())) >= 0) ? "found" : "not found");
            }
            return 0;
        }
    }
}
/*


*/
