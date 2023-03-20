using System;
using System.Collections.Generic;

namespace PredicateDelagate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = new Predicate<string>(DegeriBul);
            var gelenData = predicate.Invoke("Furkan");
            List<string> isimler = new(){"Yavuz","Mehmet","Ahmet","Ayşe","Furkan","Veli" };
            //var bulunanisim =  isimler.Find(predicate);
            var bulunanisim = isimler.Find(a => a == "Furkan");
            Console.WriteLine(bulunanisim);
        }

        private static bool DegeriBul(string obj)
        {
            return obj == "Furkan";
        }
    }
}
