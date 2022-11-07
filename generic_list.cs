using System;
using System.Collections.Generic;

namespace genetic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //list<T> class
            //System.Collections.Generic
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");

            //count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ve  List.ForEach ile elemanlara erişim
            foreach(var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("yeşil");
            
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //liste içerisinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 bulundu");     
            
            //eleman ile indexe erişme

            Console.WriteLine(renkListesi.BinarySearch("sarı"));

            //diziyi listeye çevirme
            string[] hayvanlar={"kedi","köpek","kuş"};
            List<string> hayvanListesi= new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<kullanıcılar> kullanıcılarListesi = new List<kullanıcılar>();
            
            kullanıcılar kullanıcı1=new kullanıcılar();
            kullanıcı1.Isim = "Tuğba";
            kullanıcı1.Soyisim = "Yazıcı";
            kullanıcı1.Yas= 26;

            kullanıcılar kullanıcı2=new kullanıcılar();
            kullanıcı2.Isim = "Zeyneb";
            kullanıcı2.Soyisim = "Türkmen";
            kullanıcı2.Yas= 26;

            kullanıcılarListesi.Add(kullanıcı1);
            kullanıcılarListesi.Add(kullanıcı2);

            List<kullanıcılar> yeniListe= new List<kullanıcılar>();
            yeniListe.Add(new kullanıcılar()
            {
                Isim="İrem",
                Soyisim="Özer",
                Yas=26
            });
                
            foreach (var kullanıcı in kullanıcılarListesi)
            {
                Console.WriteLine("Kullanıcı Adı:"+ kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Adı:"+ kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Adı:"+ kullanıcı.Yas); 
            }
            yeniListe.Clear();
        }
    }
    public class kullanıcılar
    {
        private string ? isim;
        private string ? soyisim;
        private int yas;

        public string ? Isim { get => isim ;set => isim = value;}
        public string ? Soyisim {get=> soyisim; set=> soyisim = value;}
        public int Yas{get => yas; set=>yas = value;}
    }
}