namespace Library.Classes
{
    internal class Journals : AllMaterial
    {
        public new void JournalList()
        {
            base.BookList();
        }
        public new void AddJournalList(string newBook)
        {
            base.AddBookList(newBook);
        }
        public new void DeleteJournalList(string removeBook)
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
        public new void FindJournal(string bookToFind)
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
