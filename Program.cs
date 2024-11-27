using ExWeek2;

Book book1 = new Book("J. K. Rowling", "Harry Potter and the Sorcerer\'s Stone", 223);
Book book2 = new Book("Dilan Chroscik", "This Repo", 10);

List<Book> books = [book1, book2];

foreach (var book in books)
{
    Console.WriteLine(book.Print());
}
