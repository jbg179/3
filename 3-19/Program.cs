using System;
using System.Diagnostics.Metrics;

class OverflowApp
{
    public static void Main()
    {
        int i, max = int.MaxValue; // 정수 최대값 지정 (overflow 생성 용도)
        try
        {
            Console.WriteLine("Start of try statement");
            i = max + 1; // default: don’t check Overflow.
            Console.WriteLine("After default overflow");
            unchecked
            {
                i = max + 1; // don’t check Overflow intentionally.
            }
            Console.WriteLine("After unchecked statement");
            checked
            {
                i = max + 1; // check Overflow
            }
            Console.WriteLine("After checked statement");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("caught an OverflowException");
            }
        }
}
