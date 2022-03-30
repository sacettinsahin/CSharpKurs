using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Sacettin";
            int yas = 26;
            string dogumYeri = "Edirne";
            //Normalde bu şekilde değişken veriyorduk,
            //artık değişken tipimiz class ismi oldu

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Kerem";
            kurs1.izlenmeOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Engin";
            kurs2.izlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.izlenmeOrani = 52;

            //Console.WriteLine("Kurs1'in Adı: " + kurs1.KursAdi);
            //Console.WriteLine("Kurs1'in Eğitmeni :" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var x in kurslar)
            {
                Console.WriteLine(x.KursAdi +" "+"Eğitmeni: "+x.Egitmen);
            }

        }
        
        
    }

    class Kurs
    {
        // prop yazıp tap tap (proporty'den geliyor, özellik)
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }

    
}   
