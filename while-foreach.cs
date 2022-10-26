namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //birden başlayarak konsolda yazılan sayıya kadar(sayı dahil) ortalama hesaplayıp konsola yazdıran program.
            Console.WriteLine("lütfen bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            int toplam =0;
            while (sayac<=sayi)
            {
            toplam+= sayac;
            sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            //a'dan z'ye kadar tüm harfleri konsola yazdıralım.
            char character = 'a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }

            //foreach
            
            string[] arabalar = {"BMV","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}