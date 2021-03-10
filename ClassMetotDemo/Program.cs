using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Türkan";
            musteri1.Soyad = "xxxxxx";
            musteri1.Yas = 21;
            musteri1.KartNo = 3333333;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Sevdenur";
            musteri2.Soyad = "yyyyyy";
            musteri2.Yas = 20;
            musteri2.KartNo = 588888;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Birsen";
            musteri3.Soyad = "zzzzzzz";
            musteri3.Yas = 20;
            musteri3.KartNo = 80000;

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Kübra";
            musteri4.Soyad = "ffffff";
            musteri4.Yas = 19;
            musteri4.KartNo = 277777;

            Musteri musteri5 = new Musteri();
            musteri5.Ad = "Delal";
            musteri5.Soyad = "wwwwww";
            musteri5.Yas = 20;
            musteri5.KartNo = 4777777;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri6 = new Musteri();
            musteri6.Ad = "Gökhan";
            musteri6.Soyad = "kkkkkk";
            musteri6.Yas = 19;
            musteri6.KartNo = 777777;





            Console.WriteLine("EKLEME İŞLEMİNİN YAPILDIĞI YER");
            musteriManager.Add(musteri6);

            Console.WriteLine("LİSTELEME İŞLEMİNİN YAPILDIĞI YER");
            musteriManager.List(musteriler);

            Console.WriteLine("SİLME İŞLEMİNİN YAPILDIĞI YER");
            musteriManager.Delete(musteri4);
        }

        //Bir bankada müşteri takibi yapmak istiyorsunuz.
        //Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
        //MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.

    }
}
