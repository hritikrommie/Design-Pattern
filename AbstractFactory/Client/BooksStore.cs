using AbstractFactory.Factory;
using AbstractFactory.Products.Books;
using AbstractFactory.Products.Writers;

namespace AbstractFactory.Client;

internal abstract class BooksStore
{
    internal void GetBook()
    {
        IBooksFactory factory = SelectBookFactory();
        IBook book = factory.CreateBooks();
        IWriter writer = factory.CreateWriter();
        Console.WriteLine(book);
        Console.WriteLine(writer);
    }
    public abstract IBooksFactory SelectBookFactory();
}
