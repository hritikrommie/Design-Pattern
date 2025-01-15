using FactoryPattern.Product;

namespace FactoryPattern.Factory;

internal class RoadTransportFactory : IFactory
{
    public ITransport CreateTransport()
    {
        return new Truck();
    }
}
