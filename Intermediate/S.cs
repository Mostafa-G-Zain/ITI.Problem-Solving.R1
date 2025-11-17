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
                var lst = ReadLine().Split().Select(int.Parse).ToList();
                int n = lst[0];
                WriteLine(fib(n));
            }
            return 0;
        }
        public static int fib(int n)
        {
            if (n <= 1)
                return 1;
            return fib(n - 2) + fib(n - 1);
        }

    }
}
/*


*/
