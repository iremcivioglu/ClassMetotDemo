using System;


namespace ClassMetotDemo
{
	class Program()
	{
		static void Main (string[] args)
        {
			MusteriManager musteriManager = new MusteriManager();

			Musteri musteri1 = new Musteri();
			musteri1.MusteriId = 1;
			musteri1.MusteriAdi = "İremnur";
			musteri1.MusteriSoyadi = "Çivioğlu";
			musteri1.MusteriYasi = 23;

			Musteri musteri2 = new Musteri();
			musteri2.MusteriId = 2;
			musteri2.MusteriAdi = "Mehmet";
			musteri2.MusteriSoyadi = "Yılmaz";
			musteri2.MusteriYasi = 33;

			Musteri musteri3 = new Musteri();
			musteri3.MusteriId = 3;
			musteri3.MusteriAdi = "Aslı";
			musteri3.MusteriSoyadi = "Korkmaz";
			musteri3.MusteriYasi = 52;

			musteriManager.Ekleme(musteri1);
			musteriManager.Ekleme(musteri1);
			musteriManager.Ekleme(musteri1);


		}
	}
}
