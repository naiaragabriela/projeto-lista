
namespace ListaSimplesOOP
{
    internal class Item
    {
        public int Value { get; set; }
        public Item Next { get; set; }

        public Item(int x)
        {
            Value = x;
            Next = null;
        }
    }
   
}
