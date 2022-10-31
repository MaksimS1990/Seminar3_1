// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти(x и y);

int GetCoordinats(int numberofQuater)
{
    if (numberofQuater < 1 || numberofQuater > 4)
        return -1;

    if(numberofQuater == 1)
        return 1;

    if(numberofQuater == 2)
        return 2;

    if(numberofQuater == 3)
        return 3;

    if(numberofQuater == 4)
        return 4;

    return -1;
}

Console.WriteLine("insert number of quater");

int numberofQuater = int.Parse(Console.ReadLine()!);

if (GetCoordinats(numberofQuater) == 1)
    Console.WriteLine("x от 0 до + бесконечности; y от 0 до + бесконечности");

else if (GetCoordinats(numberofQuater) == 2)
    Console.WriteLine("x от - бесконечности до 0; y от 0 до + бесконечности");

else if (GetCoordinats(numberofQuater) == 3)
    Console.WriteLine("x от - бесконечности до 0; y от - бесконечности до 0");

else if (GetCoordinats(numberofQuater) == 4)
    Console.WriteLine("x от 0 до + бесконечности; y от - бесконечности до 0");

else Console.WriteLine("Такой четверти не существует!");