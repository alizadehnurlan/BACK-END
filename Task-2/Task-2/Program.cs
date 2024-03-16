//Task-1

//--------------------------------------------------------

//Console.WriteLine("Eded daxil edin");
//string soz = Console.ReadLine();
//int eded = Convert.ToInt32(soz);
//if (eded % 3 == 0 && eded % 5 == 0)
//{
//    Console.WriteLine("Fizz&&Buzz");
//}
//else if (eded % 5 == 0)
//{
//    Console.WriteLine("Buzz");
//}
//else if (eded % 3 == 0)
//{
//    Console.WriteLine("Fizz");
//}
//else
//{
//    Console.WriteLine("duzgun deyerler daxil edilmeyib");
//}

//Task-2

//---------------------------------------------------------

//Console.WriteLine("Isoqforun rengini daxil edin");
//string isiqfor=Console.ReadLine().ToLower();
//if (isiqfor == "yasil")
//{
//    Console.WriteLine("masinlar kece biler");
//}else if (isiqfor == "sari")
//{
//    Console.WriteLine("herkes gozlesin");
//}else if(isiqfor == "qirmizi")
//{
//    Console.WriteLine("piyadalar kece biler");
//}
//else
//{
//    Console.WriteLine("duzgun deyerler daxil edilmeyib");
//}

//Task-3

//------------------------------------------------------------

//Console.WriteLine("Iki duzbucaqlininda tereflerini daxil edin");
//int a= Convert.ToInt32(Console.ReadLine());
//int b= Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//int d = Convert.ToInt32(Console.ReadLine());
//int ab = a * b;
//int cd = c * d;
//if(ab > cd)
//{
//    Console.WriteLine("AB-nin sahesi boyukdur");
//}
//else if(ab < cd)
//{
//    Console.WriteLine("CD-nin sahesi boyukdur"); 
//}else if(ab == cd)
//{
//    Console.WriteLine("Saheler beraberdir");
//}

//Task-3

//---------------------------------------------------------------    

//Console.WriteLine("3 ferqli eded daxil edin");
//double a = Convert.ToDouble(Console.ReadLine());
//double b = Convert.ToDouble(Console.ReadLine());
//double c = Convert.ToDouble(Console.ReadLine());

//if (a > b && a > c)
//{
//    Console.WriteLine(a);
//    if (b > c)
//    {
//        Console.WriteLine($"{c},{b},{a}");
//    }
//    else
//    {
//        Console.WriteLine($"{b},{c},{a}");
//    };
//}
//else if (b > c && b > a)
//{
//    Console.WriteLine(b);
//    if (a > c)
//    {
//        Console.WriteLine($"{c},{a},{b}");
//    }
//    else
//    {
//        Console.WriteLine($"{a},{c},{b}");
//    }
//}
//else
//{
//    Console.WriteLine(c);
//    if (a > b)
//    {
//        Console.WriteLine($"{b},{a},{c}");
//    }
//    else
//    {
//        Console.WriteLine($"{a},{b},{c}");
//    }
//};


//Task-4

//-------------------------------------------------------------------
//Console.WriteLine("yasinizi daxil edin");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Umumi meblegi daxil edin");
//double mebleg = Convert.ToDouble(Console.ReadLine());
//if (age > 50 && mebleg > 100)
//{
//    Console.WriteLine(mebleg - (mebleg * 20) / 100);
//}
//else if (age < 50 && mebleg < 100)
//{
//    Console.WriteLine(mebleg - (mebleg * 5) / 100);

//}
//else if (mebleg > 100)
//{
//    Console.WriteLine(mebleg - (mebleg * 15) / 100);
//}
//else if(age>50){
//    Console.WriteLine(mebleg - (mebleg * 10) / 100);

//}

//Task-5

//-------------------------------------------------------------------

//string myEmail = "alizadehnurlan8@gmail.com";
//string myPassword = "nurlan123";
//Console.WriteLine("Emaili daxil edin.");
//string userEmail=Console.ReadLine();    
//Console.WriteLine("Sifreni daxil edin");
//string userPassword=Console.ReadLine();
//if (myEmail==userEmail && myPassword==userPassword)
//{
//    Console.WriteLine("Login ugurludur!");
//}
//else
//{
//    Console.WriteLine("Istifadeci adi ve ya sifre yanlisdir!");
//}