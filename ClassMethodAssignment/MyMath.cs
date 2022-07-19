using System;

namespace ClassMethodAssignment
{
    public class MyMath
    {
        public void DivideByTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine("The number divided by two is " + result);
        }

        public void DivideByThree(int num, out int result)
        {
            result = num / 3;
        }
    }

}