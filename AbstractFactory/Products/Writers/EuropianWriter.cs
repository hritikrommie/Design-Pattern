namespace AbstractFactory.Products.Writers;

internal class EuropianWriter : IWriter
{
    public override string ToString()
    {
        return base.ToString() + " Europian Writer";
    }
}
