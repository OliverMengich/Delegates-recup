using System;
using System.Threading;

namespace DelegatesRecup
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void confDel();
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Std1());
            
        }

        private static MyDelegate Std1()
        {
            Console.WriteLine("Method from a delegate");
            Thread.Sleep(10000);
            return Std1();
        }
    }
    class Std1
    {
        public Std1()
        {
            Console.WriteLine("Constructor");
        }
    }
    class Std2
    {

    }
}
