//Типы данных:
// int, double, string, bool
// Console.OutputEncoding = System.Text.Encoding.UTF8; - Используется при проблеме с кириллицей

//int a = 123, b = 11;

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine("a: {a} b: {b}");
//Console.WriteLine($"a: {a} b: {b}");
//Console.WriteLine("a: "+ a + " b: "+ b);
//Console.WriteLine("a: {0} b: {1}",a,b);

//Поменять значения переменных местами
//version 1
//Console.WriteLine($"a: {a} b: {b}"); // a: 123 b: 11
//
//int с;
//с=b;
//b=a;
//a=с;

//Console.WriteLine($"a: {a} b: {b}"); // a: 11 b: 123

 //version 1.1
 //Console.WriteLine($"a: {a} b: {b}"); // a: 123 b: 11
//
//a=a+b;
//b=a-b;
//a=a-b;

//Console.WriteLine($"a: {a} b: {b}"); // a: 11 b: 123

//int a = 11;
//int b = 22332;

// int count = 1;

// while(count <= 10)
// {
//     Console.WriteLine(count);
//     count = count + 1;
//}

// Подчитайте количество чисел, которые делятся на 3 и на 5
// из [2, 128]

// int number = 21;

// bool flag1 = number % 3 == 0;
// bool flag2 = number % 5 == 0;

// bool result = flag1 && flag2;

// Console.WriteLine(result);

int start = 2;
int end = 128; 
int count = 0;


while(start <= end)
{
    if ((start % 3 == 0) && (start % 5 == 0))
{
    count++;
    Console.WriteLine($"{count}: {start}");
  }
  
  start++;
}

Console.WriteLine($"count = {count}");
