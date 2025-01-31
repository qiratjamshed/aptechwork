namespace sameer_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book(101, "C# Basics", "John Doe", 299.99);
            Book b2 = new Book(102, "Advanced C#", "Jane Smith", 399.99);



            Console.WriteLine($"Book Added: ID = {b1.BookID}, Title = {b1.Title}, Author = {b1.Author}, Price = {b1.Price}");
            Console.WriteLine($"Book Added: ID = {b2.BookID}, Title = {b2.Title}, Author = {b2.Author}, Price = {b2.Price}");


        }
    }
}


