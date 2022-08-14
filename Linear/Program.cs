// Линейный (N).

static int Factorial(int n)
{
    int result = 1;

    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

var result = Factorial(10);

Console.WriteLine(result);