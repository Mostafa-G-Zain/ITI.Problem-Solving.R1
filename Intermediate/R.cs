/**
 *  Author: ZainJr.
 *  Created: 2025-11-17
 **/
global using static System.Console;
using System.Collections;
using System.Collections.Specialized;
using System.Numerics;

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
                var n = int.Parse(ReadLine());
                var lst = ReadLine().Split().Select(int.Parse).ToList();

                uint activatedBits = 0;
                foreach (var it in lst)
                {
                    uint curr = (uint)it;
                    uint newSets = curr & (~activatedBits);
                    Write(BitOperations.PopCount(newSets) + " ");
                    activatedBits |= curr;
                }
            }
            return 0;
        }
    }
}
/*


*/
