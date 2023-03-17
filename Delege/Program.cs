using System;

namespace Delege
{
    delegate void BenimDelegem(int sayi1, int sayi2);
    class Program
    {
        static void Main(string[] args)
        {
            BenimDelegem benimDelegem = new BenimDelegem(Topla);
            benimDelegem += Carp;
            benimDelegem.Invoke(1,2);
            Console.WriteLine("Hello World!");
        }
        static void Topla(int numara1,int numara2)
        {
            Console.WriteLine(numara1 + numara2);
        }
        static void Carp(int numara1, int numara2)
        {
            Console.WriteLine(numara1 * numara2);
        }
    }
}
