using System;

namespace kurucu_metotlar
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

            Console.WriteLine("*******Çalışan 1*******");
            Calisan calisan1 = new Calisan("Ayşe","Kara",19875678,"backend");
            calisan1.CalısanBilgileri();
            
            Console.WriteLine("*******Çalışan 2*******");
            Calisan calisan2= new Calisan("Berfunur","Eren",34567890,"test");
            calisan2.CalısanBilgileri();
            
            Console.WriteLine("*******Çalışan 3*******");
            Calisan calisan3 = new Calisan("Ayşe","Kara");
            calisan3.CalısanBilgileri();


        }     
    }
    class Calisan
    {
        public string? Ad;
        public string? Soyad;
        public int? No;
        public string? Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad= ad;
            this.Soyad= soyad;
            this.No= no;
            this.Departman=departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad= ad;
            this.Soyad= soyad;
        }
        public Calisan(){}

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan Numarası:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);

        }
    }

    
}
