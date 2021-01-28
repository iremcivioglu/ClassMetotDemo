using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class MusteriManager
{
	public MusteriManager()
	{
		
	}
	public void Ekleme (Musteri musteri)
    {
		Console.WriteLine("Tebrikler. Müşteri eklendi" + musteri.MusteriId + musteri.MusteriAdi + musteri.MusteriSoyadi)
    }
	public void Silme(Musteri musteri)
	{
		Console.WriteLine("Tebrikler. Müşteri silindi" + musteri.MusteriId + musteri.MusteriAdi + musteri.MusteriSoyadi)

	}
	public void Listeleme(Musteri musteriler [] )
	{
		//Musteri[] musteriler = new Musteri[] { };
		foreach (musteri in musteriler)
        {
			Console.WriteLine(musteriler + "\n");
        }
		Console.WriteLine("Tebrikler. Müşteri listelendi" + musteri.MusteriId + musteri.MusteriAdi + musteri.MusteriSoyadi )

	}

}
