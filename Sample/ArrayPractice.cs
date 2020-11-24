using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Array
    {
        public string[] s = { "Anusha", "Cherukuri" };
        public int[] i = { 1, 23, 36, 41 };
        public char[] c = { 'a', 'b', 'c' };
        public float[] f = { 1.2f, 4.568f, 6.78f };
        public double[] d = { 12345, 7864, 9887 };
        public Boolean[] b = { true, false, true };
    }
    static void Main(string[] args)
    {
        Array a = new Array();
        Console.WriteLine("The second value of string array is:" + a.s{ 2});
    }
}
