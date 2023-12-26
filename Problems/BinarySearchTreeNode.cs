using DataStructureAndAlgo.Models;

namespace DataStructureAndAlgo.Problems;

internal class BinarySearchTreeNode
{
    BinarySearchNode? RootNode { get; set; }
    public int ItemCount { get; set; }

    public BinarySearchTreeNode()
    {
        ItemCount = 0;
    }

    public BinarySearchTreeNode(int[] dataArr)
    {
        new BinarySearchTreeNode();
        foreach (var item in dataArr) { InsertItem(item); }
    }

    public void InsertItem(int data)
    {
        RootNode = InsertItem(RootNode, data);
    }

    private BinarySearchNode InsertItem(BinarySearchNode node, int data)
    {
        if(node == null)
        {
            ItemCount++;
            BinarySearchNode Node = new BinarySearchNode();
            Node.Key = data;
            return Node;
        }
        else
        {
            if (data < node.Key)
                node.LeftChild = InsertItem(node.LeftChild, data);
            else if (data > node.Key)
                node.RightChild = InsertItem(node.RightChild, data);
        }
        return node;
    }

    internal bool FindItem(int v)
    {
        return FindItem(RootNode, v) == null ? false : true;
    }

    private BinarySearchNode? FindItem(BinarySearchNode? node, int v)
    {
        if (node == null || node.Key == v)
            return node;
        else
        {
            if (v < node.Key)
                node = FindItem(node.LeftChild, v);
            else
                node = FindItem(node.RightChild, v);
        }
        return node;
    }
}
