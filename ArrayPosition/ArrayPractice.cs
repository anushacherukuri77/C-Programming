using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArrayPractice
    {
        public string[] s = { "Anusha", "Cherukuri" };
        public int[] i = { 1, 23, 36, 41 };
        public char[] c = { 'a', 'b', 'c' };
        public float[] f = { 1.2f, 4.568f, 6.78f };
        public double[] d = { 12345, 7864, 9887 };
        public Boolean[] b = { true, false, true };

        static void Main(string[] args)
        {
            ArrayPractice a = new ArrayPractice();

            Console.WriteLine("The second value of string array is:" + a.s[1]);
            Console.WriteLine("The third value of integer array is:" + a.i[2]);
            Console.WriteLine("The first value of char array is:" + a.c[0]);
            Console.WriteLine("The third value of float array is:" + a.f[2]);
            Console.WriteLine("The second value of double array is:" + a.d[1]);
            Console.WriteLine("The second value of boolean array is:" + a.b[1]);
            Console.WriteLine("The second value of boolean array is:" + a.b[1]);


        }
    }
}
