
using System.Runtime.Intrinsics.X86;

namespace ListaSimplesOOP
{
    internal class ItemList
    {
        public Item Start { get; set; }
        public Item End { get; set; }

        public ItemList()
        {
            Start = null;
            End = null;
        }
         public void Insert(Item item)
        {
            if (IsEmpty())
            {
                Start = item;
                End = item;
            }
            else
            {
                if (item.Value <= Start.Value)
                {
                    InsertFirst(item);
                }
                else 
                {
                    if (item.Value >= End.Value)
                    {
                        InsertLast(item);
                    }
                    else
                    {
                        InsertMidle(item);
                    }
                        
                } 
            }
        }

        public void InsertFirst(Item item)
        {
            item.Next = Start;
            Start = item;
        }

        public void InsertLast(Item item)
        {
            End.Next = item;
            End = item;
        }
        public void InsertMidle(Item item)
        {
            Item aux1, aux2;
            aux2 = Start;
            do
            {
                aux1 = aux2.Next;
      

                if (item.Value < aux1.Value)
                {
                    aux2.Next = item;
                    item.Next = aux1;
                }
                else
                {
                    item.Next = aux1.Next;
                    aux1.Next = item;

                }
            } while (item.Next == null);

        }
        public Item Find(int filter)
        {
            Item aux;
            aux = Start;
            do
            {
                if (filter == aux.Value)
                {
                    return aux;
                }
                aux = aux.Next;

            } while (aux != null);

            return null;
        }
        public bool IsEmpty()
        {
            return (Start == null) ? true : false;
        }
        public void Print()
        {
            Item aux;
            aux = Start;
            do
            {  
                Console.WriteLine(aux.Value);
                aux= aux.Next;
                
            } while (aux != null);

        }


    }
}
