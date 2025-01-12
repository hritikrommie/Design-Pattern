namespace AbstractFactory.Products.Books;

internal class IndianBook : IBook
{
    public override string ToString()
    {
        return base.ToString() + " Indian Book";
    }
}
