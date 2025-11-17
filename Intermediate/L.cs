/**
 *  Author: ZainJr.
 *  Created: 2025-11-17
 **/
global using static System.Console;
using System.Text;

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
            TC = int.Parse(ReadLine());
            while (TC-- > 0)
            {
                var input = ReadLine().Split().Select(int.Parse).ToList();
                int n = input[0], q = input[1];
                var lst = ReadLine().Split().Select(long.Parse).ToList();

                lst.Sort((x, y) => (x.CompareTo(y) != 0) ? y.CompareTo(x) : x.CompareTo(y));

                for (int i = 1; i < n; i++) lst[i] += lst[i - 1];

                for (int i = 0; i < q; i++)
                {
                    int x = int.Parse(ReadLine());
                    int target = lst.BinarySearch(x);
                    int properPosition = (~target);
                    if (target >= 0)
                        WriteLine(target + 1);
                    else
                    {
                        if (properPosition < lst.Count)
                            WriteLine(properPosition + 1);
                        else
                            WriteLine(-1);
                    }
                }

            }
            return 0;
        }
    }
}
/*


*/
