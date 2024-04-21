using Library.Classes;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var books = new Books();
books.Names = new List<string> { "Tarix", "Riyaziyyat", "Fizika", "Kimya" };
var journals = new Journals();
journals.Names = new List<string> { "National Geographic", "Time Magazine", "The New Yorker", "Vogue" };
var audio = new AudioBook();
audio.Names = new List<string> { "Becoming", "Educated: A Memoir", "Born a Crime: Stories from a South African Childhood", "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones" };

string ad = "a";
string sifre = "a";

Console.WriteLine("İstifadəçi adını daxil edin");
string istAdi = Console.ReadLine();

Console.WriteLine("Şifrəni daxil edin");
string istSifresi = Console.ReadLine();
bool isTrue = true;
void BookOperation()
{
    Console.WriteLine("Kitablar sinifində etmək istədiyiniz əməliyyatı daxil edin");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1) Kitablar siyahısı");
    Console.WriteLine("2) Kitablar əlavə etmək");
    Console.WriteLine("3) Kitablar icarəyə götürmək");
    Console.WriteLine("4) Kitab axtarmaq");
    Console.WriteLine("5) Geri qayıt");
    Console.WriteLine("---------------------------------");
}
void JournalOperation()
{
    Console.WriteLine("Jurnallar sinifində etmək istədiyiniz əməliyyatı daxil edin");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1) Jurnalların siyahısı");
    Console.WriteLine("2) Jurnal əlavə etmək");
    Console.WriteLine("3) Jurnal icarəyə götürmək");
    Console.WriteLine("4) Jurnal axtarmaq");
    Console.WriteLine("5) Geri qayıt");
    Console.WriteLine("---------------------------------");
}

void AudioOperation()
{
    Console.WriteLine("Səsli kitab sinifində etmək istədiyiniz əməliyyatı daxil edin");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1) Səsli kitab siyahısı");
    Console.WriteLine("2) Səsli kitab əlavə etmək");
    Console.WriteLine("3) Səsli kitab icarəyə götürmək");
    Console.WriteLine("4) Səsli kitab axtarmaq");
    Console.WriteLine("5) Geri qayıt");
    Console.WriteLine("---------------------------------");
}

void Login()
{
  
    Console.WriteLine("Hansı materialı axtarırsınız ?");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1)Kitablar");
    Console.WriteLine("2)Jurnallar");
    Console.WriteLine("3)Səsli kitablar");
    Console.WriteLine("4)Proqramı bağla");
    Console.WriteLine("---------------------------------");
}
int count = 1;

while (count < 5)
{
    count++;
    if (istSifresi == sifre && istAdi == ad)
    {
        Console.WriteLine("Xoş Gəlmisiniz");
        Thread.Sleep(1000);
        Console.Clear();
        Login();
        int choice = Convert.ToInt32(Console.ReadLine());
        while (isTrue)
        {
            if (choice == 1)
            {
                BookOperation();
                int booksChoice = Convert.ToInt32(Console.ReadLine());
                switch (booksChoice)
                {
                    case 1:
                        books.BookList();
                        Console.WriteLine("---------------------------------");

                        break;
                    case 2:
                        Console.WriteLine("Əlavə edəcəyiniz kitabın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string newBook = Console.ReadLine();
                        books.AddBookList(newBook);
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"{newBook} adlı kitab kitabxanaya uğurla əlavə olundu");
                        Console.WriteLine("---------------------------------");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Kirayəyə götürəcəyiniz kitabın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string rentBook = Console.ReadLine();
                        books.DeleteBookList(rentBook);
                        break;
                    case 4:
                        Console.WriteLine("Axtardığınz kitabın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string findBook = Console.ReadLine();
                        books.FindBook(findBook);
                        break;
                    case 5:
                        Console.Clear();
                        Login();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Düzgün seçim edin...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Login();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            else if (choice == 2)
            {
                JournalOperation();
                int journalsChoice = Convert.ToInt32(Console.ReadLine());
                switch (journalsChoice)
                {
                    case 1:
                        journals.JournalList();
                        break;
                    case 2:
                        Console.WriteLine("Əlavə edəcəyiniz jurnalın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string newJournal = Console.ReadLine();
                        journals.AddJournalList(newJournal);
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"{newJournal} adlı jurnal kitabxanaya uğurla əlavə olundu");
                        Console.WriteLine("---------------------------------");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Kirayəyə götürəcəyiniz jurnalın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string rentJournal = Console.ReadLine();
                        journals.DeleteJournalList(rentJournal);
                        break;
                    case 4:
                        Console.WriteLine("Axtardığınz jurnalın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string findJournal = Console.ReadLine();
                        journals.FindJournal(findJournal);
                        break;
                    case 5:
                        Console.Clear();
                        Login();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Düzgün seçim edin...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Login();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            else if (choice == 3)
            {
                AudioOperation();
                int audioChoice = Convert.ToInt32(Console.ReadLine());
                switch (audioChoice)
                {
                    case 1:
                        audio.AudioList();
                        break;
                    case 2:
                        Console.WriteLine("Əlavə edəcəyiniz səsli kitabın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string newAudio = Console.ReadLine();
                        audio.AddAudiolList(newAudio);
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"{newAudio} adlı səsli kitab kitabxanaya uğurla əlavə olundu");
                        Console.WriteLine("---------------------------------");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Kirayəyə götürəcəyiniz səsli kitabın  adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string rentAudio = Console.ReadLine();
                        audio.DeleteAudioList(rentAudio);
                        break;
                    case 4:
                        Console.WriteLine("Axtardığınz səsli kitabın  adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string findAudio = Console.ReadLine();
                        audio.FindAudio(findAudio);
                        break;
                    case 5:
                        Console.Clear();
                        Login();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Düzgün seçim edin...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Login();
                        choice = Convert.ToInt32(Console.ReadLine());
                        break  ;
                }
            }
            else if (choice == 4)
            {
                Console.Clear();
                Console.WriteLine("Proqram bağlanır...");
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }

        }
    }
    else
    {
        Console.WriteLine("İstifadəçi adı və ya şifrə yanlışdır");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("İstifadəçi adını daxil edin");
        istAdi = Console.ReadLine();
        Console.WriteLine("Şifrəni daxil edin");
        istSifresi = Console.ReadLine();
    }
}

Console.WriteLine("Cəhdlər uğursuzdur");
Console.WriteLine("Proqram bağlanır");
Thread.Sleep(1000);
Console.Clear();

