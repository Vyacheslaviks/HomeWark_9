/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
*/

//тело программы

Console.Write("Введите число M: ");
int M = InputInt();

Console.Write("Введите число N: ");
int N = InputInt();

SumNaturalNumbers(M, N);


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

void SumNaturalNumbers(int M, int N, int sum = 0)
{
    if(N < M)
    {
        Console.WriteLine(sum);
        return;
    }

    sum = sum + N;
    SumNaturalNumbers(M, N - 1, sum);
}