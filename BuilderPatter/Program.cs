using BuilderPatter.Builders;
using BuilderPatter.Builders.ConcreteBuilders;

// Client Code
// Instead of building phone by client, we can hav 
// another layer called Director, which can organize the order 
// of all creation and then client can call only get method to get a final phone object
// Like a high end phone or lowend phone, which specifations can be provided to director already.
IPhoneBuilder builder= new PhoneBuilder();
builder.reset();
builder.SetOS("Android");
builder.SetCamera("50MP");
var mobile = builder.GetMobile();
Console.WriteLine(mobile);