using FactoryPattern.Product;

namespace FactoryPattern.Factory;

internal class WaterTransportFactory : IFactory
{
    public ITransport CreateTransport()
    {
        return new Ship();
    }
}
