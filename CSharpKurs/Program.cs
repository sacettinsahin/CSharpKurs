using System;

namespace CSharpKurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety: tip güvenliği
            string kategoriEtiketleri = "Kategori"; // verileri tutarken string, int ve double kullanılır.
          
            int ogrenciSayisi = 35;

            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if(dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış oku");
            }
            else if(dolarBugun==dolarDun)
            {
                Console.WriteLine("Sabit oku");
            }
            else
            {
                Console.WriteLine("Azalış oku");
            }








            if(sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Hoşgeldiniz.");
            }
            else
            {
                Console.WriteLine("Lütfen Giriş Yapın");
            }




            


        }
    }
}
