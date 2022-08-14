// Квадратичный (N²).

int[] array = { 43, 33, 29, 1, 23, 454, 66, 2, 7 };

static void Swap(ref int i, ref int j)
{
    var temp = i;
    i = j;
    j = temp;
}

static int[] BubbleSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                Swap(ref array[j], ref array[j + 1]);
            }
        }
    }
    return array;
}

var sortedArray = BubbleSort(array);

for (int i = 0; i < sortedArray.Length; i++)
{
    Console.WriteLine(sortedArray[i]);
}