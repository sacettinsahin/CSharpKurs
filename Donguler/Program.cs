using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hazır yapıları hızlıca çağırmak için örneğin for yazdık, tab tab yapınca taslak gelir!!!!

            string kurs1 = "Yazılım geliştirme temel kursu";
            string kurs2 = "Programlamaya başlama temel kursu";
            string kurs3 = "Java Kursu";

            string[] kurslar = new string[] { "Yazılım geliştirme temel kursu" ,
            "Programlamaya başlama temel kursu","Java Kursu","Python","C#"};


            for (int i = 0; i < (kurslar.Length); i++)    
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("--------------------------------------------");

            //daha kolay olması için genelde foreach kullanılır ama ikisini de bil.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



        }
    }
}
