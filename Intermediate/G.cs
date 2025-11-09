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
            var input = ReadLine().Split().Select(int.Parse).ToList();
            int n = input[0], m = input[1], q = input[2];
            long[] arr = new long[200000 + 5];
            long l, r, x;
            for (int i = 0; i < m; i++)
            {
                var updates = ReadLine().Split().Select(int.Parse).ToList();
                l = updates[0]; r = updates[1]; x = updates[2];
                arr[l] += x;
                arr[r + 1] -= x;
            }
            for (int i = 1; i < arr.Length; i++) arr[i] = arr[i] + arr[i - 1];
            for (int i = 0; i < q; i++)
            {
                int idx = int.Parse(ReadLine());
                WriteLine(arr[idx]);
            }
            return 0;
        }
    }
}
