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
            string s = ReadLine();
            int n = input[0], k = input[1];
            int ans = -1;
            int[] cnt = new int[2];
            for (int i = 0, ptr = 0; i < n; i++)
            {
                cnt[0] += (s[i] == 'a') ? 1 : 0;
                cnt[1] += (s[i] == 'b') ? 1 : 0;

                if (int.Min(cnt[0], cnt[1]) > k)
                {
                    cnt[0] -= (s[ptr] == 'a') ? 1 : 0;
                    cnt[1] -= (s[ptr] == 'b') ? 1 : 0;
                    ptr++;
                }
                else
                    ans = int.Max(ans, cnt[0] + cnt[1]);

            }
            WriteLine(ans);
            return 0;
        }
    }
}
/*

n = 9, k = 1
aabaabaaa
aabaabaa | aabaaa
ans = 6

 */
