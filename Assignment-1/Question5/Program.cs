using System;
namespace Interface {
    interface ITestemployee1
    {
        void Add();

    }
    interface ITestemployee2 : ITestemployee1
    {
        void Sub(int c, int d);
        void Add();
    }
    class Implementationclass : ITestemployee2
    {
        public void Add()
        {
            Console.WriteLine($"A and B values are ");
        }
        public void Sub(int c, int d)
        {
            Console.WriteLine($"A and B values are {c} {d}");
        }
        public void Add()
        {
            Console.WriteLine($"A and B values are");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Implementationclass obj = new Implementationclass();
            obj.Add();
            obj.Sub(74, 38);
            
            ((ITestemployee2)obj).Add();

        }

    }

}