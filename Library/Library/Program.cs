using Library.Classes;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var books=new Books();
var audio=new AudioBook();
var journals=new Journals();

string ad = "admin";
string sifre = "admin";
int count = 1;

Console.WriteLine("İstifadəçi adını daxil edin");
string istAdi = Console.ReadLine();
Console.WriteLine("Şifrəni daxil edin");
string istSifresi = Console.ReadLine();

bool isTrue = true;

void DisplayMenu(string category)
{
    Console.WriteLine($"{category} sinifində etmək istədiyiniz əməliyyatı daxil edin");
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"1) {category} siyahısı");
    Console.WriteLine($"2) {category} əlavə etmək");
    Console.WriteLine($"3) {category} icarəyə götürmək");
    Console.WriteLine($"4) {category} axtarmaq");
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

while (count < 5)
{
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
                DisplayMenu("kitab");
                int booksChoice = Convert.ToInt32(Console.ReadLine());
                switch (booksChoice)
                {
                    case 1:
                        books.ItemList();
                        Console.WriteLine("---------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Əlavə edəcəyiniz kitabın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string newBook = Console.ReadLine();
                        books.AddItem(newBook);
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Kirayəyə götürəcəyiniz kitabın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string rentBook = Console.ReadLine();
                        books.DeleteItem(rentBook);
                        break;
                    case 4:
                        Console.WriteLine("Axtardığınz kitabın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string findBook = Console.ReadLine();
                        books.FindItem(findBook);
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
                        break;
                }
            }
            else if (choice == 2)
            {
                DisplayMenu("Jurnal");
                int journalsChoice = Convert.ToInt32(Console.ReadLine());
                switch (journalsChoice)
                {
                    case 1:
                        journals.ItemList();
                        break;
                    case 2:
                        Console.WriteLine("Əlavə edəcəyiniz jurnalın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string newJournal = Console.ReadLine();
                        journals.AddItem(newJournal);
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Kirayəyə götürəcəyiniz jurnalın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string rentJournal = Console.ReadLine();
                        journals.DeleteItem(rentJournal);
                        break;
                    case 4:
                        Console.WriteLine("Axtardığınz jurnalın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string findJournal = Console.ReadLine();
                        journals.FindItem(findJournal);
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
                        break;
                }
            }
            else if (choice == 3)
            {
                DisplayMenu("Səsli kitab");
                int audioChoice = Convert.ToInt32(Console.ReadLine());
                switch (audioChoice)
                {
                    case 1:
                        audio.ItemList();
                        break;
                    case 2:
                        Console.WriteLine("Əlavə edəcəyiniz səsli kitabın adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string newAudio = Console.ReadLine();
                        audio.AddItem(newAudio);
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Kirayəyə götürəcəyiniz səsli kitabın  adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string rentAudio = Console.ReadLine();
                        audio.DeleteItem(rentAudio);
                        break;
                    case 4:
                        Console.WriteLine("Axtardığınz səsli kitabın  adını daxil edin");
                        Console.WriteLine("---------------------------------");
                        string findAudio = Console.ReadLine();
                        audio.FindItem(findAudio);
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
    count++;
}

Console.WriteLine("Cəhdlər uğursuzdur");
Console.WriteLine("Proqram bağlanır");
Thread.Sleep(1000);
Console.Clear();

