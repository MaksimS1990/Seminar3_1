// Программа на вход принимает одно число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1,4,9,16,25.
// 2 -> 1,4.

Console.WriteLine("Введите любое число: ");
int N = int.Parse(Console.ReadLine()!);;

int[] GetSqrtTable (int N)
{
    int[] SqrtArray = new int [N];

    for (int i = 0, number = 1; i < N; i++, number++)
    {
        SqrtArray[i] = number * number;
    }
    return SqrtArray;
}

void PrintTable(int[] Array) // функция выводит результат;
{
    int number = 1;
    for(int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine(number + " ^ 2 = " + Array[i]);
        number++;
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);