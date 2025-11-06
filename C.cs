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
            while (TC-- > 0)
            {
                //var lst = ReadLine().Split().Select(int.Parse).ToList();
                int n = int.Parse(ReadLine());
                var words = ReadLine().Split(' ').ToList();
                var wordSet = words.Select(s => s.ToLower()).ToHashSet();
                WriteLine(wordSet.Count);
                foreach (var it in words)
                {
                    if (wordSet.Contains(it.ToLower()))
                    {
                        Write($"{it} ");
                        wordSet.Remove(it.ToLower());
                    }
                }
                WriteLine();
            }
            return 0;
        }
    }
}

