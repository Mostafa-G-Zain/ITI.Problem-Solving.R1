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
            int TC = 1;
            TC = int.Parse(ReadLine());
            while (TC-- > 0)
            {
                var lst = ReadLine().Split().Select(int.Parse).ToList();
                int n = lst[0], q = lst[1];

                var arr = ReadLine().Split().Select(int.Parse).ToList();
                var pfx = new List<long>();
                pfx.Add(0);
                for (int i = 1; i <= arr.Count; i++)
                    pfx.Add(arr[i - 1]);

                for (int i = 1; i < pfx.Count; i++)
                    pfx[i] = pfx[i] + pfx[i - 1];

                for (int i = 0; i < q; i++)
                {
                    var query = ReadLine().Split().Select(int.Parse).ToList();
                    int L = query[0], R = query[1], k = query[2];
                    long fillers = (long)(R - L + 1) * (long)k;
                    long sub = pfx[R] - pfx[L - 1];
                    if (((pfx[pfx.Count - 1] - sub + fillers) & 1L) == 1L)
                        WriteLine("YES");
                    else
                        WriteLine("NO");
                }
            }
            return 0;
        }
    }
}
