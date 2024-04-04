using DataStructureAndAlgo.Problems;
using DataStructureAndAlgo.Utility;

// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Data Structure and Algorithms!");

# region Working with Arrays
ArrayInsertionAndDeletion arrayInsAndDel = new ArrayInsertionAndDeletion(10);
arrayInsAndDel.Insert(25, 6);
arrayInsAndDel.Insert(99, 9);
arrayInsAndDel.Insert(13, 10);
arrayInsAndDel.Insert(17, 11);
arrayInsAndDel.Delete(7);
arrayInsAndDel.Delete(0);
arrayInsAndDel.Delete(1);
arrayInsAndDel.Delete(12);
arrayInsAndDel.Insert(99, 9);
arrayInsAndDel.Delete(9);

ArraySearch arraySearch = new ArraySearch(20);
bool found = arraySearch.Find(15);
Console.WriteLine("Found :" + found);
#endregion

LinkedList linkedList = new LinkedList();
linkedList.AddData(5);
linkedList.AddData(6);
linkedList.AddData(7);
linkedList.AddData(8);
linkedList.AddData(9);
linkedList.PrintData();

Stack stack = new Stack(10);
CommonFuncs.PrintArray(stack.StackArray);
Console.WriteLine(stack.IsEmpty());
for (int i = 0; i < 10; i++)
    stack.Push(i);
foreach (int i in stack)
    Console.WriteLine(i);
CommonFuncs.PrintArray(stack.StackArray);
Console.WriteLine(stack.IsEmpty());
for (int i = 0; i < 10; i++)
    stack.Pop();
CommonFuncs.PrintArray(stack.StackArray);
Console.WriteLine(stack.IsEmpty());

Console.WriteLine("\n\nQueues");
Queue queue = new Queue(10);
queue.Add(5);
queue.Peek();
queue.Add(6);
queue.Add(7);
queue.Peek();
queue.Remove();
queue.Add(8);
queue.Add(9);
queue.Peek();
queue.Add(10);
queue.Remove();
queue.Peek();

Console.WriteLine("\n\nBinary Search");
int[] data = {100, -45, -20, -21, -16, 0, 2, 4, 8, 16, 32, 64 , -50, -55, -56, -58, -59};
BinarySearch binarySearch = new BinarySearch();
binarySearch.FindItem(data, 64);
binarySearch.FindItem(data, -45);
binarySearch.FindItem(data, -20);
binarySearch.FindItem(data, 32);
binarySearch.FindItem(data, 9);

Console.WriteLine("\n\nBinary Search Tree");
BinarySearchTreeNode binarySearchTreeNode = new BinarySearchTreeNode(data);
binarySearchTreeNode.InsertItem(5);
var foundItem = binarySearchTreeNode.FindItem(220);
var foundItem2 = binarySearchTreeNode.FindItem(5);
Console.WriteLine(foundItem);
Console.WriteLine(foundItem2);

Console.WriteLine("\nBubble Sort");
BubbleSort bubbleSort = new BubbleSort();
CommonFuncs.PrintArray(bubbleSort.Sort(data));
Console.WriteLine();