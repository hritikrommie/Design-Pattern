namespace AbstractFactory.Products.Writers;

internal class IndianWriter : IWriter
{
    public override string ToString()
    {
        return base.ToString() + " Indian Writer";
    }
}
