﻿namespace DongulerNew1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"yazılım kamp","programlama başlangıç", "java" };
            
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);  
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");        
        }
    }
}
