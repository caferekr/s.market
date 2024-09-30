namespace market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double etFiyat = 150.0, peynirFiyat = 100.0, sutFiyat = 50.0;
            double gomlekFiyat = 200.0, tshirtFiyat = 100.0, etekFiyat = 150.0;
            double rujFiyat = 75.0, tokaFiyat = 20.0, kolyeFiyat = 150.0;

           
            double gidaKdvOrani = 0.20, giyimKdvOrani = 0.18, bujiteriKdvOrani = 0.10;

           
            double toplamTutar = 0;

            
            int secim;

            do
            {
                Console.WriteLine("Lütfen almak istediğiniz kategoriyi seçin:");
                Console.WriteLine("1. Gıda (Et, Peynir, Süt)");
                Console.WriteLine("2. Giyim (Gömlek, TShirt, Etek)");
                Console.WriteLine("3. Bujiteri (Ruj, Toka, Kolye)");
                Console.WriteLine("0. Çıkış");

                secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        toplamTutar += GidaUrunleri(etFiyat, peynirFiyat, sutFiyat);
                        break;
                    case 2:
                        toplamTutar += GiyimUrunleri(gomlekFiyat, tshirtFiyat, etekFiyat);
                        break;
                    case 3:
                        toplamTutar += BujiteriUrunleri(rujFiyat, tokaFiyat, kolyeFiyat);
                        break;
                    case 0:
                        Console.WriteLine("Alışverişten çıkılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
                        break;
                }
            } while (secim != 0);

            
            if (secim == 1) 
            {
                toplamTutar += toplamTutar * gidaKdvOrani;
            }
            else if (secim == 2) 
            {
                toplamTutar += toplamTutar * giyimKdvOrani;
            }
            else if (secim == 3) 
            {
                toplamTutar += toplamTutar * bujiteriKdvOrani;
            }

            
            if (toplamTutar > 3000)
            {
                Console.WriteLine("Toplam tutar 3000 üzerine çıktı, kategoriye göre iskonto uygulanıyor...");

                if (secim == 1) 
                {
                    toplamTutar -= toplamTutar * 0.04;
                }
                else if (secim == 2) 
                {
                    toplamTutar -= toplamTutar * 0.03;
                }
                else if (secim == 3) 
                {
                    toplamTutar -= toplamTutar * 0.02;
                }
            }

            Console.WriteLine($"Ödenecek toplam tutar: {toplamTutar} TL");
        }

        static double GidaUrunleri(double etFiyat, double peynirFiyat, double sutFiyat)
        {
            Console.WriteLine("Gıda ürünlerinden birini seçin:");
            Console.WriteLine("1. Et - 150 TL");
            Console.WriteLine("2. Peynir - 100 TL");
            Console.WriteLine("3. Süt - 50 TL");
            int urunSecim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç adet almak istiyorsunuz?");
            int miktar = Convert.ToInt32(Console.ReadLine());

            switch (urunSecim)
            {
                case 1:
                    return etFiyat * miktar;
                case 2:
                    return peynirFiyat * miktar;
                case 3:
                    return sutFiyat * miktar;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    return 0;
            }
        }

        static double GiyimUrunleri(double gomlekFiyat, double tshirtFiyat, double etekFiyat)
        {
            Console.WriteLine("Giyim ürünlerinden birini seçin:");
            Console.WriteLine("1. Gömlek - 200 TL");
            Console.WriteLine("2. TShirt - 100 TL");
            Console.WriteLine("3. Etek - 150 TL");
            int urunSecim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç adet almak istiyorsunuz?");
            int miktar = Convert.ToInt32(Console.ReadLine());

            switch (urunSecim)
            {
                case 1:
                    return gomlekFiyat * miktar;
                case 2:
                    return tshirtFiyat * miktar;
                case 3:
                    return etekFiyat * miktar;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    return 0;
            }
        }

        static double BujiteriUrunleri(double rujFiyat, double tokaFiyat, double kolyeFiyat)
        {
            Console.WriteLine("Bujiteri ürünlerinden birini seçin:");
            Console.WriteLine("1. Ruj - 75 TL");
            Console.WriteLine("2. Toka - 20 TL");
            Console.WriteLine("3. Kolye - 150 TL");
            int urunSecim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç adet almak istiyorsunuz?");
            int miktar = Convert.ToInt32(Console.ReadLine());

            switch (urunSecim)
            {
                case 1:
                    return rujFiyat * miktar;
                case 2:
                    return tokaFiyat * miktar;
                case 3:
                    return kolyeFiyat * miktar;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    return 0;

            }
        }
    }
}
