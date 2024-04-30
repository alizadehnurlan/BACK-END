namespace Library.Classes
{
    public class LibraryItem
    {
        public List<string> Names;
        public LibraryItem()
        {
            Names = new List<string>();
        }
        public  void ItemList()
        {
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
        public  void AddItem(string newItem)
        {
            Names.Add(newItem);
        }
        public  void DeleteItem(string removeItem)
        {
            foreach (var name in Names)
            {
                if (name == removeItem)
                {
                    Names.Remove(removeItem);
                    Console.WriteLine($"{removeItem} məhsulu uğurla icarəyə götürüldü ");
                    return;
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{removeItem} məhsulu tapılmadı");
            Console.WriteLine("---------------------------------");
        }
        public  void FindItem(string itemToFind)
        {
            foreach (var book in Names)
            {
                if (itemToFind == book)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"{itemToFind} məhsulu tapıldı: " + book);
                    Console.WriteLine("---------------------------------");
                    return;
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{itemToFind} məhsulu tapılmadı");
            Console.WriteLine("---------------------------------");
        }
    }
}
