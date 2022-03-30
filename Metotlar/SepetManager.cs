using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        // Metod ve class isimleri büyük harfle başlar!!!!
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi: "+ urun.Adi);
        }  
        public void Ekle2(string urunAdi, string urunAciklamasi, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi: " + urunAdi);
        }
    }
}
