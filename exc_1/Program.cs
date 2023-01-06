/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
*/

//тело программы

Console.Write("Введите число: ");
int N = InputInt();

Console.Write("натуральные числа: ");
NaturalNumber(N);


//методы

int InputInt()
{
    bool isParse = int.TryParse(Console.ReadLine(), out int number);

    if (isParse)
    {
        return number;
    }
    else
    {
        throw new ArgumentException("Введено некорректное значение");
    }
}

void NaturalNumber(int i)
{
    if (i == 0)
    {
        return;
    }
    Console.Write($"{i}   ");
    NaturalNumber(i - 1);
}