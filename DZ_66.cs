// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//================================================================================================================================================

//Решение:

// Console.WriteLine("Для получения суммы натуральных элементов от M до N, введите значение M: ");
// int numberFirst = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Для получения суммы натуральных элементов от M до N, введите значение N: ");
// int numberSecond = int.Parse(Console.ReadLine()!);

// Console.Write($"M = {numberFirst}; N = {numberSecond} -> ");
// if(numberFirst > numberSecond){
//     PrintSum(numberSecond, numberFirst, 0);
// } else if(numberFirst < numberSecond){
//     PrintSum(numberFirst, numberSecond, 0);
// }

// void PrintSum(int start, int end, int result){
//     int i = start;
//     int j = end;
//     int k = result;
//     if(i == j + 1){
//         Console.Write($"{k}");
//         return;
//     } else {
//         k += i;
//         i++;
//         PrintSum(i, j, k);
//     }
// }

//================================================================================================================================================