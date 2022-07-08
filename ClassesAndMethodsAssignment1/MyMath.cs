using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndMethodsAssignment1
{
    public class MyMath
    {
        public int AddTen(int num)
        {
            return num + 10;
        }

        public int AddTen(decimal num)
        {
            return (int)(num + 10);
        }

        public int AddTen(string str)
        {
            return Convert.ToInt32(str) + 10;
        }
    }
}
