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
                int n = lst[0], k = lst[1];
                var pairs = ReadLine().Split().Select(int.Parse).ToList();
                var frq = new Dictionary<int, int>();
                int cnt = 0;
                foreach (var it in pairs)
                {
                    var key = it ^ k;
                    if (frq.ContainsKey(key))
                        cnt += frq[key];

                    if (frq.ContainsKey(it))
                        frq[it]++;
                    else
                        frq[it] = 1;
                }
                WriteLine(cnt);
            }
            return 0;
        }
    }
}
/*


*/
