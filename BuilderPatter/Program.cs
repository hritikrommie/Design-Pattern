using BuilderPatter.Builders;
using BuilderPatter.Builders.ConcreteBuilders;

IPhoneBuilder builder= new PhoneBuilder();
builder.reset();
builder.SetOS("Android");
builder.SetCamera("50MP");
var mobile = builder.GetMobile();
Console.WriteLine(mobile);