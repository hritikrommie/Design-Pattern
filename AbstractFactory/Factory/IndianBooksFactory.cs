using AbstractFactory.Products.Books;
using AbstractFactory.Products.Writers;

namespace AbstractFactory.Factory;

internal class IndianBooksFactory : IBooksFactory
{
    IBook IBooksFactory.CreateBooks()
    {
        return new IndianBook();
    }

    IWriter IBooksFactory.CreateWriter()
    {
        return new IndianWriter();
    }
}
