// Кубический (N³).

char[] chars = new char[] { 'A', 'B', 'C' };

for (int i = 0; i < chars.Length; i++)
{
    for (int j = 0; j < chars.Length; j++)
    {
        for (int k = 0; k < chars.Length; k++)
        {
            Console.WriteLine($"{chars[i]}{chars[j]}{chars[k]}");
        }
    }
}