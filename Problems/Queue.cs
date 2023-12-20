using DataStructureAndAlgo.Utility;
namespace DataStructureAndAlgo.Problems;

internal class Queue
{
    public int[] QueueArray { get; set; }
    private int Front { get; set; }
    private int Rear { get; set; }
    public int QueueLength { get; set; }

    public Queue(int size)
    {
        QueueArray = new int[size];
        Front = 0;
        Rear = -1;
        QueueLength = 0;
    }

    public void Add(int data)
    {
        Rear++;
        QueueArray[Rear] = data;
        QueueLength++;
        CommonFuncs.PrintArray(QueueArray);
        Console.WriteLine(QueueLength + " Items in the Queue.");
    }

    public void Remove()
    {
        Console.WriteLine(QueueArray[Front] + " Removed");
        Front++;
        QueueLength--;
        CommonFuncs.PrintArray(QueueArray);
        Console.WriteLine(QueueLength + " Items in the Queue.");
    }

    public void Peek()
    {
        Console.WriteLine(QueueArray[Front] + " is Next");
    }
}
