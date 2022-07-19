using System;

namespace ClassesAndMehtodsAssignments3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();

            math.DoAdd(5, 10);
            math.DoAdd(num2: 5, num1: 10);
        }
    }
}
