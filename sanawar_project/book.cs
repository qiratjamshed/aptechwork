namespace sameer_test
{
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public Book(int bookID, string title, string author, double price)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            Price = price;
        }
    }
}