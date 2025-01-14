using BuilderPatter.Product;

namespace BuilderPatter.Builders.ConcreteBuilders;

// If we want some other logic for same mobile creation
// then we can create a new PhoneBuilder implemenation with different logics
internal class PhoneBuilder : IPhoneBuilder
{
    private Mobile _mobile;
    public Mobile GetMobile()
    {
        return _mobile;
    }

    public void reset()
    {
        _mobile = new();
    }

    public void SetBattery(string battery)
    {
        _mobile.battery = battery;
    }

    public void SetCamera(string camera)
    {
        _mobile.camera = camera;
    }

    public void SetOS(string os)
    {
        _mobile.os = os;
    }

    public void SetRam(string ram)
    {
        _mobile.ram = ram;
    }

    public void SetRom(string rom)
    {
        _mobile.rom = rom;
    }
}
