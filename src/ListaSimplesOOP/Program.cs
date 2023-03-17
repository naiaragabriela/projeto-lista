using ListaSimplesOOP;

ItemList list = new ItemList();

Item item;

Random r = new Random();

do
{
    
    int x = r.Next(50);
    item = new(x);
    list.Insert(new(x));
    list.Print();
    Console.ReadLine();

} while (true);

