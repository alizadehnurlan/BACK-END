//METHODS

//-------------------------------------------------

// TASK-1

//-------------------------------------------------

//int birinci = Convert.ToInt32(Console.ReadLine());
//int ikinci = Convert.ToInt32(Console.ReadLine());

//void func(int a,int b)
//{
//    int c;
//    c = b;
//    b=a;
//    a = c;
//    Console.WriteLine(a);
//    Console.WriteLine(b);
//}

//func(birinci, ikinci);

//-------------------------------------------------

// TASK-2

//-------------------------------------------------

//void func()
//{
//    int birinci = Convert.ToInt32(Console.ReadLine());
//    int ikinci = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(birinci+ikinci);
//}
//func();

//-------------------------------------------------

// TASK-3

//-------------------------------------------------

//int birinci = Convert.ToInt32(Console.ReadLine());
//int ikinci = Convert.ToInt32(Console.ReadLine());
//int ucuncu = Convert.ToInt32(Console.ReadLine());

//void func(int a, int b,int c)
//{
//    int result =(a*b*c)/3;
//    Console.WriteLine(result);
//}


//func(birinci,ikinci,ucuncu); 

//-------------------------------------------------

// TASK-4

//-------------------------------------------------

//int[] numbers = { 10, 5, 8, 20, 15 };

//int max=numbers[0];

//void func(int[] array)
//{
//    foreach(int i in array)
//    {
//        if (i > max)
//        {
//            max = i;
//        }
//    }
//    Console.WriteLine(max);
//}
//func(numbers);

//-------------------------------------------------

//TASK-5

//-------------------------------------------------

//string soz = Console.ReadLine();
//int func(string a)
//{
//    return a.Length;
//}

//Console.WriteLine(func(soz));

//-------------------------------------------------

//TASK-6

//-------------------------------------------------

//int func()
//{
//    int eded1 = Convert.ToInt32(Console.ReadLine());
//    int eded2 = Convert.ToInt32(Console.ReadLine());
//    int cem = 0;

//   if (eded2 > eded1)
//    {
//        for (int i = eded1 + 1; i < eded2; i++)
//        {
//            cem += i;
//        }
//        return cem;
//    }
//    else if(eded1 > eded2) { }
//    {
//        for (int i = eded2 + 1  ; i < eded1; i++)
//        {
//            cem += i;
//        }
//        return cem;
//    }
//}

//Console.WriteLine(func());


//-------------------------------------------------

//TASK-7

//-------------------------------------------------

//int eded = Convert.ToInt32(Console.ReadLine());
//int quvvet = Convert.ToInt32(Console.ReadLine());

//double func(int a, int b)
//{
//    double result = Math.Pow(a, b);
//    return result;
//}

//Console.WriteLine(func(eded, quvvet));

//-------------------------------------------------

//TASK-8

//-------------------------------------------------

// ????????????????????????????????????????????????



//string soz=Console.ReadLine();
//int reqem=int.Parse(soz);

//Console.WriteLine(soz.GetType());

//Console.WriteLine(reqem.GetType());

//-**Task 1 * *.İstifadəçidən iki int tipində ədəd alın. İlk daxil edilən ədədlə ikinci ədədin qiymətini dəyişən parametrli void metod yazın.



//Console.WriteLine("arrayin uzunlugunu daxil edin");
//int uzunluq = Convert.ToInt32(Console.ReadLine());
//string[] arr = new string[uzunluq];

//for (int i = 0; i < arr.Length; i++)
//{
//    string sozler = Console.ReadLine();
//    arr[i] += sozler;


//}
//string axtarilan = Console.ReadLine();

//if (arr.Contains(axtarilan))
//{
//    Console.WriteLine(true);
//}
//Console.WriteLine(Array.IndexOf(arr,axtarilan));




int myNum = 10;
int cehd = 2;
Console.WriteLine("eded daxil edin");
int yourNum = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < cehd; i++)
{
    if (yourNum > myNum)
    {
        Console.WriteLine("asagi");
        yourNum = Convert.ToInt32(Console.ReadLine());
    }
    else if (yourNum < myNum)
    {
        Console.WriteLine("yuxari");
        yourNum = Convert.ToInt32(Console.ReadLine());
    }
}
if (yourNum == myNum)
{
    Console.WriteLine("qalib");
}
else
{
    Console.WriteLine("uduzdun");
}