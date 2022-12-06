using System;
class AnotherBlock
{
    public static void Main(string[] args)
    {
        int x = 1;
        {
            // int x; // error ( 블록 밖의 변수와 겹침)
            int y = 2;
            Console.WriteLine("Block 1: x = " + x + ", y = " + y);
        }
        {
            int y = 3;
            Console.WriteLine("Block 2: x = " + x + ", y = " + y);
        }
    }
}
