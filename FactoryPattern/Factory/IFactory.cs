using FactoryPattern.Product;

namespace FactoryPattern.Factory;

internal interface IFactory
{
    ITransport CreateTransport();
}
