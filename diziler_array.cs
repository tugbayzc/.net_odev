using System;

namespace diziler_array // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi ={23,12,4,86,72,3,11,17};
            Console.WriteLine("**sırasız dizi**");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("**sıralanmış dizi**");
            Array.Sort(sayiDizisi);
            
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //clear
            Console.WriteLine("**bu array clear**");
            //sayiDizisi elemanlarını kullanarak ikinci indeksten başlayarak iki tane elemanı sıfırlar.
            Array.Clear(sayiDizisi,2,2);
            
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //reverse(tersine çevirme)

            Console.WriteLine("**reverseişlemi");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //indexOf
            Console.WriteLine("**arrayindexof**");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            
            //resize(yeniden boyutlandırma)
            Console.WriteLine("**arrayresize**");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}
