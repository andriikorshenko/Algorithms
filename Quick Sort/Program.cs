//Быстрая сортировка (NLogN).

int[] array = { 3, 4, 8, 5, 7, 9, 2, 1, 6 };

int[] QuickSort(int[] array)
{
    if (array.Length < 2)
    {
        return array;
    }

    var pivot = new int[] { array[0] };

    var less = (from p in array[1..]
                where p <= pivot[0]
                select p).ToArray();

    var grater = (from p in array[1..]
                  where p > pivot[0]
                  select p).ToArray();

    return (QuickSort(less)
        .Concat(pivot)
        .Concat(QuickSort(grater)))
        .ToArray();
}

Console.WriteLine($"Sorted array : " +
    $"{string.Join(", ", QuickSort(array))}");