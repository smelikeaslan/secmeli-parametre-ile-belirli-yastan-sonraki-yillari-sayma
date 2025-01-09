using System;

namespace YasHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaş farkı (varsayılan 18): " + YasFarki());
            Console.WriteLine("Yaş farkı (25): " + YasFarki(25));
        }

        static int YasFarki(int yas = 18)
        {
            return yas - 18;
            Console.ReadKey();
        }
    }
}