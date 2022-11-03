using System;

namespace odev_1 // Note: actual namespace depends on the project name.
{
    class Program
    {

        static void  Main(string[] args)
        {
            odev1();
            odev2();
            odev3();
            odev4();            
        }

        static void odev1()
        {
            Console.WriteLine("Pozitif bir sayı giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayi kadar pozitif sayı giriniz:");
            
            int[] dizi = new int[sayi];
            for (int i = 0; i < sayi; i++)
            {   
                dizi[i]= Convert.ToInt32(Console.ReadLine());                       
            }

            Console.WriteLine("Girdiğiniz çift sayılar:");
            foreach (var item in dizi)
            {
                if(item%2==0)
                {
                    Console.Write(" "+item+",");
                }                
            }                     
        }

        static void odev2()
        {
            Console.WriteLine("Lütfen pozitif iki sayı(n,m) giriniz:");
            int n=Convert.ToInt32(Console.ReadLine());
            int m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz ilk sayı(n) kadar sayı giriniz:");
            int[] dizi= new int[n];
            for (int i = 0; i < n; i++)
            {
                dizi[i]= Convert.ToInt32(Console.ReadLine());
            }
            
            foreach (var number in dizi)
            {
                if(number%m==0)
                {
                    Console.Write(" "+number+",");
                }
            }



        }
        static void odev3()
        {
            Console.WriteLine("Lütfen pozitif bir sayı(n) giriniz:");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayı(n) kadar kelime giriniz:");
            string[] kelimeler= new string[n];
            for (int i = 1; i < n+1; i++)
            {
                Console.Write($"kelime {i}: ");
                kelimeler[i-1]=Console.ReadLine();
            }
            
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);               
            }
            
        }
        static void  odev4()
        {
            string? cümle;
            Console.WriteLine("Lütfen bir cümle giriniz:");
            cümle=Console.ReadLine();
            char[] karakter=cümle.ToCharArray();
            string[] kelimeler=cümle.Split(" ");
            Console.WriteLine("karakter sayısı:"+ karakter.Length);
            Console.WriteLine("kelime sayısı:"+ kelimeler.Length);
        }
    }
}