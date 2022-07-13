using System;

namespace PassByRefrence
{
    class Program
    {
        static void SwapStrings(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
            Console.WriteLine("Inside the method: {0} {1}", s1, s2);
        }
        static void Main(string[] args)
        {
            string str1 = "John";
            string str2 = "Smith";
            Console.WriteLine("Inside main,before swapping: {0} {1}", str1, str2);

            SwapStrings(ref str1, ref str2);
            Console.WriteLine("Inside the Main, after swapping:{0} {1}", str1, str2);
        }
    }
}
