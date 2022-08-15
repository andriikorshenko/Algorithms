// Быстрая сортировка (NLogN)

int[] unsortedArray = { 6, 3, 1, 12, 8, 2};

int[] sortedArray = QuickSort(unsortedArray, 0, unsortedArray.Length - 1);

Console.WriteLine($"Sorted array : {string.Join(", ", sortedArray)}");

int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }

    int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

    QuickSort(array, minIndex, pivotIndex - 1);
    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}

static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivot = minIndex - 1;

    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }

    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);

    return pivot; 
}

static void Swap(ref int v1, ref int v2)
{
    int temp = v1;
    v1 = v2;
    v2 = temp;
}