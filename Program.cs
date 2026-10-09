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
