//-------------------------------------------------------------------

//If-else

//-------------------------------------------------------------------

//Task-1

//-------------------------------------------------------------------

//Console.WriteLine("3 eded daxil edin.");
//int a=Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//if (a > b && a > c)
//{
//    Console.WriteLine($"En boyuk eded {a}");
//}
//else if (b > a && b > c)
//{
//    Console.WriteLine($"En boyuk eded {b}");
//}
//else if (c > a && c > b)
//{
//    Console.WriteLine($"En boyuk eded {c}");
//}
//else
//{
//    Console.WriteLine("Duzgun deyerler daxil edilmeyib.");
//}

//Task-2

//-------------------------------------------------------------------

//Console.WriteLine("2 eded daxil edin.");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int result = a + b;
//if (result > 100)
//{
//    Console.WriteLine(a+(b/2));
//}
//else
//{
//    Console.WriteLine(result);
//}

//Task-3

//-------------------------------------------------------------------

//Console.WriteLine("2 eded daxil edin.");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//if (a > b )
//{
//    if (a % 2 == 0)
//    {
//        Console.WriteLine($"En boyuk eded cutdur : {a}");

//    }else if (a % 2 != 0) {
//        Console.WriteLine($"En boyuk eded tekdir : {a}");
//    }
//}
//else
//{
//    if (a < b)
//    {
//        if (b % 2 == 0)
//        {
//            Console.WriteLine($"En boyuk eded cutdur : {b}");

//        }
//        else if (b % 2 != 0)
//        {
//            Console.WriteLine($"En boyuk eded tekdir : {b}");
//        }
//    };
//};

//Task-4

//-------------------------------------------------------------------

//int a = 10;
//Console.WriteLine("Ededi daxil edin");
//int b=Convert.ToInt32(Console.ReadLine());
//if (b == a)
//{
//    Console.WriteLine("tebrikler");
//}
//else if (b > a)
//{
//    Console.WriteLine("Daha kicik eded daxil edin");
//    b = Convert.ToInt32(Console.ReadLine());
//    if (b == a)
//    {
//        Console.WriteLine("tebrikler");
//    }
//    else if(b>a){
//        Console.WriteLine("Daha kicik eded daxil edin");
//        b = Convert.ToInt32(Console.ReadLine());
//        if (b == a)
//        {
//            Console.WriteLine("tebrikler");
//        }
//        else
//        {
//            if (b != a) {
//                Console.WriteLine("Uduzdunuz");
//            }
//        }
//    }
//    else if(a>b){
//        Console.WriteLine("Daha boyuk eded daxil edin");
//        b = Convert.ToInt32(Console.ReadLine());
//        if (b == a)
//        {
//            Console.WriteLine("tebrikler");
//        }
//    }
//    else if (a > b)
//    {
//        Console.WriteLine("Daha boyuk eded daxil edin");
//        b = Convert.ToInt32(Console.ReadLine());
//        if (b == a)
//        {
//            Console.WriteLine("tebrikler");
//        }
//        else
//        {
//            if (b != a)
//            {
//                Console.WriteLine("Uduzdunuz");
//            }
//        }
//    }
//}
//else if (b < a)
//{
//    Console.WriteLine("Daha boyuk eded daxil edin");
//    b = Convert.ToInt32(Console.ReadLine());
//    if (b == a)
//    {
//        Console.WriteLine("tebrikler");
//    }
//    else if (b < a)
//    {
//        Console.WriteLine("Daha boyuk eded daxil edin");
//        b = Convert.ToInt32(Console.ReadLine());
//        if (b == a)
//        {
//            Console.WriteLine("tebrikler");
//        }
//        else
//        {
//            if (b != a)
//            {
//                Console.WriteLine("Uduzdunuz");
//            }
//        }
//    }
//    else if (a < b)
//    {
//        Console.WriteLine("Daha kicik eded daxil edin");
//        b = Convert.ToInt32(Console.ReadLine());
//        if (b == a)
//        {
//            Console.WriteLine("tebrikler");
//        }
//    }
//    else if (a < b)
//    {
//        Console.WriteLine("Daha kicik eded daxil edin");
//        b = Convert.ToInt32(Console.ReadLine());
//        if (b == a)
//        {
//            Console.WriteLine("tebrikler");
//        }
//        else
//        {
//            if (b != a)
//            {
//                Console.WriteLine("Uduzdunuz");
//            }
//        }
//    }
//};

