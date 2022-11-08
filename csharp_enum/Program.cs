using System;

namespace csharp_enum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
            int sıcaklık=32;
            if(sıcaklık<=(int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            else if (sıcaklık>=(int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
            }
            else if (sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.Coksıcak )
            {
                Console.WriteLine("Hadi dışarı çıkalım");
            }
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sıcak=25,
        Coksıcak=30
    }
}