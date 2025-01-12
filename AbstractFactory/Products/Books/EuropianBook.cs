namespace AbstractFactory.Products.Books;

internal class EuropianBook : IBook
{
    public override string ToString()
    {
        return base.ToString() + " Europian Book";
    }
}