//-------------------------------------------------------------------

//Switch

//-------------------------------------------------------------------

//Task-1

//-------------------------------------------------------------------

//string ay = Convert.ToString(Console.ReadLine());

//switch (ay)
//{
//    case "yanvar":
//        Console.WriteLine("31");
//        break;
//    case "fevral":
//        Console.WriteLine("29");
//        break;
//    case "mart":
//        Console.WriteLine("31");
//        break;
//    case "aprel":
//        Console.WriteLine("30");
//        break;
//    case "may":
//        Console.WriteLine("31");
//        break;
//    case "iyun":
//        Console.WriteLine("30");
//        break;
//    case "iyul":
//        Console.WriteLine("31");
//        break;
//    case "avqust":
//        Console.WriteLine("31");
//        break;
//    case "sentyabr":
//        Console.WriteLine("30");
//        break;
//    case "oktyabr":
//        Console.WriteLine("31");
//        break;
//    case "noyabr":
//        Console.WriteLine("30");
//        break;
//    case "dekabr":
//        Console.WriteLine("31");
//        break;
//    default:
//        Console.WriteLine("Bele bir ay movcud deyil");
//        break;
//}

//-------------------------------------------------------------------

//Loops

//-------------------------------------------------------------------

//Task-1

//-------------------------------------------------------------------

//int i = 1;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}while (i <= 10);

//-------------------------------------------------------------------

//Task-2

//-------------------------------------------------------------------

//for(int i = 10; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}

//-------------------------------------------------------------------

//Task-3

//-------------------------------------------------------------------

//int cem = 0;
//int i = 0;
//while (i<=10)
//{
//  if (i % 2 != 0)
//    {
//        cem += i;
//    }
//    i++;
//}
//Console.WriteLine(cem);

//-------------------------------------------------------------------

//Task-4

//-------------------------------------------------------------------

//int cem = 0;
//for (int i = 0; i <=10; i++)
//{
//    if (i % 3 == 0)
//    {
//        cem += i;
//    };
//}
//Console.WriteLine(cem);

//-------------------------------------------------------------------

//Task-5

//-------------------------------------------------------------------

//for (int i = 0; i <= 10; i++)
//{
//    if (i==4 )
//    {
//        continue;
//    };
//    if (i == 7) 
//    {
//        continue;
//    };


//    Console.WriteLine(i);
//}

//-------------------------------------------------------------------

//Arrays

//-------------------------------------------------------------------

//Task-1

//-------------------------------------------------------------------

//int[] arr = new int[10];

//Random random = new Random();

//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i]= random.Next(1, 100); 
//}

//foreach (int i in arr)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("Max:" + arr.Max());  

//-------------------------------------------------------------------

//Task-2

//-------------------------------------------------------------------

//int[,] matrix = {
//  {1, 2, 3},
//  {4, 5, 6},
//  {7, 8, 9}
//  };

//foreach (int i in matrix)
//{
//    Console.WriteLine(i);
//}

//-------------------------------------------------------------------

//Task-3

//-------------------------------------------------------------------

//int[,] matrix = {
//  {15, 20, 33},
//  {2, 25, 47},
//  {12, 18, 90}
//  };

//int cem = 0;

//foreach (int x in matrix)
//{
//    cem += x;
//}
//Console.WriteLine("Cem :" + cem);   

//-------------------------------------------------------------------

//Task-4

//-------------------------------------------------------------------

//Console.WriteLine("Arrayin uzunlugunu daxil edin");
//int length=Convert.ToInt32(Console.ReadLine());
//Random random = new Random();
//int[] arr=new int[length];


//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(1, 100);
//}

//foreach (int i in arr)
//{
//    if (i % 2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//-------------------------------------------------------------------

//Task-5

//-------------------------------------------------------------------

//int[] numbers = { 5, 3, 8, 15, 2, 26, 31, 13, 44, 23, 52, 34, 26, 11 };
//int ikiyeBolunen = 0;
//int uceBolunen = 0;

//foreach (int i in numbers) {
//    if (i % 2 == 0)
//    {
//        ikiyeBolunen += i;
//    };
//    if (i % 3 == 0)
//    {
//        uceBolunen += i;
//    }
//};
//Console.WriteLine(ikiyeBolunen+uceBolunen); 




