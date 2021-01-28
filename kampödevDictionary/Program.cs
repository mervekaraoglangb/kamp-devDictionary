using System;
using System.Collections.Generic;

namespace kampödevDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> kullanicilar = new MyDictonary<int, string>();

            kullanicilar.Add(0, "Merve KARAOĞLAN");
            kullanicilar.Add(1, "Emrullah ORHAN");
            kullanicilar.Add(2, "Emine BOZOĞLAN");

            
        }
    }
}
