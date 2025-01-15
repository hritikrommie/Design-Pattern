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

    /*
     * Don’t forget about implementing a method for fetching the result of the construction. 
     * The reason why this method can’t be declared inside the builder interface is that various 
     * builders may construct products that don’t have a common interface. Therefore, you don’t know 
     * what would be the return type for such a method. However, if you’re dealing with products from 
     * a single hierarchy, the fetching method can be safely added to the base interface.
    */
    Mobile GetMobile();
}
