namespace BuilderPatter.Product;

internal class Mobile
{
    public string? os;
    public string? ram;
    public string? rom;
    public string? battery;
    public string? camera;
    public override string ToString()
    {
        return $"My Phone : OS : {os}, Ram : {ram}, Rom : {rom}, Battery : {battery}, Camera : {camera}";
    }
}
