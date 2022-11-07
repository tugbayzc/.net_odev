using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle girin:");
            string? cümle = Console.ReadLine();
            Console.WriteLine(cümle.ToLower());
            
            string ünlüler ="aeıiuüoö";
            
            int cümleUzunluğu= cümle.Count();

            List<char> ünlüListe = new List<char>();
            for (int i = 0; i < cümleUzunluğu; i++)
            {
                if(ünlüler.Contains(cümle[i]))
                {
                    if (!ünlüListe.Contains(cümle[i]))
                    {
                        ünlüListe.Add(cümle[i]);
                    } 
                }
                else
                    continue; 
            }
            Console.Write("Cümledeki ünlü harfler:");    
            foreach (var item in ünlüListe)
            {
                Console.Write(item+",");
            }        
        }
    }
}
