namespace structs
{

    struct Books
    {
        public string title;
        public string description;
        public string author;
        public int book_id;
        public int pages;

        public void print()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Book ID: " + book_id);
            Console.WriteLine("Pages: " + pages);
        }
    };

    public class Structures
    {
        static void Main(string[] args)
        {
            Books book1;
            Books book2;
            book1.title = "C# Programming";
            book1.description = "A book on C# Programming";
            book1.author = "Asfand";
            book1.book_id = 12345;
            book1.pages = 200;
            book2.title = "Java Programming";
            book2.description = "A book on Java Programming";
            book2.author = "Aman";
            book2.book_id = 67890;
            book2.pages = 300;
            book1.print();
            book2.print();
        }
    }
}