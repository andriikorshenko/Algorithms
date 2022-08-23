string case1 = "({[]})";
string case2 = "({}a)";
string case3 = "[http(s):...]";
string case4 = "[http{(s):...]";

Dictionary<char, char> _myDictionary = new()
{
    { '(', ')' },
    { '{', '}' },
    { '[', ']' }

};

Console.WriteLine(BreketsChecker(case1));
Console.WriteLine(BreketsChecker(case2));
Console.WriteLine(BreketsChecker(case3));
Console.WriteLine(BreketsChecker(case4));

bool BreketsChecker(string str)
{
    if (string.IsNullOrEmpty(str))
    {
        return false;
    }

    Stack<char> stack = new();

    foreach (var item in str)
    {
        if (_myDictionary.ContainsKey(item))
        {
            stack.Push(item);
        }
        else if (stack.Count == 0) return false;
        else if (!_myDictionary.ContainsValue(item)) continue;
        else if (_myDictionary[stack.Pop()] != item) return false;
    }
    return stack.Count == 0; 
}
