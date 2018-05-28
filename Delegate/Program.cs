using System;

namespace Delegate
{
    class Program
    {
        delegate int myDelegate(int nb1, int nb2);

        static void Main(string[] args)
        {
            //myDelegate d = new myDelegate(method);
            myDelegate d = method;
            Console.WriteLine(d(5,2));
        }

        static private int method(int v1, int v2) {
            return v1 + v2;
        }
    }
}
