using AbstractFactory.Factory;

namespace AbstractFactory.Client;

internal class EuropianBookStore : BooksStore
{
    public override IBooksFactory SelectBookFactory()
    {
        return new EuropianBooksFactory();
    }
}
