using FactoryPattern.Factory;
using FactoryPattern.Product;

IFactory factory = new RoadTransportFactory();
factory.CreateTransport();

IFactory factory1 = new WaterTransportFactory();
factory1.CreateTransport();