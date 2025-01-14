using BuilderPatter.Product;

namespace BuilderPatter.Builders;

internal interface IPhoneBuilder
{
    void SetOS(string os);
    void SetRam(string ram);
    void SetRom(string rom);
    void SetBattery(string battery);
    void SetCamera(string camera);
    void reset();
    Mobile GetMobile();
}
