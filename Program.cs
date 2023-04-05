using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi", "kopek", "kus", "maymun"};
            
            int[] dizi;
            dizi = new int[5];

            //dizilere deger atama ve erisim
            renkler[0] = "mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //donguler ile dizi kullanimi
            //klavyeden girilen n tane sayının ortalamasini hesaplayan program
            Console.Write("lutfen dizinin eleman sayisini giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("lutfen {0}. sayiyi giriniz", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam= 0;
            foreach (var sayi in diziUzunlugu)
                toplam += sayi;

            Console.WriteLine("Ortalama:" + toplam/diziUzunlugu);
        }
    }
}