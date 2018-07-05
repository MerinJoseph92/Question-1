using System;



public class Node

{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value, Node left, Node right)

    {
        Value = value;
        Left = left;
        Right = right;

    }

}


public class BinarySearchTree
{
    public static bool Contains(Node root, int value)
    {

        bool status = false;
        if (root != null)
        {

            if (root.Value == value)
            {
                status = true;
                // return true;
            }
            else if (root.Value < value)
            {
                status = Contains(root.Right, value);
            }
            else
            {
                status = Contains(root.Left, value);
            }
        }
        return status;
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);

        Node n3 = new Node(3, null, null);

        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(Contains(n2, 3));
        Console.ReadKey();
    }



}

