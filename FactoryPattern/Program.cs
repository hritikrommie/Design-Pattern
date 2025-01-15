using FactoryPattern.Factory;
using FactoryPattern.Product;

IFactory<ITransport> factory = new RoadTransportFactory<ITransport>();
factory.CreateTransport();