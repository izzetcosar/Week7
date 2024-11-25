
class Program
{
    static void Main(string[] args)
    {
        // Sanatçı listesi
        List<Artist> artists = new List<Artist>
        {
            new Artist { Name = "Ajda Pekkan", DebutYear = 1968, Genre = "Pop", AlbumSales = 20 },
            new Artist { Name = "Sezen Aksu", DebutYear = 1971, Genre = "Türk Halk Müziği/Pop", AlbumSales = 10 },
            new Artist { Name = "Funda Arar", DebutYear = 1999, Genre = "Pop", AlbumSales = 3 },
            new Artist { Name = "Sertap Erener", DebutYear = 1994, Genre = "Pop", AlbumSales = 5 },
            new Artist { Name = "Sıla", DebutYear = 2009, Genre = "Pop", AlbumSales = 3 },
            new Artist { Name = "Serdar Ortaç", DebutYear = 1994, Genre = "Pop", AlbumSales = 10 },
            new Artist { Name = "Tarkan", DebutYear = 1992, Genre = "Pop", AlbumSales = 40 },
            new Artist { Name = "Hande Yener", DebutYear = 1999, Genre = "Pop", AlbumSales = 7 },
            new Artist { Name = "Hadise", DebutYear = 2005, Genre = "Pop", AlbumSales = 5 },
            new Artist { Name = "Gülben Ergen", DebutYear = 1997, Genre = "Pop/Türk Halk Müziği", AlbumSales = 10 },
            new Artist { Name = "Neşet Ertaş", DebutYear = 1960, Genre = "Türk Halk Müziği/Türk Sanat Müziği", AlbumSales = 2 },
        };

        // 1. Adı 'S' ile başlayan şarkıcılar
        var startsWithS = artists.Where(a => a.Name.StartsWith("S")).Select(a => a.Name);
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        foreach (var name in startsWithS)
        {
            Console.WriteLine(name);
        }

        // 2. Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
        var highSales = artists.Where(a => a.AlbumSales > 10).Select(a => a.Name);
        Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
        foreach (var name in highSales)
        {
            Console.WriteLine(name);
        }

        // 3. 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar
        var oldPopArtists = artists
            .Where(a => a.DebutYear < 2000 && a.Genre == "Pop")
            .OrderBy(a => a.DebutYear)
            .ThenBy(a => a.Name);
        Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
        foreach (var artist in oldPopArtists)
        {
            Console.WriteLine($"[{artist.DebutYear}]");
            Console.WriteLine($"{artist.Name}");
        }

        // 4. En çok albüm satan şarkıcı
        var topSeller = artists.OrderByDescending(a => a.AlbumSales).First();
        Console.WriteLine($"\nEn çok albüm satan şarkıcı: {topSeller.Name} ({topSeller.AlbumSales} milyon)");

        // 5. En yeni çıkış yapan ve en eski çıkış yapan şarkıcı
        var newestArtist = artists.OrderByDescending(a => a.DebutYear).First();
        var oldestArtist = artists.OrderBy(a => a.DebutYear).First();
        Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {newestArtist.Name} ({newestArtist.DebutYear})");

        Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldestArtist.Name} ({oldestArtist.DebutYear})");
    }
}
