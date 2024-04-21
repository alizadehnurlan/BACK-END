namespace Library.Classes
{
    internal class AudioBook:AllMaterial
    {
        public new void AudioList()
        {
            base.BookList();
        }
        public new void AddAudiolList(string newBook)
        {
            base.AddBookList(newBook);
        }
        public new void DeleteAudioList(string removeBook)
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
        public new void FindAudio(string bookToFind)
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
