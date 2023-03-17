using ListaSimplesOOP;

ItemList list = new ItemList();

Item item = new Item(21);


list.Insert(item);

item = new Item(27);
list.Insert(item);


item = new Item(25);
list.Insert(item);


item = new Item(40);
list.Insert(item);


item = new Item(10);
list.Insert(item);


item = new Item(22);
list.Insert(item);
list.Print();

item = list.Find(22);
Console.WriteLine("O número encontrado foi: " + item.Value + " E o proximo dele é: " + item.Next.Value);