using System;
class SimpleIOApp
{
    public static void Main()
    {
        int i; char c;
        Console.Write("Enter a digit and a character = ");
        i = Console.Read() - 48; // ‘0’ =48
        c = (char)Console.Read();
        Console.Write("i = " + i);
        Console.WriteLine(", c = " + c);
    }
}
