namespace Classİntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 68;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "PYTHON";
            kurs1.Egitmen = "MEMET";
            kurs1.izlenmeOranı = 68;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "DEMİR";
            kurs2.izlenmeOranı = 68;
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "JAVA";
            kurs3.Egitmen = "ENGİN";
            kurs3.izlenmeOranı = 68;

            //Console.WriteLine(kurs1.KursAdi + " : "+ kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1 , kurs2 , kurs3 };
           


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOranı { get; set; }
    }
}
