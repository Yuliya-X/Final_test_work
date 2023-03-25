int Input(string msg)
{
    Console.Write(msg + " ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(string[] array)
{
int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ое значение: ");
        array[i] = Console.ReadLine();
    }
}

void GetStrings(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
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

int size = Input("Введите количество элементов: ");
string[] arrayOriginal = new string[size];
string[] arrayFinal = new string[arrayOriginal.Length];
FillArray(arrayOriginal);
Console.WriteLine("Исходный массив:");
PrintArray(arrayOriginal);
Console.WriteLine();
GetStrings(arrayOriginal, arrayFinal);
Console.WriteLine("Итоговый массив:");
PrintArray(arrayFinal);