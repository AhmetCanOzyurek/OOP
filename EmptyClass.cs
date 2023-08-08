using System;
class Program
{
    static void Main()
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.adi = "Ahmet";
        ogrenci.numarasi = 1234;

        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.adi = "Mehmet";
        ogrenci1.numarasi = 123123;


        ogrenci.OgrenciBilgisiYazdir();
        ogrenci1.OgrenciBilgisiYazdir();

        Console.ReadLine();
    }
}

public class Ogrenci
{
    public string adi;
    public int numarasi;

    public void OgrenciBilgisiYazdir()
    {
        Console.WriteLine("Ogrenci adi " + adi);
        Console.WriteLine("Ogrenci numarasi" + numarasi);
    }
}