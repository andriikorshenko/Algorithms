/*
 * Binary Search: 
 * Time compexity is O(log n),
 * Space complexity is O(n).
 */

int[] array = { 1, 2, 3, 4, 5, 6, 7 };

static int BinarySearch(int[] numbers, int key)
{
    int lowIndex = 0;
    int highIndex = numbers.Length - 1;

    while (lowIndex <= highIndex)
    {
        int midIndex = lowIndex + (highIndex - lowIndex) / 2;

        if (key < numbers[midIndex]) highIndex = midIndex;
        else if (key > numbers[midIndex]) lowIndex = midIndex + 1;
        else return midIndex + 1;
    }
    throw new ArgumentException("No number in the array!");
}

try
{
    Console.WriteLine("The key is : " + BinarySearch(array, 12));
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
