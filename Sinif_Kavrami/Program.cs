using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad = "Halil";
            calisan1.soyad = "Özcan";
            calisan1.no = 200905050;
            calisan1.departman = "Yazılım";

            calisan1.CalisanBilgileri();


            Calisan calisan2 = new Calisan();

            calisan2.ad = "Hakan";
            calisan2.soyad = "Söylemez";
            calisan2.no = 200905055;
            calisan2.departman = "Yönetici";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string ad;
        public string soyad;

        public int no;
        public string departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine("Calışanın Adi: {0}" , ad);
            Console.WriteLine("Calışanın SoyAdi: {0}" , soyad);
            Console.WriteLine("Calışanın No: {0}" , no);
            Console.WriteLine("Calışanın Departmanı: {0}" , departman);
        }
    }
}