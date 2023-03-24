Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayOriginal = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1}-ое значение: ");
    arrayOriginal[i] = Console.ReadLine();
}

string[] arrayFinal = new string[arrayOriginal.Length];

void GetStrings(string[] array)
{
    int count = 0;
    for (int i = 0; i < arrayOriginal.Length; i++)
    {
        if (arrayOriginal[i].Length <= 3)
        {
            arrayFinal[count] = arrayOriginal[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Исходный массив:");
PrintArray(arrayOriginal);
Console.WriteLine();
GetStrings(arrayOriginal);
Console.WriteLine("Итоговый массив:");
PrintArray(arrayFinal);
