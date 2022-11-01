using System;

namespace metotlar_overloading // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi ="999";
           
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("başarılı!");
                Console.WriteLine(outSayi);
            }
            else 
            {
                Console.WriteLine("başarısız!");
            }
            
            metotlar instance = new metotlar();
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //metot aşırı yükleme

            int ifade = 999;
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Tuğba ","Yazıcı");

            //Metto Imzasi
            //metotAdı + parametre sayisi + parametre
        }
    }
    class metotlar
    {
        public void Topla(int a,int b,out int toplam)
        {
            toplam=a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

    }
}