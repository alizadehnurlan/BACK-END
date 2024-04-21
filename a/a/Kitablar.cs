namespace a
{
    internal class Kitablar
    {
        // Define a List to hold books
        private string[] List;

        // Constructor to initialize the List
        public Kitablar()
        {
            List = new[]
            {
            "Tarix",
            "Riyaziyat",
            "Fizika",
            "Hendese",
            "Kimya",
            "Biologiya"
        };
        }

        // Method to display the list of books
        public void BookList()
        {
            foreach (var book in List)
            {
                Console.WriteLine(book);
            }
        }

        // Method to add a book to the list
        public void AddBook(string newBook)
        {
            Array.Resize(ref List, List.Length + 1);
            List[List.Length - 1] = newBook;
        }

        // Method to remove a book from the list
        public void RemoveBook(string bookToRemove)
        {
            for (int i = 0; i < List.Length; i++)
            {
                if (List[i].Equals(bookToRemove))
                {
                    for (int j = i; j < List.Length - 1; j++)
                    {
                        List[j] = List[j + 1];
                    }
                    Array.Resize(ref List, List.Length - 1);
                    Console.WriteLine($"{bookToRemove} ugurla icareye verildi");
                    return;
                }
            }
            Console.WriteLine("Kitab tapilmadi!!!");
        }

        // Method to find a book in the list
        public void FindBook(string bookToFind)
        {
            bool found = false;
            foreach (var book in List)
            {
                if (book.Equals(bookToFind))
                {
                    Console.WriteLine("Kitab tapildi: " + book);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Kitab tapilmadi!!!");
            }
        }
    }
}

//using a;
//var t = new test();
