using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList sayiDizisi= new ArrayList();
            Console.WriteLine("Lütfen 20 adet sayı giriniz:");
            for (int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayiDizisi.Add(sayi);                
            }

            sayiDizisi.Sort();
            ArrayList küçükS= new ArrayList();
            ArrayList büyükS= new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                küçükS.Add(sayiDizisi[i]);

            }
            for (int i = 17; i < 20; i++)
            {
                büyükS.Add(sayiDizisi[i]);   
            }
            
            Console.WriteLine("En küçük üç sayı:");
            foreach (var item in küçükS)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            
            
            Console.WriteLine("En büyük üç sayı:");
            foreach (var item in büyükS)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
    

            int küçükT=0;
            foreach (var item in küçükS)
            {
                küçükT+=Convert.ToInt32(item);
            }
            int büyükT= 0;
            foreach (var item in büyükS)
            {
                büyükT+= Convert.ToInt32(item);
            }

            Console.WriteLine("Küçük sayıların ortalaması:"+ küçükT/küçükS.Count);
            Console.WriteLine("Büyük sayıların ortalaması:"+ büyükT/büyükS.Count);

            Console.WriteLine("Küçük ve Büyük sayıların ortalamaları toplamı:"+küçükT/küçükS.Count+büyükT/büyükS.Count);



        }
    }
}
