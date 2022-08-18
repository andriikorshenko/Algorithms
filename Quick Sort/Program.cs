// Быстрая сортировка (NLogN)

int[] arr = { 10, 5, 2, 3 };


int[] QuickSort(int[] arr)
{
    if (arr.Length < 2)
    {
        return arr;
    }

    int[] arr2 = new int[arr.Length];

    int[] pivot = new int[1];
    pivot[0] = arr[0];

    var less = (from p in arr[1..]
                where p <= pivot[0]
                select p).ToArray();

    var grater = (from p in arr[1..]
                  where p > pivot[0]
                  select p).ToArray();

    return (QuickSort(less).Concat(pivot).Concat(QuickSort(grater))).ToArray();
}

Console.WriteLine($"Sorted array : " +
    $"{string.Join(", ", QuickSort(arr))}");