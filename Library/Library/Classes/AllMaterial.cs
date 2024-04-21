using System.Collections.Generic;

namespace Library.Classes
{
    public class AllMaterial
    {
        public List<string> Names;
        public virtual void BookList()
        {
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
        public virtual void AddBookList(string newBook)
        {
            Names.Add(newBook);
        }
        public virtual void DeleteBookList(string removeBook)
        {
            foreach (var name in Names)
            {
                if (name == removeBook)
                {
                    Names.Remove(removeBook);
                    Console.WriteLine("Kitab icarəyə götürüldü");
                    return;
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Kitab tapılmadı");
            Console.WriteLine("---------------------------------");
        }
        public virtual void FindBook(string bookToFind)
        {
            foreach (var book in Names)
            {
                if (bookToFind == book)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Kitab tapıldı: " + book);
                    Console.WriteLine("---------------------------------");
                    return;
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Kitab tapılmadı");
            Console.WriteLine("---------------------------------");
        }

    }
}
