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
                var n = lst[0];
                char[] buffer = new char[n];
                burn(0, n, buffer);
            }
            return 0;
        }
        public static void burn(int idx, int n, char[] buffer)
        {
            if (idx == n)
            {
                WriteLine(new string(buffer));
                return;
            }
            foreach (var it in "PSU")
            {
                buffer[idx] = it;
                burn(idx + 1, n, buffer);
            }
        }

    }
}
/*


*/
