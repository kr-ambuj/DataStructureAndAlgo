using DataStructureAndAlgo.Problems;

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