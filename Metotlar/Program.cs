using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.ID = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklamasi = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.ID = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklamasi = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var i in urunler)
            {
                Console.WriteLine(i.Adi);
                Console.WriteLine(i.Fiyati);
                Console.WriteLine(i.Aciklamasi);
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("--------Metodlar----------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("-----------------------------");
            //encapsulation !!!

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 8);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15, 5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 20, 15);
        }
    }
}
