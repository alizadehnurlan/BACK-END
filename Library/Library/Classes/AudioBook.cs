namespace Library.Classes
{
    internal class AudioBook:AllMaterial
    {
        public List<string> Names = new List<string> { "Becoming", "Educated: A Memoir", "Born a Crime: Stories from a South African Childhood", "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones" };;
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
                    Console.WriteLine("Səsli kitab icarəyə götürüldü");
                    return;
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Səsli Kitab tapılmadı");
            Console.WriteLine("---------------------------------");
        }
        public override void FindBook(string bookToFind)
        {
            bool found = false;
            foreach (var book in Names)
            {
                if (book.Equals(bookToFind))
                {
                    Console.WriteLine("Səsli kitab tapıldı: " + book);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Səsli kitab tapılmadı!!!");
            }
        }
    }
}
