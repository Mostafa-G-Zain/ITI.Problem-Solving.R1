/**
 *  Author: ZainJr.
 *  Created: 2025-11-12 1:30:10
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
            var input = ReadLine().Split().Select(int.Parse).ToList();
            int n = input[0], t = input[1];
            var lst = ReadLine().Split().Select(int.Parse).ToList();

            var prefix = new List<int>();
            prefix.Add(0);
            for (int i = 1; i <= n; i++)
                prefix.Add(prefix[i - 1] + lst[i - 1]);

            int R = 1, len = prefix.Count;
            int ans = 0;
            for (int i = 0; i < len; i++)
            {
                while (R < len && prefix[R] - prefix[i] <= t) R++;
                ans = int.Max(ans, R - i - 1);
            }
            WriteLine(ans);
            return 0;
        }
    }
}
/*
4 5
2 1 1 1
 */
