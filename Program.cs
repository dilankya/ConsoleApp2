using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.isim = "Ali";
            musteri1.soyisim = "Bayraktar";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.isim = "Dilan";
            musteri2.soyisim = "Kaya";

            MusteriManager m1 = new MusteriManager();
            m1.MusteriEkle(musteri1);
            m1.MusteriEkle(musteri2);
            m1.MusteriListele(musteri2);

        }
    }

    class Musteri
    {
        public int Id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }



    }

    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.isim + " " + musteri.soyisim + " Sisteme eklendi..");
            Console.WriteLine("  ");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.isim + " " + musteri.soyisim + " Silindi.. . ");

        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Sistemde  " + musteri.isim + ", " + musteri.soyisim + "adlı müşteri bulunmaktadır.");
        }

    }
}
