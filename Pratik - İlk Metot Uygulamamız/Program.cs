using System;

class Program
{
    static void Main()
    {
        // 1. Void metot: Sevdiğiniz bir şarkı sözünü yazdırır
        EkranaSarkiSozuYazdir();

        // 2. Geriye tamsayı döndüren metot: Rastgele bir sayının 2'ye bölümünden kalanı döndürür
        int kalan = RastgeleSayiBolumdenKalan();
        Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalanı: {kalan}");

        // 3. Parametre alan ve geriye değer döndüren metot: İki sayının çarpımı
        int carpim = IkiSayininCarpimi(5, 7); // Örnek olarak 5 ve 7 verdik
        Console.WriteLine($"5 ve 7'nin çarpımı: {carpim}");

        // 4. Parametre alan ve geriye değer döndürmeyen metot: İsim ve soyisim ile hoş geldiniz mesajı
        HosGeldinizMesaji("Ekin", "ÖZTÜRK");
    }

    // 1. Geriye değer döndürmeyen void metot
    static void EkranaSarkiSozuYazdir()
    {
        Console.WriteLine("Hayat kısa hızlı yaşamalı, Boş ver düşüver ellerin diline...\n");
    }

    // 2. Geriye tamsayı döndüren metot
    static int RastgeleSayiBolumdenKalan()
    {
        Random random = new Random(); // Rastgele sayı üretmek için Random sınıfı
        int rastgeleSayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı üret
        return rastgeleSayi % 2; // Rastgele sayının 2'ye bölümünden kalanı döndür
    }

    // 3. Parametre alan ve geriye değer döndüren metot
    static int IkiSayininCarpimi(int sayi1, int sayi2)
    {
        return sayi1 * sayi2; // İki sayının çarpımını döndür
    }

    // 4. Parametre alan ve geriye değer döndürmeyen metot
    static void HosGeldinizMesaji(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}!");
    }
}
