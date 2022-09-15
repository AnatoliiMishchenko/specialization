
Console.WriteLine("Введите количество элементов массива");
int count = Convert.ToInt32(Console.ReadLine());
int number = 3;// количество элементов поиска

string[] arrayaNew(int count)
{
    string[] array = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

string[] arrayStart = arrayaNew(count);

Console.WriteLine("\n" + string.Join(" , ", arrayStart));// Заданная матрица

int countt(string[] arr)
{
    int countElements = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= number)
        {
            countElements++;
        }
    }
    return countElements;
}

int NewMatrixElements = countt(arrayStart);

Console.WriteLine($"\nМатрица будет состоять из   {NewMatrixElements}  элементов");


string[] arrayFreeElements(int countElements, string[] arr)
{
    string[] arrayFE = new string[countElements];
    int t = 0;
    for (int j = 0; j < arrayFE.Length; j++)
    {
        while (t < arr.Length)
        {
            if (arr[t].Length <= number)
            {
                arrayFE[j] = arr[t];
                t++;
                break;
            }
            t++;
        }
    }
    return arrayFE;
}

string[] MatrixEnd = arrayFreeElements(NewMatrixElements, arrayStart);// Искомая матрица

Console.WriteLine("\n" + string.Join(" : ", MatrixEnd));




