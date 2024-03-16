//LOOPS

//-------------------------------------------------------------

// Task-1

//-------------------------------------------------------------

//int i = 0;
//int cem = 0;
//Console.WriteLine("deyisenleri daxil edin");
//while (i < 10)
//{
//    i++;
//    int userNum = Convert.ToInt32(Console.ReadLine());

//    cem += userNum;

//};
//Console.WriteLine($"Cem={cem}");

//-------------------------------------------------------------

// Task-2

//-------------------------------------------------------------

//Console.WriteLine("Reqem daxil edin");
//int userNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{userNum} reqem daxil edin");

//int i = 0;
//int cem = 0;
//while (i < userNum)
//{
//    i++;
//    int userNum2 = Convert.ToInt32(Console.ReadLine());
//    cem += userNum2;
//}

//Console.WriteLine($"Cem={cem}");

//-------------------------------------------------------------

// Task-3

//-------------------------------------------------------------

//for(int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{i}*{j}={i*j}");
//    }
//}

//-------------------------------------------------------------

// Task-4

//-------------------------------------------------------------

//Console.WriteLine("Eded daxil edin");
//int userNum=Convert.ToInt32(Console.ReadLine());
//int i = 0;
//int say = 0;
//while (i<userNum)
//{
//    i++;
//    if (i %2 == 0)
//    {
//        say ++;
//    }
//}
//Console.WriteLine($"Cut ededlerin sayi {say}");

//-------------------------------------------------------------

// Task-5

//-------------------------------------------------------------
//int setir = 4;
//int count = 1;
//for (int i = 1;i<=setir;i++)
//{
//    for (int j = 1;j<=i;j++)
//    {
//        Console.Write(count  );
//        count++;
//    }
//    Console.WriteLine();


//};

//-------------------------------------------------------------
//ARRAYS
//-------------------------------------------------------------

// Task-1

//-------------------------------------------------------------

//Console.WriteLine("Ededleri daxil edin");
//int cem = 0;
//int[] nums = new int[5];
//for (int i = 0; i < nums.Length; i++)
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    nums[i] = num;
//    cem += nums[i];
//}
//Console.WriteLine($"Cem : {cem}");

//-------------------------------------------------------------

// Task-2

//-------------------------------------------------------------

//Console.WriteLine("Array uzunlugunu daxil edin.");
//int arrLength = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("-------------------------------");
//Random mixed = new Random();
//int[] mixedNums = new int[arrLength];

//for (int i = 0; i < arrLength; i++)
//{
//    mixedNums[i] = mixed.Next(1, 50);
//}

//Array.Sort(mixedNums);
//foreach (int i in mixedNums)
//{
//    Console.WriteLine(i);
//}

//-------------------------------------------------------------

// Task-3

//-------------------------------------------------------------

//Console.WriteLine("Array uzunlugunu daxil edin.");
//int arrLength = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("-------------------------------");
//Random mixed = new Random();
//int[] mixedNums = new int[arrLength];
//int total = 0;

//-------------------------------------------------------------
//Kiçikdən böyüyə.

//for (int i = 0; i < arrLength; i++)
//{
//    mixedNums[i] = mixed.Next(1, 50);
//}
//int min = mixedNums[0];
//int max = mixedNums[0];

//Array.Sort(mixedNums);
//foreach (int i in mixedNums)
//{
//    Console.WriteLine(i);
//}

//-------------------------------------------------------------
//Minimum.

//foreach (int i in mixedNums)
//{
//    if (i < min)
//    {
//        min= i;
//    }
//}

//-------------------------------------------------------------
//Maksimum.

//foreach (int i in mixedNums)
//{
//    if (i > max)
//    {
//        max = i;
//    }
//}

//-------------------------------------------------------------
//Cəm.

//foreach (int i in mixedNums)
//{
//    total += i;
//}

//-------------------------------------------------------------
//Ədədi orta.

//double averageValue =(double)total/ mixedNums.Length;

//Console.WriteLine("Minimum : " + min);
//Console.WriteLine("Maksimum : " + max);
//Console.WriteLine("Toplam: " + total);
//Console.WriteLine("Ededi orta: " + averageValue);

//-------------------------------------------------------------

// Task-4

//-------------------------------------------------------------
//int[] numbers = { 10, 20, 5, 30, 15, 50, 75, 24 };
//int num1 = Convert.ToInt32(Console.ReadLine());
//foreach (int i in numbers)
//{
//    if (i == num1)
//    {
//        Console.WriteLine($"Eded tapildi {num1}");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Eded tapilmadi");


//        break;
//    }
//}

//-------------------------------------------------------------

// Task-5

//-------------------------------------------------------------

//int[] numbers = { 5, 3, 8, 15, 2, 26, 31, 13, 44, 23, 52, 34, 26, 11 };
//int max = numbers[0];
//int min = numbers[0];

//foreach (int i in numbers)
//{
//    if (i < min)
//    {
//        min = i;
//    }
//    if (i > max)
//    {
//        max= i; 
//    }

//}
//Console.WriteLine($"Minimum :{min}");
//Console.WriteLine($"Maksimum :{max}");
//Console.WriteLine($"Hasil :{min*max}");


