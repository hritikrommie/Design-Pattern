using AbstractFactory.Client;

#region Abstract Factory Calling
IndianBookStore indianBookStore = new IndianBookStore();
indianBookStore.GetBook();

EuropianBookStore europianBookStore = new EuropianBookStore();
europianBookStore.GetBook();
#endregion

