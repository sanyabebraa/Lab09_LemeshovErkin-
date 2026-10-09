//int totalExercises = 8;
//for (int number = 8; number >= 1 ; number--)
//{
//System.Console.WriteLine($"Упражнение {number}");
//}
//System.Console.WriteLine("Домашнее задание готово");
//for (int room = 5; room <= 50; room += 5)
//{
//System.Console.WriteLine($"Кабинет {room}");
//}
//int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// { System.Console.WriteLine("_");
//     for (int day = 1; day <= 5; day++)
//     {
//         System.Console.WriteLine($"Неделя {week}, день {day}");
//     }
// }
using System.ComponentModel.Design.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text.RegularExpressions;

int score = 0;
for (int ticket = 19; ticket <= 30; ticket++)
{
if (ticket == 4 || ticket == 12 || ticket == 19)
{
 score++;
 continue;
}
System.Console.WriteLine($"Первый доступный билет: {ticket},{score}");
break;
}
//for (; ; )
//{
//System.Console.WriteLine("Введите код группы ( для выхода - 'выход'): ");
//string groupCode = Console.ReadLine();

//if (groupCode == "выход") {
//break;
//}
//System.Console.WriteLine($"Записан код группы: {groupCode}");
//}

//System.Console.WriteLine("Работа с журналом завершена");
// int N = 16;
// for (int i = 1; i <= N; i++)
// {
//     if (i % 2 == 1)
//     {
//         System.Console.WriteLine(i);
//     }
// }

// int n = 100;
// for (int i = 0; i<=n; n -= 10)
// {
//     System.Console.WriteLine(n);
// }

// for (int n = 1; n <= 9; n++)
// {
//     for (int j = 1; j <= 9; j++)
//     {
//         System.Console.WriteLine($"{n} * {j} = {n*j}");
//     }
// }
// for (int n = 1; n <= 50; n++)
// {
//     if (n % 3 == 0)
//     {
//         continue;
//     } else if (n % 7 == 0) {
//         break;
//     }

// }

// System.Console.WriteLine("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     System.Console.WriteLine("Фамилия не введена. Завершение работы");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();

// System.Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// int N = 100;
// int M = 3;
// for (int i = N; i >= 0; i -= M)
// {
//     System.Console.WriteLine(i);
// }

// int N = 4;
// string Triangle = "";
// for (int i = 0; i <= N; i++)
// {
//     Triangle += "*";
//     System.Console.WriteLine(Triangle);
// }

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         System.Console.WriteLine(i);
//         break;
//     }
// }

// int N = 100;
// for (int i = N; i >= 0; i -= 2)
// {
//     System.Console.WriteLine(i);
// }