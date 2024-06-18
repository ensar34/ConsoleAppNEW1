using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
      //naming convetion
    public void Ekle(Urun urun)
    {
            Console.WriteLine("Sepete eklendi" + " : " + urun.Adi);  
    }



     public void Ekle2(string urunAdi , String aciklama ,double fiyat, int stokAdedi)
     {
            Console.WriteLine("Tebrikler sepete eklediniz : " + urunAdi  );
           
        
     }


    }
}
