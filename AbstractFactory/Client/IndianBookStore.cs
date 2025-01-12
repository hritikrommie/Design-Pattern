using AbstractFactory.Factory;

namespace AbstractFactory.Client;

internal class IndianBookStore : BooksStore
{
    public override IBooksFactory SelectBookFactory()
    {
        return new IndianBooksFactory();
    }
}
