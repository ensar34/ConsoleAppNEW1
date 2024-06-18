namespace ConsoleAppNEW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string kategoriEtiketi = "Kategori";
          int öğrenciSayisi = 32000;
          double faizOrani = 1.45;
          bool sistemeGirisYapmısMi = true;
          double dolarBugun = 7.45;
          double dolarDun = 7.35;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu"); 
            }
            else
            {
                Console.WriteLine("değişim butonu");
            }


            if (sistemeGirisYapmısMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");    
            }





            Console.WriteLine(kategoriEtiketi);
           
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
