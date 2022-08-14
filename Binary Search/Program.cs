// Логарифмический (logN).

int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

static int BinarySearch(int key, int[] numbers)
{
    int low = 0;
    int high = numbers.Length - 1;

    while (low <= high)
    {
        // находим середину
        int mid = low + (high - low) / 2;
        // если ключ поиска меньше значения в середине
        // то верхней границей будет элемент до середины
        if (key < numbers[mid]) high = mid - 1;
        else if (key > numbers[mid]) low = mid + 1;
        else return mid;
    }
    return -1;
}

var cc = BinarySearch(1, arr);

Console.ReadKey();