class program
{
    static void Main(string[] args)
    {
        List<Dizi> diziler = new List<Dizi>();
        Console.WriteLine("Patikaflix Diziler Platformu");

        while (true)
        {
            Dizi yeniDizi = new Dizi();

            Console.Write("Dizi Adı:");
            yeniDizi.DiziAdi = Console.ReadLine();

            Console.Write("Dizi Türü: ");
            yeniDizi.DiziTuru = Console.ReadLine();

            Console.Write("Yönetmen: ");
            yeniDizi.Yonetmen = Console.ReadLine();

            Console.Write("Çıkış Yılı: ");
            yeniDizi.CikisYili = int.Parse(Console.ReadLine());

            // Listeye ekle
            diziler.Add(yeniDizi);

            string cevap;
            while (true)
            {
                Console.Write("Yeni bir dizi eklemek istiyor musunuz? (Evet/Hayır): ");
                cevap = Console.ReadLine().Trim().ToLower();

                if (cevap == "evet" || cevap == "e")
                {
                    break; // Döngüden çıkar, yeni dizi ekle
                }
                else if (cevap == "hayır" || cevap == "h")
                {
                    Console.WriteLine("Dizi ekleme işlemi sona erdi.");
                    goto KomediDizileriOlustur; // Yeni listeye geç
                }
                else
                {
                    Console.WriteLine("Lütfen yalnızca 'Evet' veya 'Hayır' giriniz.");
                }
            }
        }
    
    KomediDizileriOlustur:
        
        // Komedi dizileri listesi oluşturma
        List<KomediDizisi> komediDizileri = diziler
            .Where(d => d.DiziTuru.ToLower() == "komedi")
            .Select(d => new KomediDizisi
            {
                DiziAdi = d.DiziAdi,
                DiziTuru = d.DiziTuru,
                Yonetmen = d.Yonetmen
            })
            .OrderBy(d => d.DiziAdi)
            .ThenBy(d => d.Yonetmen)
            .ToList();
        // Komedi dizilerini ekrana yazdırma
        Console.WriteLine("\nKomedi Dizileri Listesi:");
        foreach (var komediDizi in komediDizileri)
        {
            Console.WriteLine($"Dizi Adı: {komediDizi.DiziAdi}, Tür: {komediDizi.DiziTuru}, Yönetmen: {komediDizi.Yonetmen}");
        }








    }
}

