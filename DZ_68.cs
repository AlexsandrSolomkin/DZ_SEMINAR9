// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//================================================================================================================================================

//Решение:

// Console.WriteLine("Для вычисления функции Аккермана A(m, n), введите значение m: ");
// int numberFirst = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Для вычисления функции Аккермана A(m, n), введите значение n: ");
// int numberSecond = int.Parse(Console.ReadLine()!);

// if((numberFirst >= 0) && (numberSecond >= 0)){
//     Console.WriteLine("Результат работы функции Аккермана:");
//     Console.WriteLine($"m = {numberFirst}, n = {numberSecond} -> A(m, n) = {FunctionAkkerman(numberFirst, numberSecond)}");
// } else {
//     Console.WriteLine("Значения переменных не может быть меньше 0");
// }

// static int FunctionAkkerman(int first, int second){
//     int m = first;
//     int n = second;
//     if(m == 0){
//         n = n + 1;
//         return n;
//     } else if((m != 0) && (n == 0)){
//         m = m - 1;
//         return FunctionAkkerman(m, 1);
//     } else if((m > 0) && (n > 0))
//         m = m - 1;
//         n = n - 1;
//         int m2 = m + 1;
//         return FunctionAkkerman(m, FunctionAkkerman(m2, n));
// }

//================================================================================================================================================