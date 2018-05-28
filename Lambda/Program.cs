using System;

namespace Lambda
{
    class Program
    {
        delegate int del(int i);
        static void Main(string[] args)
        {
            del myDelegate = x => x * x;
            Console.WriteLine(myDelegate(5));
        }
    }
}
