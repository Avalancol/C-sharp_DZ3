// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string Read5Str(string text)
{
    while (true)
    {
        System.Console.Write(text);
        string str = Console.ReadLine()!;
        if (str.Length == 5)
            return str;
    }
}

System.Console.WriteLine("Первая задача.");
string str = Read5Str("Введите пятизначное число: ");
if (str[0] == str[4] && str[1] == str[3])
    System.Console.Write("Это полиндром.");
else
    System.Console.Write("Это не полиндром.");

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine("\n\nВторая задача.");
int[] a = new int[3];
int[] b = new int[3];
a[0] = ReadInt("Введите координату X точки A: ");
a[1] = ReadInt("Введите координату Y точки A: ");
a[2] = ReadInt("Введите координату Z точки A: ");
b[0] = ReadInt("Введите координату X точки B: ");
b[1] = ReadInt("Введите координату Y точки B: ");
b[2] = ReadInt("Введите координату Z точки B: ");
double res = Math.Round(Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + Math.Pow(a[2] - b[2], 2)), 2);
System.Console.WriteLine("Расстояние между точками в 3D = " + res);

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cubes(int number)
{
  for (int i = 1; i <= number; i++)
  {
    System.Console.Write(Math.Pow(i, 3) + " ");
  }
}

System.Console.WriteLine("\n\nТретья задача.");
int number = ReadInt("Введите число N: ");
Cubes(number);