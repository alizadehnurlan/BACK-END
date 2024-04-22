namespace Library.Classes
{
    internal class Journals : AllMaterial
    {
        public override void BookList()
        {
            base.BookList();
        }
        public override void AddBookList(string newBook)
        {
            base.AddBookList(newBook);
        }
        public override void DeleteBookList(string removeBook)
        {
            foreach (var name in Names)
            {
                if (name == removeBook)
                {
                    Names.Remove(removeBook);
                    Console.WriteLine("Jurnal icarəyə götürüldü");
                    return;
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Jurnal tapılmadı");
            Console.WriteLine("---------------------------------");
        }
        public override void FindBook(string bookToFind)
        {
            bool found = false;
            foreach (var book in Names)
            {
                if (book.Equals(bookToFind))
                {
                    Console.WriteLine("Jurnal tapıldı: " + book);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Jurnal tapılmadı!!!");
            }
        }
    }
}
