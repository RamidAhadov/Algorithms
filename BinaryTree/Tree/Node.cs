namespace BinaryTree.Tree;

public class Node
{
    public int Value { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node()
    {
        Left = null;
        Right = null;
    }

    public Node(int value):this()
    {
        Value = value;
    }
}