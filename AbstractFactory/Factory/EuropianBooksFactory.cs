using AbstractFactory.Products.Books;
using AbstractFactory.Products.Writers;

namespace AbstractFactory.Factory;

internal class EuropianBooksFactory : IBooksFactory
{
    IBook IBooksFactory.CreateBooks()
    {
        return new EuropianBook();
    }

    IWriter IBooksFactory.CreateWriter()
    {
        return new EuropianWriter();
    }
}
