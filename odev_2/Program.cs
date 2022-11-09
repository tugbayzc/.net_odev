using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace koleksiyonlar_soru_1
{
    class Program
    {
        public static void Main(string[] args)
        { 
            
            ArrayList sayiDizisi = new ArrayList();
            int kontrol = 0;
            while(kontrol<20)
            {
                Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz:");
                var sayi =Console.ReadLine();
                // Negatif ve numeric olmayan girişleri engelleyin.
                try
                {
                    if(Convert.ToInt32(sayi)<0)
                    {
                        Console.WriteLine("lütfen pozitif bir sayı girin!");
                    }
                    else
                    {
                        sayiDizisi.Add(sayi);
                        kontrol++;
                    }
            
                }
                catch(Exception)
                {
                    Console.WriteLine("Lütfen sadece pozitif sayı girin!");
                }
            }
            
            ArrayList asalSayi= new ArrayList();
            ArrayList asalOlmayanSayi= new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                if(IsPrime(Convert.ToInt32(sayiDizisi[i])))
                {
                    asalSayi.Add(sayiDizisi[i]);
                }    
                else
                {
                    asalOlmayanSayi.Add(sayiDizisi[i]);
                }   
            }
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            asalSayi.Sort();
            asalSayi.Reverse();
            Console.WriteLine("Asal sayı dizisi elemanları: ");
            foreach (var item in asalSayi)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            
            asalOlmayanSayi.Sort();
            asalOlmayanSayi.Reverse();
            
            Console.WriteLine("Asal olmayan sayı dizisinin elemanları:  ");
            foreach (var item in asalOlmayanSayi)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            Console.WriteLine("Asal olan sayı dizisi eleman sayısı:"+Convert.ToInt32(asalSayi.Count));
            
            Console.WriteLine("Asal olmayan sayı dizisi eleman sayısı:"+Convert.ToInt32(asalOlmayanSayi.Count));
            
            int asalToplam=0;
            foreach (var item in asalSayi)
            {
                asalToplam+=Convert.ToInt32(item);                
            }
            

            Console.WriteLine("Asal sayıların ortalaması:"+ asalToplam/asalSayi.Count);
            
            int asalOlmayanToplam=0;
            foreach (var item in asalOlmayanSayi)
            {
                asalOlmayanToplam+=Convert.ToInt32(item);
            }
           
            Console.WriteLine("Asal olmayan sayıların ortalaması:" + asalOlmayanToplam/asalOlmayanSayi.Count);


        
        }
        public static bool IsPrime(int sayi)
        {
            for (int i = 2; i < sayi; i++)
            {
                if(sayi%i==0)
                {
                    return false;
                }               
            }
            return true;
        }
    }
}
