using System;

namespace static_sinif_ve_üyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı:{0}", Calisan.CalisanSayisi);
            Calisan calisan= new Calisan("Tuğba","Yazıcı","It");
            Calisan calisan1= new Calisan("Ahmet","Yılmaz","İos");
            Calisan calisan2= new Calisan("Sümeyye","Turhan","Analiz");
            Console.WriteLine("Çalışan sayısı:{0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu:  {0} ", İslemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu:  {0} ", İslemler.Çıkar(600,200));


            

        }
        
    }   
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string? Isim;
        private string? Soyisim;
        private string? Departman;

        static Calisan()
        {
            calisanSayisi=0;
        }
        
        public Calisan(string? ısim, string? soyisim, string? departman)
        {
            this.Isim= ısim;
            this.Soyisim=soyisim;
            this.Departman= departman;
            calisanSayisi++;
        }
    }
    static class İslemler
    {
        public static long Topla (int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }

        public static long Çıkar (int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}