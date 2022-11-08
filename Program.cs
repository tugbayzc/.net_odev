using System;

namespace sınıf_savramı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz dizimi
            //class sınıf adı
            //{
            //      [erişim berlirleyici] [veri tipi] ÖzellikAdı
            //      [erişim belirleyici] [geri dönüş tipi] MetotAdi(parametre listesi)
            //      {
            //      //metot komutları
            //      }
            //}

            //Erişim belirleyiciler
            //*public
            //*private
            //*internal
            //*protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad="Tuğba";
            calisan1.Soyad="Yazıcı";
            calisan1.No="19875678";
            calisan1.Departman="papara/backend";

            calisan1.CalısanBilgileri();
            Console.WriteLine("**************");

            Calisan calisan2= new Calisan();
            calisan2.Ad="Berfunur";
            calisan2.Soyad="Eren";
            calisan2.No="34567890";
            calisan2.Departman="test";

            calisan2.CalısanBilgileri();


        }     
    }
    class Calisan
    {
        public string? Ad;
        public string? Soyad;
        public string? No;
        public string? Departman;

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan Numarası:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);

        }
    }

    
}