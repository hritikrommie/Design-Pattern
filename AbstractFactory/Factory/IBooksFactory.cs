using AbstractFactory.Products.Books;
using AbstractFactory.Products.Writers;

namespace AbstractFactory.Factory;

internal interface IBooksFactory
{
    internal IBook CreateBooks();
    internal IWriter CreateWriter();

}
