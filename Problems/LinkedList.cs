using DataStructureAndAlgo.Models;

namespace DataStructureAndAlgo.Problems;

internal class LinkedList
{
    internal Node? CurrentNode { get; set; }

    internal void AddData(int Data)
    {
        Node node = new Node();
        node.NodeData = Data;
        node.NextNode = CurrentNode;
        CurrentNode = node;
    }                    
     
    internal void PrintData()
    {
        while(CurrentNode?.NextNode != null)
        {
            Console.WriteLine(CurrentNode.NodeData);
            CurrentNode = CurrentNode.NextNode;
        }
    }
}
