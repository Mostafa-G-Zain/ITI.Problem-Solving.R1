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
                string brackets = ReadLine();
                Stack<char> stk = new();
                bool flg = true;
                foreach (char c in brackets)
                {
                    if (c == '(' || c == '[' || c == '{')
                        stk.Push(c);
                    else if (c == ')' || c == ']' || c == '}')
                    {
                        if (stk.Count == 0 || !IsMatch(stk.Pop(), c))
                        {
                            flg = false;
                            break;
                        }
                    }
                }
                if (flg && stk.Count == 0)
                    WriteLine("YES");
                else
                    WriteLine("NO");
            }
            return 0;
        }
        public static bool IsMatch(char open, char close)
        {
            return (open == '(' && close == ')') || (open == '[' && close == ']') || (open == '{' && close == '}');
        }
    }
}

