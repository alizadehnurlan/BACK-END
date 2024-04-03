using Lesson8.Bank;
using System.ComponentModel.Design;


var bank = new BankAccount()
{
    card = 0001,
    Balance=100
};
Console.WriteLine("Kart sifrenizi daxil edin...");
int number=Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Gozleyin...");
Thread.Sleep(3000);
Console.Clear();

if (number == bank.card)
{

    bool isActive = true;

    while (isActive)
    {

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Etmek istdeyiniz emeliyyati secin");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("1)kart hesabinin oyrenilmesi");
        Console.WriteLine("2)kartda medaxil");
        Console.WriteLine("3)kartdan mexaric");
        Console.WriteLine("4)imtina");
        Console.ResetColor();
        int secim = Convert.ToInt32(Console.ReadLine());

        if (secim <= 4)
        {
            Thread.Sleep(1000);
            Console.Clear();
            switch (secim)
            {
                case 1:
                    Console.WriteLine($"Balansiniz {bank.Balance}");
                    break;
                case 2:
                    Console.WriteLine("Medaxil edeceyiniz meblelgi daxil edin");
                    double miqdar = Convert.ToInt32(Console.ReadLine());
                    bank.medaxil(miqdar);
                    Console.WriteLine($"Mebleg hesaba ugurla medaxil edildi balans : {bank.Balance}AZN");
                    Console.WriteLine("Kartinizi goturun...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    return;
                case 3:

                  
                    Console.WriteLine("Mexaric edeceyiniz meblegi daxil edin");
                    miqdar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Gozleyin...");
                    Thread.Sleep(3000);
                    Console.Clear();

                    if (miqdar < 0)
                    {
                        Console.WriteLine("Mebleg menfi ola bilmez...");
                        Thread.Sleep(3000);
                        Console.WriteLine("Kartinizi goturun...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        return;
                    }

                    if (miqdar > bank.Balance  )
                    {
                     
                        Console.WriteLine("Daxil etdiyiniz mebleg hesabinizda movcud deyil");
                        Thread.Sleep(3000);
                        Console.WriteLine("Kartinizi goturun...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        return;

                    }
                    Console.WriteLine("Pullar hesablanir...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    bank.mexaric(miqdar);
                    Console.WriteLine($"Mebleg hesabdan ugurla mexaric edildi balans : {bank.Balance}AZN");
                    Console.WriteLine("Kartinizi goturun...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    return;
                case 4:
                    Console.WriteLine($"Kartinizi goturun...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    return;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Yanlıs secim");
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
else
{
    Console.WriteLine("Kart sifreniz duzgun deyil...");
    Console.WriteLine($"Kartinizi goturun...");
    Thread.Sleep(3000);
    Console.Clear();
}
