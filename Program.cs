using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim="Yılmaz";
            ogrenci.OgrenciNo=293;
            ogrenci.Sinif=3;
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1= new Ogrenci("Deniz","Arda",234,1);
            ogrenci1.SinifDüsür();
            ogrenci1.SinifDüsür();
            ogrenci1.OgrenciBilgileriniGetir();
            
        }

    }
    class Ogrenci
    {
        private string? isim;
        private string? soyisim;
        private int ogrenciNo;
        private int sinif;

        
        public string? Isim { get => isim; set => isim = value; }
        public string? Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set
            {
                if(value< 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif=1;
                }
                else
                {
                    sinif = value;
                }
            }  
        }

        public Ogrenci(string? isim, string? soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("****öğrenci bilgileri****");
            Console.WriteLine("Öğrenci Adı      :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı   :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No       :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı   :{0}",this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif= this.Sinif +1;
        }

        public void SinifDüsür() 
        {
            this.Sinif= this.Sinif -1;
        }
        
    }
}
