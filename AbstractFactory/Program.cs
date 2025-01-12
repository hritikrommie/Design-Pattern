using AbstractFactory.Client;

IndianBookStore indianBookStore = new IndianBookStore();
indianBookStore.GetBook();

EuropianBookStore europianBookStore = new EuropianBookStore();
europianBookStore.GetBook();