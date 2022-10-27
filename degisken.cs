
using System;
 using System.ComponentModel;

 namespace degisken
 {
     class Program
 	{
         public static void Main(string[] args)
         {



             //Değişken Tanımlama 
             byte a = 1;
             Console.WriteLine(a);
             sbyte b = 2;
             Console.WriteLine(b);
             short c = 13;
             Console.WriteLine(c);
             ushort d = 7;
             Console.WriteLine(d);
             int i = 18;
             Console.WriteLine(i);
             long l = 9;
             Console.WriteLine(l);

             float f = 58;
             Console.WriteLine(f);
             double e = 2.5;
             Console.WriteLine(e);
             decimal de=3;
             Console.WriteLine(de);

             // String
             string name2 = "Mahsuni";
             Console.WriteLine(name2);
             char ch ='a';
             Console.WriteLine(ch);

             bool b1 = true;
             Console.WriteLine(b1);
             bool b2 = false;
             Console.WriteLine(b2);

             //Datetime-Tarih ve saat
             DateTime dateTime = DateTime.Now;
             Console.WriteLine("Bu Günün Tarihi: "+dateTime);

             // Object
             object o1 = "Mahsuni";
             Console.WriteLine(o1);
             object o2 = 'M';
             Console.WriteLine(o2);
             object o3 = 4;
             Console.WriteLine(o3);
             object o4 = 4.6;
             Console.WriteLine(o4);

             // String
             string str = string.Empty;
             str = "Mahsuni Güler";
             string ad = "Mahsuni";
             string soyad = "Güler";
             string tamisim = ad + " " + soyad;
             Console.WriteLine(tamisim);

             //integer 
             int integer1 = 2;
             int integer2 = 4;
             // toplama
             Console.WriteLine(integer1 + integer2);
             // çıkarma
             Console.WriteLine(integer1 - integer2);
             // çarpma
             Console.WriteLine(integer1 * integer2);
             // bölme
             Console.WriteLine(integer1 / integer2);

             // boolean
             bool bool1= 10 < 5;
             Console.WriteLine(bool1);

             // Değişken dönüşümleri
             string number1 = "12";
             int number2 = 34;
             string yenideger = number1+ number2.ToString();
             Console.WriteLine("string->new number= " + yenideger);

             int int21 = Convert.ToInt32(number1) + number2;
             Console.WriteLine("int->new number= "+int21);

             //Datetime
             string datetime = DateTime.Now.ToString("dd.MM.yyyy");
             Console.WriteLine("Date: "+datetime);

             //Hour
             string hour = DateTime.Now.ToString("HH/mm");
             Console.WriteLine("Hour: "+hour);

             Console.ReadLine();

         }
     }
 }
