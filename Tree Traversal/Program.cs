var root = new TreeNode<int>()
{
    Value = 10,
    Left = new TreeNode<int>()
    {
        Value = 20,
        Left = new TreeNode<int>()
        {
            Value = 70
        },
        Right = new TreeNode<int>()
        {
            Value = 90,
            Left = new TreeNode<int>()
            {
                Value = 110
            }
        }
    },
    Right = new TreeNode<int> { Value = 30 }
};

TreeTraversal<int>(root);
Console.WriteLine(String.Join("; ", ToEnumerable2(root)));

// Рекурсивный обход.
static void TreeTraversal<T>(TreeNode<T>? node)
{
    if (node == null)
        return;

    Console.Write(node.Value + "; ");

    TreeTraversal<T>(node.Left);
    TreeTraversal<T>(node.Right);
}

// IEnumerable<T> без рекурсии.
IEnumerable<T> ToEnumerable2<T>(TreeNode<T>? node)
{
    var stack = new Stack<TreeNode<T>>();

    stack.Push(node);

    while (stack.Count > 0)
    {
        var current = stack.Pop();

        if (current == null)
        {
            continue;
        }
        yield return current.Value;

        stack.Push(current.Left);
        stack.Push(current.Right);
    }
}

class TreeNode<T>
{
    public T? Value { get; set; }
    public TreeNode<T>? Left { get; set; }
    public TreeNode<T>? Right { get; set; }
}

