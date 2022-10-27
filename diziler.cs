using System;

namespace diziler 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};
            int[] dizi;
            dizi = new int[5];
            
            //dizilere değer atama
            renkler[0]= "mavi";
            dizi[3]=10;
            
            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);

            //döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu = Convert.ToInt16(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz:", i+1);
                sayıDizisi[i]= Convert.ToInt16(Console.ReadLine());
            }
            
            int toplam =0;
            foreach (var sayi in sayıDizisi)
            {
                toplam+=sayi;
                
                Console.WriteLine("Ortalama:" + toplam/diziUzunlugu);
            } 







        }
    }
}