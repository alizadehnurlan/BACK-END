//TASK-1

//----------------------------------------

//int cem = 0;
//func(10, 22, 36, 23, 65, 13, 15, 18);
//void func(params int[] reqemler)
//{
//    foreach(int i in reqemler)
//    {
//        cem += i;
//    }
//    Console.WriteLine(cem);
//}

//----------------------------------------

//TASK-2

//----------------------------------------

//func(36, 30, 5, 80, 20, 44, 12, 65, 51, 83);
//void func(params int[] reqemler)
//{
//    int min = reqemler[0];
//    int max = reqemler[0];
//    for (int i = 1; i < reqemler.Length; i++)
//    {
//        if (reqemler[i] < min)
//        {
//            min = reqemler[i];
//        }
//        else if (reqemler[i] > max)
//        {
//            max = reqemler[i];
//        }
//    }
//    Console.WriteLine(min + max);
//}

//----------------------------------------

//TASK-3

//----------------------------------------

//int[] nums = {1,2,3,4,5};

//func(nums);

//void func(int[] reqemler)
//{
//    Array.Reverse(reqemler);
//    foreach (int i in nums)
//    {
//        Console.WriteLine(i);
//    }
//}

//----------------------------------------

//TASK-4

//----------------------------------------

//int count = 0;
//int axtarilan = 7;
//int[] nums= { 11, 26, 51, 69, 82, 7, 15, 59, 95, 97, 25, 7, 37, 48, 57, 26, 83, 95, 52, 64, 7, 26 };
//foreach(int num in nums)
//{
//    if(num == axtarilan)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//----------------------------------------

//TASK-5

//----------------------------------------

//string[] students = {"Ali","Nicat","Alim","Davud","Lale","Elchin","Faiq","Elvin"};
//string axtarilamn = "nihad";

//int tapilan=Array.IndexOf(students, axtarilamn);

//if (tapilan == -1)
//{
//    Console.WriteLine("telebe tapilmadi");
//}
//else
//{
//    Console.WriteLine("telebe tapildi");
//}


//----------------------------------------

//TASK-6

//----------------------------------------

//string str1 = "155";
//string str2 = "15";
//int result=string.Compare(str1, str2);

//Console.WriteLine(result);
//if(result < 0)
//{
//    Console.WriteLine("str1 str2 den kicikdir");
//}
//else if(result > 0)
//{
//    Console.WriteLine("str1 str2 den boyukdur");

//}
//else if (result == 0)
//{
//    Console.WriteLine("str1 str2 e beraberdir");
//}

//----------------------------------------

//TASK-7

//----------------------------------------

//string message = "C# is the most popular language in the world";
//string axtarilan = "age";

//if (message.Contains(axtarilan))
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}

//----------------------------------------

//TASK-8

//----------------------------------------

//string[] colors = { "white", "black", "green", "red", "yellow" };

//string result=string.Join(" ", colors,1,2);
//Console.WriteLine(result);