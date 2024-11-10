namespace BinaryTree.Tree;

public class BinaryTree
{
    private Node? _root;

    public void Add(int value)
    {
        _root = InsertRecursive(_root, value);
    }

    private Node InsertRecursive(Node? root, int value)
    {
        if (root == null)
        {
            return new Node(value);
        }

        if (value > root.Value)
        {
            root.Right =  InsertRecursive(root.Right, value);
        }
        
        if (value < root.Value)
        {
            root.Left =  InsertRecursive(root.Left, value);
        }

        return root;
    }

    public void InOrderTraversal()
    {
        RecursiveInOrderTraversal(_root);
    }

    public void PostOrderTraversal()
    {
        RecursivePostOrderTraversal(_root);
    }

    public void PreOrderTraversal()
    {
        RecursivePreOrderTraversal(_root);
    }

    private void RecursivePreOrderTraversal(Node? root)
    {
        if (root == null)
        {
            return;
        }
        
        Console.Write(root.Value + " ");
        RecursivePreOrderTraversal(root.Left);
        RecursivePreOrderTraversal(root.Right);
    }

    private void RecursivePostOrderTraversal(Node? root)
    {
        if (root == null)
        {
            return;
        }
        
        RecursivePostOrderTraversal(root.Left);
        RecursivePostOrderTraversal(root.Right);
        Console.Write(root.Value + " ");
    }

    private void RecursiveInOrderTraversal(Node? root)
    {
        if (root == null)
        {
            return;
        }
        
        RecursiveInOrderTraversal(root.Left);
        Console.Write(root.Value + " ");
        RecursiveInOrderTraversal(root.Right);
    }
}