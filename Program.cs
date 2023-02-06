/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int NumberPrint(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int RecN (int N, int M) 
{
    int temp = 0;
    if (M == N + 1) return temp;
    else 
    {   
        temp = M + RecN(N, M+1);
    }
    return temp;
}

int numberMin = NumberPrint("Введите значения M (меньшее значение): ");
int numberMax = NumberPrint("Введите значения N (большее значение): ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberMin} до {numberMax} равна: {RecN(numberMax, numberMin)}");