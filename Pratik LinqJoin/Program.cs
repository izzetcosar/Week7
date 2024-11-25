using Pratik_LinqJoin;

public class program
{

    public static void Main(string[] args)
    {

        List<Author> authors = new List<Author>();
        {
            authors.Add(new Author { AuthorId = 1, Name = "Ricard Bach" });
            authors.Add(new Author { AuthorId = 2, Name = "Tom Robbins" });
            authors.Add(new Author { AuthorId = 3, Name = "Sun Tzu" });
            authors.Add(new Author { AuthorId = 4, Name = "J.R.R Tolkien" });

        }
        List<Book> books = new List<Book>();
        {
            books.Add(new Book { BookId = 1, Title = "Martı", AuthorId = 1 });
            books.Add(new Book { BookId = 2, Title = "Parfümün Dansı", AuthorId = 2 });
            books.Add(new Book { BookId = 3, Title = "Savaş Sanatı", AuthorId = 3 });
            books.Add(new Book { BookId = 4, Title = "Yüzüklerin Efendisi Yüzük Kardeşliği", AuthorId = 4 });
            books.Add(new Book { BookId = 5, Title = "Yüzüklerin Efendisi İki Kule", AuthorId = 4 });


            var library = from book in books
                          join author in authors on book.AuthorId equals author.AuthorId
                          select new
                          {
                              KitapAdı = book.Title,
                              YazarAdı = author.Name,
                              
                          };

            foreach (var item in library)
            {
                Console.WriteLine($"Yazar Adı:{item.YazarAdı} Kitabın Adı:{item.KitapAdı}");
            }

        }













    }
}