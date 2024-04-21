using a;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a new instance of the Kitablar class
        var books = new Kitablar();

        // Sample username and password for demonstration
        string ad = "admin";
        int sifre = 123;

        Console.WriteLine("Istifadeci adini daxil edin");
        string istAdi = Console.ReadLine();

        Console.WriteLine("Sifreni daxil edin");
        int istSifresi = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        if (istSifresi == sifre && istAdi == ad)
        {
            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("Zehmet olmasa seçim edin:");
                Console.WriteLine("1. Kitabxanadakı elementlerin siyahısı");
                Console.WriteLine("2. Element elave etmek");
                Console.WriteLine("3. Telebeye kitab kiraye vermek");
                Console.WriteLine("4. Kitabxanada axtarış etmek");
                Console.WriteLine("5. Çıxış");
                Console.WriteLine("------------------------------------------");

                int secim = Convert.ToInt32(Console.ReadLine());

                // Add a check to exit the loop
                if (secim == 5)
                {
                    isActive = false;
                    Console.WriteLine("Programdan çıxılır...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Kitablarin siyahisi");
                        Console.WriteLine("------------------------------------------");
                        books.BookList(); 
                        break;
                    case 2:
                        Console.WriteLine("Elave edeceyiniz kitabin adini daxil edin");
                        string newBook = Console.ReadLine();
                        books.AddBook(newBook); 
                        Console.WriteLine("Kitab ugurla elave edildi!!!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Kitabin adini daxil edin");
                        string silinen = Console.ReadLine();
                        books.RemoveBook(silinen); 
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Axtardiginiz kitabin adini daxil edin");
                        string axtarilan = Console.ReadLine();
                        books.FindBook(axtarilan); 
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Yanlis secim");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Daxil etdiyiniz istifadəçi adı və ya şifrə yanlışdır.");
        }
    }
}




//using a;

//var t = new test();
//t.Ad="Nurlan";
//Console.WriteLine(t.Ad);