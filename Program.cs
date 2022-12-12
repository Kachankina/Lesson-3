//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.Clear();
// Console.Write("Insert number: ");
// int num = int.Parse(Console.ReadLine());
// int a = num / 10000;
// int a1 = num / 1000 % 10;
// int a2 = num /  10 % 10;
// int a3 = num % 10;
// Console.WriteLine($"{a} {a1} {a2} {a3}");
// if (a == a3 && a1 == a2)
// {
//     Console.Write("Yes");
// }
// else
// {
//     Console.Write("No");
// }
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("Введите координату Х первой точки: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Y первой точки: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Z первой точки: ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Х второй точки: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Y второй точки: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Z второй точки: ");
// int z2 = int.Parse(Console.ReadLine());

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;
// double length =  Math.Sqrt(A * A + B * B + C * C);
// double P = Math.Round(length, 2);
// Console.WriteLine($"Длинна отрезка {P}");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.Write("Введите число N:");
// int N = int.Parse(Console.ReadLine()!);

// int I = 1;
// int D = 0;

// while (I <= N)
// {
//     D = I * I * I;
//     I++;
//     Console.WriteLine(D);
// }
