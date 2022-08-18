// Быстрая сортировка (NLogN)

int[] arr = { 3, 4, 3, 5, 7, 9, 2, 1 };

int[] QuickSort(int[] arr)
{
    if (arr.Length < 2)
    {
        return arr;
    }

    var pivot = new int[] { arr[0] };

    var less = (from p in arr[1..]
                where p <= pivot[0]
                select p).ToArray();

    var grater = (from p in arr[1..]
                  where p > pivot[0]
                  select p).ToArray();

    return (QuickSort(less)
        .Concat(pivot)
        .Concat(QuickSort(grater)))
        .ToArray();
}

Console.WriteLine($"Sorted array : " +
    $"{string.Join(", ", QuickSort(arr))}");