using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müsteri adi:" + musteri.Ad);
            Console.WriteLine("Müsteri soyadi:" + musteri.Soyad);
            Console.WriteLine("Yasi:" + musteri.Yas);
            Console.WriteLine("KartNo:" + musteri.KartNo);
            Console.WriteLine("........................");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müsteri adi:" + musteri.Ad);
            Console.WriteLine("Müsteri soyadi:" + musteri.Soyad);
            Console.WriteLine("Yasi:" + musteri.Yas);
            Console.WriteLine("KartNo:" + musteri.KartNo);
            Console.WriteLine(".........................");
        }
        public void List(Musteri[] musteriler)

        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müsteri adi:" + musteri.Ad);
                Console.WriteLine("Müsteri soyadi:" + musteri.Soyad);
                Console.WriteLine("Yasi:" + musteri.Yas);
                Console.WriteLine("KartNo:" + musteri.KartNo);
                Console.WriteLine("........................");


            }

        }

    }
}
