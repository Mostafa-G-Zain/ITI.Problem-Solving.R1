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
            /*CF*/
            int TC = 1;
            TC = int.Parse(ReadLine());
            Dictionary<string, int> dict = new();
            while (TC-- > 0)
            {
                //var lst = ReadLine().Split().Select(int.Parse).ToList();
                var input = ReadLine().Split(' ').ToList();
                int type = int.Parse(input[0]);
                string key = input[1];
                if (type == 1)
                {
                    int val = int.Parse(input[2]);
                    dict[key] = val;
                }
                else if (type == 2)
                {
                    bool flg = dict.TryGetValue(key, out int res);
                    WriteLine(flg ? res : "NOT FOUND");
                }
                else if (type == 3)
                {
                    if (dict.ContainsKey(key))
                        dict.Remove(key);
                }
            }
            long sum = 0;
            foreach (var it in dict) sum += it.Value;
            WriteLine(sum);
            return 0;
        }
    }
}

