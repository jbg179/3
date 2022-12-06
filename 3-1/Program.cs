using System;
class AssignmentSt
{
    public static void Main(string[] args)
    {
        short s; int i;
        float f; double d;
        s = 526;
        d = f = i = s; // 맨 우측에서 좌로 할당 반복
        Console.WriteLine("s = " + s + " i = " + i);
        Console.WriteLine("f = " + f + " d = " + d);
    }
}
