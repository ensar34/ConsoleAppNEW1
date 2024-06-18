namespace Product1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.UrunAdı = "Telefon";
            urun1.UrunFıyat = 800;
            urun1.UrunAdet = 50;

            Urun urun2 = new Urun();
            urun2.UrunAdı = "Buz dolabı";
            urun2.UrunFıyat = 300;
            urun2.UrunAdet = 20;

            Urun urun3 = new Urun();
            urun3.UrunAdı = "Süpürge";
            urun3.UrunFıyat = 250;
            urun3.UrunAdet = 5;

            Urun[] Urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var DATA in Urunler)
            {
                Console.WriteLine(DATA.UrunAdı + " " + DATA.UrunFıyat + " " + DATA.UrunAdet);
            }

            for (int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine(Urunler[i].UrunFıyat);
                Console.WriteLine(Urunler[i].UrunFıyat);
                Console.WriteLine(Urunler[i].UrunAdet);
            }
            
            }

        }
    }
}              

  class Urun
{
    public string UrunAdı { get; set; }
    public int UrunFıyat { get; set; }
    public int UrunAdet { get; set; }


}