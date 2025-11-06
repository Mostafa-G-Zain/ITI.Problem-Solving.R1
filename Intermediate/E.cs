/**
 *  Author: ZainJr.
 *  Created: 2025-11-04 11:01:10
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
            //var input = ReadLine()?.Split(" ")?.ToArray();
            //WriteLine(Solution.LongestCommonPrefix(input));

            /*CF*/
            int TC = 1;
            TC = int.Parse(ReadLine());
            int cnt = 1;
            var pq = new PriorityQueue<int, (int, int)>();
            var executed = new List<int>();
            while (TC-- > 0)
            {
                var lst = ReadLine().Split().Select(int.Parse).ToList();
                if (lst[0] == 1)
                {
                    int priority = lst[1];
                    pq.Enqueue(priority, (-priority, cnt));
                    cnt++;
                }
                else
                {
                    if (pq.TryDequeue(out _, out var executedIdx))
                        executed.Add(executedIdx.Item2);
                }
            }
            foreach (var it in executed)
                WriteLine(it);
            return 0;
        }
    }
}
