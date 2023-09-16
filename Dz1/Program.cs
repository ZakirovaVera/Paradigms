// Задача №1
// Дан список целых чисел numbers. Необходимо написать в императивном стиле процедуру для
// сортировки числа в списке в порядке убывания. Можно использовать любой алгоритм сортировки.

int[] array = new int[] { 2, 5, 0, 10 };

static int[] SortArray(int[] arr)
{
    bool isSorted = false;
    int temp;
    while (isSorted == false)
    {
        isSorted = true;
        for (int i = 0; i < arr.Count() - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                isSorted = false;

                temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
    }
    return arr;
}
void PrintArray(int[] inArray)
{
    for (int j = 0; j < inArray.GetLength(0); j++)
    {
        Console.Write($"{inArray[j]}\t");
    }
    Console.WriteLine();

}

SortArray(array);
PrintArray(array);


// Задача №2
// Написать точно такую же процедуру, но в декларативном стиле

List<int> array2 = new() { 1, 5, 4, 25 };
array2.Sort();
PrintArray(array2.ToArray());