using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            isimler.Add("Ilker");
            Console.WriteLine(isimler[4]);
        }
    }
}
