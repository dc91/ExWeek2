using ExWeek2;

Console.WriteLine("Ading books to list and printing:");
Book book1 = new Book("J. K. Rowling", "Harry Potter and the Sorcerer\'s Stone", 223);
Book book2 = new Book("Dilan Chroscik", "This Repo", 10);

List<Book> books = [book1, book2];

foreach (var book in books)
{
    Console.WriteLine(book.Print());
}

Console.WriteLine("\nAdding people to list and printing:");
Person person1 = new Person("Dilan", "Chroscik", 33);
Person person2 = new Person("Emina", "Hozo", 30);

List<Person> persons = [person1, person2];

foreach (var person in persons)
{
    Console.WriteLine(person.Print());
}